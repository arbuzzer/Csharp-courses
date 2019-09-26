using System.Threading;

namespace Simcorp.Laboratory.MobileFeatures {
    public abstract class Battery {
        public delegate void BatteryDelegate(int percentage);
        public event BatteryDelegate BatteryCharged;
        static object locker = new object();

        private string BatteryCapacity { get; }

        private string BatteryDuration { get; }

        public int BatteryState { get; set; }

        protected Battery() {
            BatteryCapacity = "1960 mAh";
            BatteryDuration = "17h 23m";
        }

        public override string ToString() {
            return $" battery which capacity {BatteryCapacity} and use duration {BatteryDuration}. ";
        }

        internal void BatteryChargingTimer() {
            lock(locker) {
                var autoEvent = new AutoResetEvent(false);
                var startCharging = new Timer(state => RaiseBatteryChargedEvent(BatteryState), autoEvent, 0, 1000);
            }
        }

        private void RaiseBatteryChargedEvent(int percentage) {
            BatteryCharged?.Invoke(percentage);
        }
    }

    public class LithiumIon : Battery {
        public override string ToString() {
            return "Lithium-Ion" + base.ToString();
        }
    }

    public class NickelCadmium : Battery {
        public override string ToString() {
            return "Nickel Cadmium" + base.ToString();
        }
    }
}
