using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIA_App {
    internal class TiaApplication {
        public TiaApplication() {
            TiaUtils.Log();
        }

        public void Run() {
            TiaUtils.Log();
            using (FormConnect formConnect = new FormConnect()) {
                DialogResult formConnect_dialogResult = formConnect.ShowDialog();
                if (formConnect_dialogResult == DialogResult.OK) {
                    using (FormMain formMain = new FormMain()) {
                        formMain.ShowDialog();
                    }
                }
            }
        }
    }
}
