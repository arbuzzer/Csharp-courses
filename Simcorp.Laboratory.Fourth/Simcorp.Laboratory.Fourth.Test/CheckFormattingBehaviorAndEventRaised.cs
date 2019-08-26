using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Simcorp.Laboratory.Fourth.Test {
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

            TextFormatter = Program.FormatOfMessage["Start with DateTime"];
            var actual = TextFormatter(message);
            Assert.AreNotEqual(message, actual);

            TextFormatter = Program.FormatOfMessage["End with DateTime"];
            actual = TextFormatter(message);
            Assert.AreNotEqual(message, actual);

            TextFormatter = Program.FormatOfMessage["Uppercase"];
            actual = TextFormatter(message);
            Assert.AreNotEqual(message, actual);

            TextFormatter = Program.FormatOfMessage["Lowercase"];
            actual = TextFormatter(message);
            Assert.AreNotEqual(message, actual);

            TextFormatter = Program.FormatOfMessage["None"];
            actual = TextFormatter(message);
            Assert.AreNotEqual(message, actual);
        }
    }
}
