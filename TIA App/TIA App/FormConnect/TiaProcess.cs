using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _S = Siemens.Engineering;

namespace TIA_App {
    internal class TiaProcess {
        public _S.TiaPortalProcess Instance { get; private set; }

        public TiaProcess(_S.TiaPortalProcess pTiaPortalProcess) {
            TiaUtils.CheckNull(pTiaPortalProcess);
            Instance = pTiaPortalProcess;
        }

        public override string ToString() => Instance.Id.ToString();
    }
}
