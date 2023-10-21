using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIA_App {
    internal partial class FormConnect : Form {

        private TiaProcess tiaProcess => combobox_processes.SelectedItem as TiaProcess;

        public FormConnect() {
            TiaUtils.Log();
            InitializeComponent();

            button_refresh.Click += (s, e) => RefreshProcesses();
            button_connect.Click += (s, e) => ConnectProcess();

            RefreshProcesses();
        }

        private void RefreshProcesses() {
            TiaUtils.Log();
            TiaUtils.Lock(this, () => {
                combobox_processes.Reset();

                TiaProcess[] processes = TiaAPI.GetTiaPortalProcesses()
                    .Select(process => new TiaProcess(process))
                    .ToArray();


                combobox_processes.Populate(processes);
            });
        }

        private void ConnectProcess() {
            TiaUtils.Log();
            TiaAPI.ConnectToTiaPortalProcess(tiaProcess.Instance);
        }
    }
}
