namespace Simcorp.Laboratory.MobileSpeakers {
    public class PhoneSpeaker : IPlayback {
        private IOutput Output;

        public PhoneSpeaker(IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.WriteLine($"{nameof(PhoneSpeaker)} play {data}");
        }
    }
}
