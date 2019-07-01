using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simcorp.Laboratory.Library;

namespace Simcorp.Laboratory.Second
{
    public class ConsoleOutput : IOutput
    {
        public void Write(string text) {
            Console.Write(text);
        }

        public void WriteLine(string text) {
            Console.WriteLine(text);
        }
    }
}
