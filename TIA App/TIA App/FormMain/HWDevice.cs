using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _HW = Siemens.Engineering.HW;

namespace TIA_App {
    internal class HWDevice {
        public _HW.Device Instance {  get; private set; }

        public HWDevice(_HW.Device pDevice) {
            TiaUtils.CheckNull(pDevice);
            Instance = pDevice;
        }

        public override string ToString() => Instance.Name;

        public _HW.DeviceItem[] GetDeviceItems(_HW.DeviceItemClassifications pDeviceItemClassification) =>
            Instance.DeviceItems.Where(deviceItem => deviceItem.Classification == pDeviceItemClassification).ToArray();
    }
}
