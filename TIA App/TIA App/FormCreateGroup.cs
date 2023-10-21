using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _SW = Siemens.Engineering.SW;

namespace TIA_App {
    public partial class FormCreateGroup : Form {

        private _SW.Blocks.PlcBlockUserGroupComposition parentGroupComposition = null;
        public _SW.Blocks.PlcBlockUserGroup Result { get; private set; }

        public FormCreateGroup(_SW.Blocks.PlcBlockUserGroupComposition pParentGroupComposition) {
            InitializeComponent();

            textbox_groupName.TextChanged += (s, e) => CheckGroupNameIsNotEmpty();
            button_create.Click += (s, e) => CreateGroup();

            parentGroupComposition = pParentGroupComposition;
        }

        private void CheckGroupNameIsNotEmpty() {
            button_create.Enabled = textbox_groupName.Text.Trim().Length > 0;
        }

        private void CreateGroup() {
            try {
                Result = TiaAPI.CreateGroup(parentGroupComposition, textbox_groupName.Text);
            }
            catch (Exception pException) {
                MessageBox.Show(pException.Message, "Group will not be created!");
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
