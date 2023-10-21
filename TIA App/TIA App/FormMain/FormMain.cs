using Siemens.Engineering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _HW = Siemens.Engineering.HW;
using _SW = Siemens.Engineering.SW;

namespace TIA_App {
    public partial class FormMain : Form {

        private HWDevice hwDevice => combobox_hwDevices.SelectedItem as HWDevice;
        private CPUDeviceItem cpuDeviceItem => combobox_cpuDeviceItems.SelectedItem as CPUDeviceItem;
        private _SW.PlcSoftware plcSoftware => cpuDeviceItem.GetSoftware<_SW.PlcSoftware>();

        public FormMain() {
            InitializeComponent();

            button_refreshHWDevices.Click += (s, e) => RefreshHWDevices();
            button_refreshCPUDeviceItems.Click += (s, e) => RefreshCPUDeviceItems();
            button_refreshTreeView.Click += (s, e) => RefreshTreeView();
            combobox_hwDevices.SelectedIndexChanged += (s, e) => RefreshCPUDeviceItems();
            combobox_cpuDeviceItems.SelectedIndexChanged += (s, e) => RefreshTreeView();

            value_projectName.Text = TiaAPI.Project.Name;
            value_projectPath.Text = TiaAPI.Project.Path.DirectoryName;

            RefreshHWDevices();
        }

        private void RefreshHWDevices() {
            TiaUtils.Log();
            TiaUtils.Lock(this, () => {
                combobox_hwDevices.Reset();

                if (TiaAPI.Project != null) {
                    HWDevice[] devices = TiaAPI.Project.Devices
                        .Select(device => new HWDevice(device))
                        .ToArray();

                    combobox_hwDevices.Populate(devices);
                }
            });
        }

        private void RefreshCPUDeviceItems() {
            TiaUtils.Log();
            TiaUtils.Lock(this, () => {
                combobox_cpuDeviceItems.Reset();

                if (hwDevice != null) {
                    CPUDeviceItem[] devices = hwDevice.GetDeviceItems(_HW.DeviceItemClassifications.CPU)
                        .Select(device => new CPUDeviceItem(device))
                        .ToArray();

                    combobox_cpuDeviceItems.Populate(devices);
                }
            });
        }

        private void RefreshTreeView() {
            TiaUtils.Log();
            TiaUtils.Lock(this, () => {
                treeview_cpuDeviceItem.Nodes.Clear();

                if (plcSoftware != null) {
                    treeview_cpuDeviceItem.BeginUpdate();

                    TreeNode rootNode = new TreeNode();
                    rootNode.Initialize(plcSoftware);
                    treeview_cpuDeviceItem.Nodes.Add(rootNode);

                    CreateSubBlocks(rootNode, plcSoftware.BlockGroup.Blocks);
                    CreateSubGroups(rootNode, plcSoftware.BlockGroup.Groups);
                    rootNode.Expand();

                    treeview_cpuDeviceItem.EndUpdate();
                }
            });
        }

        private void CreateSubBlocks(TreeNode pParentNode, _SW.Blocks.PlcBlockComposition pBlocks) {
            foreach (_SW.Blocks.PlcBlock block in pBlocks) {
                TreeNode blockNode = new TreeNode();
                blockNode.Initialize(block);
                pParentNode.Nodes.Add(blockNode);
            }
        }

        private void CreateSubGroups(TreeNode pParentNode, _SW.Blocks.PlcBlockUserGroupComposition pGroups) {
            foreach (_SW.Blocks.PlcBlockUserGroup group in pGroups) {
                TreeNode groupNode = new TreeNode();
                groupNode.Initialize(group);
                pParentNode.Nodes.Add(groupNode);

                CreateSubBlocks(groupNode, group.Blocks);
                CreateSubGroups(groupNode, group.Groups);
            }
        }
    }
}
