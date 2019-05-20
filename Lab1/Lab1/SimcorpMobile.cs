using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class SimcorpMobile : Mobile
    {
        private readonly MultiTouchScreen multiTouchScreen = new MultiTouchScreen();
        public override Screen Screen { get { return multiTouchScreen; } }

        private readonly LithiumIon lithiumIon = new LithiumIon();
        public override Battery Battery { get { return lithiumIon; } }

        private readonly SingleModule singleModule = new SingleModule();
        public override Camera Camera { get { return singleModule; } }

        private readonly Stereo stereo = new Stereo();
        public override Speaker Speaker { get { return stereo; } }
    }
}
