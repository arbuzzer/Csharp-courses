using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.Second.WinForms
{
    public class UsbTypeCCharger : ICharger
    {
        private IOutput Output;

        public UsbTypeCCharger(IOutput output) {
            Output = output;
        }

        public void Charge() {
            Output.Write($"{nameof(UsbTypeCCharger)} charger selected\r\n" +
                "Set charger to Mobile...\r\n" +
                "Start charging the Mobile:\r\n" +
                $"Using {nameof(UsbTypeCCharger)} charger");
        }
    }
}
