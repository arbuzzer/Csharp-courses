namespace Simcorp.Laboratory.MobileSpeakers {
    public class SamsungHeadset : IPlayback {
        private IOutput Output;

        public SamsungHeadset(IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.WriteLine($"{nameof(SamsungHeadset)} play {data}");
        }
    }
}
