namespace Simcorp.Laboratory.Fourth.MobileChargers {
    public class LightningCharger : ICharger {
        private IOutput Output;

        public LightningCharger(IOutput output) {
            Output = output;
        }

        public void Charge() {
            Output.WriteLine($"Uses {nameof(LightningCharger)} charger");
        }
    }
}
