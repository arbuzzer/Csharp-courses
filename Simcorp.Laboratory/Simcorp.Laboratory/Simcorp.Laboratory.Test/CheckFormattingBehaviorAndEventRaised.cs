using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Simcorp.Laboratory.Test {
    public class TestingMessage {
        public Message GetTestingMessage() {
            return new Message("+380974215339",
                "You have a new message",
                "Goode morning:) How are you?",
                DateTime.Now);
        }
    }

    [TestClass]
    public class CheckFormattingBehaviorAndEventRaised {
        public Func<Message, string[]> TextFormatter;
        private readonly TestingMessage TestingMessage = new TestingMessage();

        [TestMethod]
        public void CheckStartWithDateTimeFormattingBehaviorNotEqual() {
            TextFormatter = MessageFormat.FormatOfMessage["Start with DateTime"];
            var message = TestingMessage.GetTestingMessage();
            var actual = TextFormatter(TestingMessage.GetTestingMessage());
            Assert.AreNotEqual(TestingMessage.GetTestingMessage(), actual);
        }

        [TestMethod]
        public void CheckEndWithDateTimeFormattingBehaviorNotEqual() {
            TextFormatter = MessageFormat.FormatOfMessage["End with DateTime"];
            var message = TestingMessage.GetTestingMessage();
            var actual = TextFormatter(TestingMessage.GetTestingMessage());
            Assert.AreNotEqual(message, actual);
        }

        [TestMethod]
        public void CheckUppercaseFormattingBehaviorNotEqual() {
            TextFormatter = MessageFormat.FormatOfMessage["Uppercase"];
            var message = TestingMessage.GetTestingMessage();
            var actual = TextFormatter(TestingMessage.GetTestingMessage());
            Assert.AreNotEqual(TestingMessage.GetTestingMessage(), actual);
        }

        [TestMethod]
        public void CheckLowercaseFormattingBehaviorNotEqual() {
            TextFormatter = MessageFormat.FormatOfMessage["Lowercase"];
            var message = TestingMessage.GetTestingMessage();
            var actual = TextFormatter(TestingMessage.GetTestingMessage());
            Assert.AreNotEqual(TestingMessage.GetTestingMessage(), actual);
        }
    }
}
