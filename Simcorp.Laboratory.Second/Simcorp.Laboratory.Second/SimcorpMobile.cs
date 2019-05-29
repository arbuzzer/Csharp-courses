using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.Second
{
    public class SimcorpMobile : Mobile
    {
        public SimcorpMobile(IPlayback playbackComponent) {
            this.PlaybackComponent = playbackComponent;
        }
    }
}
