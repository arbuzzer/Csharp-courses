using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.First
{
    public abstract class Battery
    {
        public string BatteryCapacity { get; }
        public string BatteryDuration { get; }
        public Battery()
        {
            BatteryCapacity = "1960 mAh";
            BatteryDuration = "17h 23m";
        }
        public abstract string ToString();
    }
    public abstract class SecondaryBatteries : Battery
    {
        public override string ToString()
        {
            return $" battery which capacity {BatteryCapacity} and use duration {BatteryDuration}. ";
        }
    }
    public class LithiumIon : SecondaryBatteries
    {
        public override string ToString()
        {
            return "Lithium-Ion" + base.ToString();
        }
    }
    public class NickelCadmium : SecondaryBatteries
    {
        public override string ToString()
        {
            return "Nickel Cadmium" + base.ToString();
        }
    }
}
