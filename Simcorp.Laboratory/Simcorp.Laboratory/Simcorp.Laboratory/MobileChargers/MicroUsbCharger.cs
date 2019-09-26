namespace Simcorp.Laboratory.MobileChargers {
    public class MicroUsbCharger : ICharger {
        private IOutput Output;

        public MicroUsbCharger(IOutput output) {
            Output = output;
        }

        public void Charge() {
            Output.WriteLine($"Uses {nameof(MicroUsbCharger)} charger");
        }
    }
}
