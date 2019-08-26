using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Simcorp.Laboratory.Fourth {
    static class Program {
        internal static readonly Dictionary<string, Func<Message, string[]>> FormatOfMessage = new Dictionary<string, Func<Message, string[]>> {
            { "Start with DateTime", (message) => new string[] { message.ReceivingTime.ToString(), message.User, message.Notification, message.Text } },
            { "End with DateTime", (message) => new string[] { message.User, message.Notification, message.Text, message.ReceivingTime.ToString() } },
            { "Uppercase", (message) => new string[] { message.ReceivingTime.ToString(), message.User, message.Notification, message.Text.ToUpper() } },
            { "Lowercase", (message) => new string[] { message.User, message.Notification, message.Text.ToLower(), message.ReceivingTime.ToString() } },
            { "None",  (message) => new string[] { string.Empty } }
        };

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MessageFormatting());
        }
    }
}
