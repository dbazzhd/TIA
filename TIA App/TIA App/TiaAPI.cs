
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;

using _S = Siemens.Engineering;
using _Compiler = Siemens.Engineering.Compiler;
using _HMI = Siemens.Engineering.Hmi;
using _HW = Siemens.Engineering.HW;
using _SW = Siemens.Engineering.SW;
using _LIB = Siemens.Engineering.Library;

namespace TIA_App {
    public static class TiaAPI {

        public static _S.TiaPortal TiaPortal = null;
        public static _S.Project Project => TiaPortal?.Projects.FirstOrDefault();
        public static _LIB.ProjectLibrary ProjectLibrary => Project?.ProjectLibrary;
        public static _LIB.MasterCopies.MasterCopy[] MasterCopies => ProjectLibrary?.MasterCopyFolder.MasterCopies.ToArray();

        public static IList<_S.TiaPortalProcess> GetTiaPortalProcesses() => _S.TiaPortal.GetProcesses();

        public static void ConnectToTiaPortalProcess(_S.TiaPortalProcess pTiaPortalProcess) {
            TiaUtils.CheckNull(pTiaPortalProcess);
            TiaPortal = _S.TiaPortal.GetProcess(pTiaPortalProcess.Id, 5000).Attach();
        }

        public static _SW.Blocks.PlcBlock CreateBlock(_SW.Blocks.PlcBlockComposition pParentBlockComposition, _LIB.MasterCopies.MasterCopy pMasterCopy) {
            TiaUtils.CheckNull(pParentBlockComposition);
            TiaUtils.CheckNull(pMasterCopy);
            return pParentBlockComposition.CreateFrom(pMasterCopy);
        }

        public static _SW.Blocks.PlcBlockUserGroup CreateGroup(_SW.Blocks.PlcBlockUserGroupComposition pParentGroupComposition, string pGroupName) {
            TiaUtils.CheckNull(pParentGroupComposition);
            return pParentGroupComposition.Create(pGroupName);
        }

    }
}
