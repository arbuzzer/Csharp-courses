using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.Second
{
    class Program
    {
        private static void PrintMenu() {
            Console.WriteLine("Select playback component (specify index):");
            Console.WriteLine($"1 - {nameof(iPhoneHeadset)}");
            Console.WriteLine($"2 - {nameof(SamsungHeadset)}");
            Console.WriteLine($"3 - {nameof(UnofficialiPhoneHeadset)}");
            Console.WriteLine($"4 - {nameof(PhoneSpeaker)}");
        }

        private static int GetValidInputNumber() {
            int choiseHeadset;
            bool isInputNumberValid;

            do {
                bool isInputNumber = Int32.TryParse(Console.ReadLine(), out choiseHeadset);
                bool isNumberLogicallyValid = choiseHeadset > 0 && choiseHeadset < 5;

                isInputNumberValid = isInputNumber && isNumberLogicallyValid;

                if (!isInputNumberValid) {
                    Console.WriteLine("We have only 4 index. Try again");
                }

            } while (!isInputNumberValid);

            return choiseHeadset;
        }

        static void Main(string[] args) {
            iPhoneHeadset iphoneHeadset = new iPhoneHeadset(new ConsoleOutput());
            SamsungHeadset samsungHeadset = new SamsungHeadset(new ConsoleOutput());
            UnofficialiPhoneHeadset unofficialiPhoneHeadset = new UnofficialiPhoneHeadset(new ConsoleOutput());
            PhoneSpeaker phoneSpeaker = new PhoneSpeaker(new ConsoleOutput());

            Dictionary<int, IPlayback> playbacks = new Dictionary<int, IPlayback>() {
                { 1, iphoneHeadset },
                { 2, samsungHeadset },
                { 3, unofficialiPhoneHeadset },
                { 4, phoneSpeaker },
            };

            PrintMenu();

            int choiseHeadset = GetValidInputNumber();

            Console.WriteLine(playbacks[choiseHeadset].GetType().Name + " playback selected");
            Console.WriteLine($"Set payback to Mobile...");
            Console.WriteLine($"Play sound in Mobile:");

            SimcorpMobile simcorpMobile = new SimcorpMobile(playbacks[choiseHeadset]);
            simcorpMobile.Play("Song");
        }
    }
}
