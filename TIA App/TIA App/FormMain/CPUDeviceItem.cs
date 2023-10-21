using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _HW = Siemens.Engineering.HW;

namespace TIA_App {
    internal class CPUDeviceItem {
        public _HW.DeviceItem Instance { get; private set; }

        public CPUDeviceItem(_HW.DeviceItem pDeviceItem) {
            TiaUtils.CheckNull(pDeviceItem);
            Instance = pDeviceItem;
        }

        public override string ToString() => Instance.Name;

        public T GetSoftware<T>() where T : _HW.Software =>
            Instance.GetService<_HW.Features.SoftwareContainer>()?.Software as T;

    }
}
