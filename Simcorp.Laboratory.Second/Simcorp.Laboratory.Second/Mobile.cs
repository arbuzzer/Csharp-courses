using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.Second
{
    public abstract class Mobile
    {
        public IPlayback PlaybackComponent { get; set; }
        public void Play(object data) {
            PlaybackComponent.Play(data);
        }
    }
}
