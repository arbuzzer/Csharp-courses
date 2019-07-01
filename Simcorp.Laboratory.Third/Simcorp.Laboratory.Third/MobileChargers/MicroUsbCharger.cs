using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.Third.MobileChargers
{
    public class MicroUsbCharger : ICharger
    {
        private IOutput Output;

        public MicroUsbCharger(IOutput output) {
            Output = output;
        }

        public void Charge() {
            Output.WriteLine($"Uses {nameof(MicroUsbCharger)} charger");
        }
    }
}
