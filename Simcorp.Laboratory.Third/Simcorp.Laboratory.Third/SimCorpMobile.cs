using Simcorp.Laboratory.Third.MobileFeatures;

namespace Simcorp.Laboratory.Third
{
    public class SimcorpMobile : Mobile
    {
        public SimcorpMobile(MultiTouchScreen screen, LithiumIon battery, SingleModule camera, Stereo speaker, SMSProvider smsProvider) :
            base(screen, battery, camera, speaker, smsProvider) { }
    }
}
