using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.Third.MobileFeatures
{
    public abstract class Speaker
    {
        public string SpeakerFeature { get; }
        public string SpeakerFrequency { get; }
        public Speaker() {
            SpeakerFeature = "active noise cancellation with dedicated mic";
            SpeakerFrequency = "from 20 Hz to 20,000 Hz";
        }
        public abstract string ToString();
    }
    public abstract class SpeakerType : Speaker
    {
        public override string ToString() {
            return $" who work on frequency {SpeakerFrequency} and have one feature - {SpeakerFeature}. ";
        }
    }
    public class Stereo : SpeakerType
    {
        public override string ToString() {
            return "Stereo" + base.ToString();
        }
    }
    public class Mono : SpeakerType
    {
        public override string ToString() {
            return "Mono" + base.ToString();
        }
    }
}
