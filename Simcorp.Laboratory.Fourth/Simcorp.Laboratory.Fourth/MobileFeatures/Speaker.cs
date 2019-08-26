namespace Simcorp.Laboratory.Fourth.MobileFeatures {
    public abstract class Speaker {
        public string SpeakerFeature { get; }

        public string SpeakerFrequency { get; }

        public Speaker() {
            SpeakerFeature = "active noise cancellation with dedicated mic";
            SpeakerFrequency = "from 20 Hz to 20,000 Hz";
        }

        public override string ToString()
        {
            return $" who work on frequency {SpeakerFrequency} and have one feature - {SpeakerFeature}. ";
        }
    }

    public class Stereo : Speaker
    {
        public override string ToString() {
            return "Stereo" + base.ToString();
        }
    }

    public class Mono : Speaker
    {
        public override string ToString() {
            return "Mono" + base.ToString();
        }
    }
}
