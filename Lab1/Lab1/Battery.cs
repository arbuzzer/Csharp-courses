using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public abstract class Battery
    {
        public string BatteryCapacity { get; set; }
        public string BatteryDuration { get; set; }
        public Battery()
        {
            BatteryCapacity = "1960 mAh";
            BatteryDuration = "17h 23m";
        }
        public abstract string GetDescription();
    }
    public abstract class SecondaryBatteries : Battery
    {
        public override string GetDescription()
        {
            return $" battery which capacity {BatteryCapacity} and use duration {BatteryDuration}. ";
        }
    }
    public class LithiumIon : SecondaryBatteries
    {
        public override string GetDescription()
        {
            return "Lithium-Ion" + base.GetDescription();
        }
    }
    public class NickelCadmium : SecondaryBatteries
    {
        public override string GetDescription()
        {
            return "Nickel Cadmium" + base.GetDescription();
        }
    }
}
