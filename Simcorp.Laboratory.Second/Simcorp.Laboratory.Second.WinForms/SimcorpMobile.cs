using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.Second.WinForms
{
    public class SimcorpMobile : Mobile
    {
        public SimcorpMobile(ICharger chargerComponent) {
            this.ChargerComponent = chargerComponent;
        }
    }
}
