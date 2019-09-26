using System;
using System.Collections.Generic;

namespace Simcorp.Laboratory {
    static class MessageFormat {
        internal static readonly Dictionary<string, Func<Message, string[]>> FormatOfMessage = new Dictionary<string, Func<Message, string[]>> {
            { "Start with DateTime", (message) => new string[] { message.ReceivingTime.ToString(), message.User, message.Notification, message.Text } },
            { "End with DateTime", (message) => new string[] { message.User, message.Notification, message.Text, message.ReceivingTime.ToString() } },
            { "Uppercase", (message) => new string[] { message.ReceivingTime.ToString(), message.User, message.Notification, message.Text.ToUpper() } },
            { "Lowercase", (message) => new string[] { message.User, message.Notification, message.Text.ToLower(), message.ReceivingTime.ToString() } }
        };
    }
}
