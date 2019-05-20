using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_WinForm
{
    public class MicroUsbCharger : ICharge
    {
        //public void Charge(object data) {
        //    Console.WriteLine($"Using {nameof(MicroUsbCharger)}");
        //}
        public string Charge() {
            return "Using " + nameof(MicroUsbCharger);
        }
    }
}
