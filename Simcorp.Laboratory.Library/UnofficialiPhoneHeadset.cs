using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.Library
{
    public class UnofficialiPhoneHeadset : IPlayback
    {
        private IOutput Output;

        public UnofficialiPhoneHeadset(IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.WriteLine($"{nameof(UnofficialiPhoneHeadset)} play {data}");
        }
    }
}
