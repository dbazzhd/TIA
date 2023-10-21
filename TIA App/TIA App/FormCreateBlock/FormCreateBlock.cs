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
using _LIB = Siemens.Engineering.Library;

namespace TIA_App {
    public partial class FormCreateBlock : Form {

        private _SW.Blocks.PlcBlockComposition parentBlockComposition = null;
        public _SW.Blocks.PlcBlock Result { get; private set; }

        private string blockName => textbox_blockName.Text;
        private MasterCopy masterCopy => combobox_masterCopies.SelectedItem as MasterCopy;

        public FormCreateBlock(_SW.Blocks.PlcBlockComposition pParentBlockComposition) {
            InitializeComponent();

            textbox_blockName.TextChanged += (s, e) => CheckPropertiesAreNotEmpty();
            combobox_masterCopies.SelectedIndexChanged += (s, e) => CheckPropertiesAreNotEmpty();
            button_refresh.Click += (s, e) => RefreshMasterCopies();
            button_create.Click += (s, e) => CreateBlock();

            parentBlockComposition = pParentBlockComposition;

            RefreshMasterCopies();
        }

        private void RefreshMasterCopies() {
            TiaUtils.Log();
            TiaUtils.Lock(this, () => {
                combobox_masterCopies.Reset();

                MasterCopy[] masterCopies = TiaAPI.MasterCopies
                    .Select(masterCopy => new MasterCopy(masterCopy))
                    .ToArray();

                combobox_masterCopies.Populate(masterCopies);
            });
        }

        private void CheckPropertiesAreNotEmpty() {
            button_create.Enabled = 
                blockName.Trim().Length > 0 &&
                masterCopy != null;
        }

        private void CreateBlock() {
            try {
                Result = TiaAPI.CreateBlock(parentBlockComposition, masterCopy.Instance);
                Result.Name = blockName;
                Result.AutoNumber = true;
            }
            catch (Exception pException) {
                MessageBox.Show(pException.Message, "Block will not be created!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
