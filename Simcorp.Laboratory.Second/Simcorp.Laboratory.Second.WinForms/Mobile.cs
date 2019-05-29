using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.Second.WinForms
{
    public abstract class Mobile
    {
        public ICharger ChargerComponent { get; set; }

        public void Charge() {
            ChargerComponent.Charge();
        }
    }
}
