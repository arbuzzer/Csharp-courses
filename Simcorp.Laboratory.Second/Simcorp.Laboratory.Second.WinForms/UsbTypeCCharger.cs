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
            Output.Write($"Uses {nameof(UsbTypeCCharger)} charger");
        }
    }
}
