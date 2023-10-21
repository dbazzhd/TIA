using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _LIB = Siemens.Engineering.Library;

namespace TIA_App {
    internal class MasterCopy {
        public _LIB.MasterCopies.MasterCopy Instance { get; private set; }

        public MasterCopy(_LIB.MasterCopies.MasterCopy pMasterCopy) {
            TiaUtils.CheckNull(pMasterCopy);
            Instance = pMasterCopy;
        }

        public override string ToString() => Instance.Name;
    }
}
