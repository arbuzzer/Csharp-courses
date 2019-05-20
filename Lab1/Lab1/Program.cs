using System;
using System.Collections.Generic;

namespace Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            SimcorpMobile simcorpMobile = new SimcorpMobile();
            Console.WriteLine("Our phone have next properties: \n" + simcorpMobile.MobileDescription());
        }
    }
}
