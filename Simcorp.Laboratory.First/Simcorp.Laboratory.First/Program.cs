using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.First
{
    public class Program
    {
        static void Main(string[] args)
        {
            SimcorpMobile simcorpMobile = new SimcorpMobile(new MultiTouchScreen(), new LithiumIon(), new SingleModule(), new Stereo());
            Console.WriteLine("Our phone have next properties: \n" + simcorpMobile.ToString());
        }
    }
}
