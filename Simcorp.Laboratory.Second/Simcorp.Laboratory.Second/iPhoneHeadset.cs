using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.Second
{
    public class iPhoneHeadset : IPlayback
    {
        private IOutput Output;

        public iPhoneHeadset(IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.WriteLine($"{nameof(iPhoneHeadset)} sound {data}");
        }
    }
}
