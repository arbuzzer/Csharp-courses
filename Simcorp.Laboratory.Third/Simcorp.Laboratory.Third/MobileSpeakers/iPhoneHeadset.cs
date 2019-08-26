namespace Simcorp.Laboratory.Third.MobileSpeakers {
    public class iPhoneHeadset : IPlayback {
        private IOutput Output;

        public iPhoneHeadset(IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.WriteLine($"{nameof(iPhoneHeadset)} play {data}");
        }
    }
}
