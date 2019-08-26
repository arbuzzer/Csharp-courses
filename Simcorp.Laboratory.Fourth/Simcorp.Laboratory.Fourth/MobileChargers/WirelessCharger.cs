namespace Simcorp.Laboratory.Fourth.MobileChargers {
    public class WirelessCharger : ICharger {
        private IOutput Output;

        public WirelessCharger(IOutput output) {
            Output = output;
        }

        public void Charge() {
            Output.WriteLine($"Uses {nameof(WirelessCharger)} for charging");
        }
    }
}
