namespace Simcorp.Laboratory.Fourth.MobileFeatures {
    public abstract class Battery {
        public string BatteryCapacity { get; }

        public string BatteryDuration { get; }

        public Battery() {
            BatteryCapacity = "1960 mAh";
            BatteryDuration = "17h 23m";
        }

        public override string ToString()
        {
            return $" battery which capacity {BatteryCapacity} and use duration {BatteryDuration}. ";
        }
    }

    public class LithiumIon : Battery
    {
        public override string ToString() {
            return "Lithium-Ion" + base.ToString();
        }
    }

    public class NickelCadmium : Battery
    {
        public override string ToString() {
            return "Nickel Cadmium" + base.ToString();
        }
    }
}
