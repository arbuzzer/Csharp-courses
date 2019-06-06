using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.Library
{
    public class UsbTypeCCharger : ICharger
    {
        private IOutput Output;

        public UsbTypeCCharger(IOutput output) {
            Output = output;
        }

        public void Charge() {
            Output.WriteLine($"Uses {nameof(UsbTypeCCharger)} charger");
        }
    }
}
