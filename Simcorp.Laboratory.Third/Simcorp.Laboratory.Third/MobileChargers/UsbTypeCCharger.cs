namespace Simcorp.Laboratory.Third.MobileChargers {
    public class UsbTypeCCharger : ICharger {
        private IOutput Output;

        public UsbTypeCCharger(IOutput output) {
            Output = output;
        }

        public void Charge() {
            Output.WriteLine($"Uses {nameof(UsbTypeCCharger)} charger");
        }
    }
}
