using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_WinForm
{
    public class UsbCCharger : ICharge
    {
        //public void Charge(object data) {
        //    Console.WriteLine($"Using {nameof(UsbCCharger)}");
        //}
        public string Charge() {
            return "Using " + nameof(UsbCCharger);
        }
    }
}
