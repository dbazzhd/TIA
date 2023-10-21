using Siemens.Engineering.HW;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _SW = Siemens.Engineering.SW;

namespace TIA_App {
    internal static class TiaUtils {
        public static void Reset(this ComboBox pComboBox) {
            pComboBox.Items.Clear();
            pComboBox.SelectedIndex = -1;
        }

        public static void Populate(this ComboBox pComboBox, object[] pItems) {
            if (pItems.Length > 0) {
                pComboBox.Items.AddRange(pItems);
                pComboBox.SelectedIndex = 0;
            }
        }

        private static ContextMenu CreateContextMenu(params MenuItem[] pMenuItems) {
            return new ContextMenu(pMenuItems);
        }

        public static void Initialize(this TreeNode pTreeNode, object pObject) {
            string text = "";
            object tag = null;
            string imageKey = "";
            ContextMenu contextMenu = null;

            if (pObject is _SW.PlcSoftware) {
                _SW.PlcSoftware software = pObject as _SW.PlcSoftware;
                text = software.Name;
                tag = software;
                imageKey = "PB";
                contextMenu = CreateContextMenu(
                        new MenuItem("Print Name", (s, e) => TiaUtils.PrintName(software.Name)),
                        new MenuItem("Create new Block", (s, e) => pTreeNode.CreateBlock(software.BlockGroup.Blocks)),
                        new MenuItem("Create new Group", (s, e) => pTreeNode.CreateGroup(software.BlockGroup.Groups))
                );
            }
            else if (pObject is _SW.Blocks.PlcBlock) {
                _SW.Blocks.PlcBlock block = pObject as _SW.Blocks.PlcBlock;
                text = block.Name;
                tag = block;
                imageKey = "FC";
                contextMenu = CreateContextMenu(
                        new MenuItem("Print Name", (s, e) => TiaUtils.PrintName(block.Name))
                );
            }
            else if (pObject is _SW.Blocks.PlcBlockUserGroup) {
                _SW.Blocks.PlcBlockUserGroup group = pObject as _SW.Blocks.PlcBlockUserGroup;
                text = group.Name;
                tag = group;
                imageKey = "G";
                contextMenu = CreateContextMenu(
                        new MenuItem("Print Name", (s, e) => TiaUtils.PrintName(group.Name)),
                        new MenuItem("Create new Block", (s, e) => pTreeNode.CreateBlock(group.Blocks)),
                        new MenuItem("Create new Group", (s, e) => pTreeNode.CreateGroup(group.Groups))
                );
            }

            pTreeNode.Text = text;
            // pTreeNode.Tag = tag;
            pTreeNode.ImageKey = imageKey;
            pTreeNode.SelectedImageKey = imageKey;
            pTreeNode.ContextMenu = contextMenu;
        }

        private static void PrintName(string pName) {
            TiaUtils.Log(pName);
        }

        private static void CreateBlock(this TreeNode pParentNode, _SW.Blocks.PlcBlockComposition pParentBlockComposition) {
            TiaUtils.Log();
            TiaUtils.CheckNull(pParentBlockComposition);
            using (FormCreateBlock formCreateBlock = new FormCreateBlock(pParentBlockComposition)) {
                if (formCreateBlock.ShowDialog() == DialogResult.OK) {
                    TreeNode blockNode = new TreeNode();
                    blockNode.Initialize(formCreateBlock.Result);
                    pParentNode.Nodes.Add(blockNode);
                    pParentNode.Expand();
                }
            }
        }

        private static void CreateGroup(this TreeNode pParentNode, _SW.Blocks.PlcBlockUserGroupComposition pParentGroupComposition) {
            TiaUtils.Log();
            TiaUtils.CheckNull(pParentGroupComposition);
            using (FormCreateGroup formCreateGroup = new FormCreateGroup(pParentGroupComposition)) {
                if (formCreateGroup.ShowDialog() == DialogResult.OK) {
                    TreeNode groupNode = new TreeNode();
                    groupNode.Initialize(formCreateGroup.Result);
                    pParentNode.Nodes.Add(groupNode);
                    pParentNode.Expand();
                }
            }

        }

        public static void Lock(Control pControl, Action pAction) {
            pControl.Enabled = false;
            pControl.Invalidate(true);
            pAction();
            pControl.Enabled = true;
            pControl.Invalidate(true);
        }

        public static void Log(string pMessage = "", [CallerFilePath] string pPath = "", [CallerMemberName] string pMember = "") {
            Console.WriteLine($"[{TiaUtils.GetCallerName(pPath, pMember)}]{(pMessage.Trim().Length > 0 ? $": {pMessage}" : "")}");
        }

        public static void CheckNull(object pObject, [CallerFilePath] string pPath = "", [CallerMemberName] string pMember = "") {
            if (pObject == null) {
                throw new ArgumentNullException($"[{TiaUtils.GetCallerName(pPath, pMember)}] One of the parameters is null!");
            }
        }

        private static string GetCallerName(string pPath, string pMember) {
            string[] splitPath = pPath.Split(Path.DirectorySeparatorChar);
            string className = splitPath[splitPath.Length - 1].Split('.')[0];
            return $"{className}{(pMember.StartsWith(".") ? "" : ".")}{pMember}";
        }
    }
}
