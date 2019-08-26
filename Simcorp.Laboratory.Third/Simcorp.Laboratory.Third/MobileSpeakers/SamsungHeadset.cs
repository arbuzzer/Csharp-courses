namespace Simcorp.Laboratory.Third.MobileSpeakers {
    public class SamsungHeadset : IPlayback {
        private readonly IOutput Output;

        public SamsungHeadset(IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.WriteLine($"{nameof(SamsungHeadset)} play {data}");
        }
    }
}
