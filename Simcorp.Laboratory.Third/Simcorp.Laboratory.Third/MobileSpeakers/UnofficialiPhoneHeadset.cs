namespace Simcorp.Laboratory.Third.MobileSpeakers {
    public class UnofficialiPhoneHeadset : IPlayback {
        private IOutput Output;

        public UnofficialiPhoneHeadset(IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.WriteLine($"{nameof(UnofficialiPhoneHeadset)} play {data}");
        }
    }
}
