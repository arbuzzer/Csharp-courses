using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Simcorp.Laboratory.Test {
    [TestClass]
    public class CheckFormattingBehaviorAndEventRaised {
        public Func<Message, string[]> TextFormatter;

        [TestMethod]
        public void CheckThatEventIsRaisedWhenNewMessageIsGenerated() {
            
        }

        [TestMethod]
        public void CheckFormattingBehaviorNotEqual() {
            var message = new Message("+380974215339",
                "You have a new message",
                "Goode morning:) How are you?",
                DateTime.Now);

            TextFormatter = MessageFormat.FormatOfMessage["Start with DateTime"];
            var actual = TextFormatter(message);
            Assert.AreNotEqual(message, actual);

            TextFormatter = MessageFormat.FormatOfMessage["End with DateTime"];
            actual = TextFormatter(message);
            Assert.AreNotEqual(message, actual);

            TextFormatter = MessageFormat.FormatOfMessage["Uppercase"];
            actual = TextFormatter(message);
            Assert.AreNotEqual(message, actual);

            TextFormatter = MessageFormat.FormatOfMessage["Lowercase"];
            actual = TextFormatter(message);
            Assert.AreNotEqual(message, actual);

            TextFormatter = MessageFormat.FormatOfMessage["None"];
            actual = TextFormatter(message);
            Assert.AreNotEqual(message, actual);
        }
    }
}
