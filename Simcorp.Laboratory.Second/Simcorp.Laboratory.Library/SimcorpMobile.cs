using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.Library
{
    public class SimcorpMobile : Mobile
    {
        private readonly MultiTouchScreen multiTouchScreen = new MultiTouchScreen();
        private readonly LithiumIon lithiumIon = new LithiumIon();
        private readonly SingleModule singleModule = new SingleModule();
        private readonly Stereo stereo = new Stereo();

        public SimcorpMobile(MultiTouchScreen screen, LithiumIon battery, SingleModule camera, Stereo speaker) : base(screen, battery, camera, speaker) {
            multiTouchScreen = screen;
            lithiumIon = battery;
            singleModule = camera;
            stereo = speaker;
        }
        public void SimcorpMobileCharger(ICharger chargerComponent) {
            this.ChargerComponent = chargerComponent;
        }

        public void SimcorpMobilePlayback(IPlayback playbackComponent) {
            this.PlaybackComponent = playbackComponent;
        }
    }
}
