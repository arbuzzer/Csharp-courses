using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace Simcorp.Laboratory.Third.Test {
    [TestClass]
    public class CheckFormattingBehaviorAndEventRaised {
        public Func<string, string> TextFormatter;

        [TestMethod]
        public void CheckThatEventIsRaisedWhenNewMessageIsGenerated() {

        }

        [TestMethod]
        public void CheckFormattingBehaviorNotEqual() {
            string message = "You have a new message!";

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
