using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var multiTouchScreen = new MultiTouchScreen();
            var lithiumIon = new LithiumIon();
            var singleModule = new SingleModule();
            var stereoDynamic = new Stereo();

            //List<Screen> screens = new List<Screen>() {
            //    multiTouchScreen                
            //};

            //foreach (var screen in screens)
            //{
            //    Console.WriteLine("Screen tpye: " + screen.GetDescription());
            //}

            var mobilePhone = new MobilePhone(multiTouchScreen, lithiumIon, singleModule, stereoDynamic);

            Console.WriteLine("Our phone have next properties: " + mobilePhone.GetDescription());

            //var mobilePhone1 = new MobilePhone(multiTouchScreen, lithiumIon);

            //List<MobilePhone> mobilePhones = new List<MobilePhone>() {
            //    mobilePhone1
            //};

            //foreach (var mobilePhone in mobilePhones)
            //{
            //    Console.WriteLine("Our phone properties: " + mobilePhone.GetDescription());
            //}
        }
    }
}
