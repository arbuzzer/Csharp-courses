using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Simcorp.Laboratory.Third
{
    static class Program
    {
        internal static readonly Dictionary<string, Func<string, string>> FormatOfMessage = new Dictionary<string, Func<string, string>> {
            { "Start with DateTime", (message) => $"[{DateTime.Now}] {message}{Environment.NewLine}" },
            { "End with DateTime", (message) => $"{message} [{DateTime.Now}]{Environment.NewLine}" },
            { "Uppercase", (message) => $"[{DateTime.Now}] {message.ToUpper()}{Environment.NewLine}" },
            { "Lowercase", (message) => $"[{DateTime.Now}] {message.ToLower()}{Environment.NewLine}" },
            { "None",  (message) => string.Empty }
        };

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
