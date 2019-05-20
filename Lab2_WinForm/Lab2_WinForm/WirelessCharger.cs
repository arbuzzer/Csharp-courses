using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_WinForm
{
    public class WirelessCharger : ICharge
    {
        //public void Charge(object data) {
        //    Console.WriteLine($"Using {nameof(WirelessCharger)}");
        //}
        public string Charge() {
            return "Using " + nameof(WirelessCharger);
        }
    }
}
