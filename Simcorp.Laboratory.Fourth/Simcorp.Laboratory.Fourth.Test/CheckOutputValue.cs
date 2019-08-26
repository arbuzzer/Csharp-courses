using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.Laboratory.Fourth.MobileSpeakers;

namespace Simcorp.Laboratory.Fourth.Test {
    public class TestableOutput : IOutput {
        public string WritenText { get; set; }
        public string WritenLineText { get; set; }

        public void Write(string text) {
            WritenText = text;
        }

        public void WriteLine(string text) {
            WritenLineText = text;
        }
    }

    [TestClass]
    public class CheckOutputValue {
        [TestMethod]
        public void CheckInputAndOutputiPhoneHeadsetValue() {
            var output = new TestableOutput();
            iPhoneHeadset iphoneHeadset = new iPhoneHeadset(output);

            string inputValue = "Madonna Song";
            iphoneHeadset.Play(inputValue);

            string outputValue = output.WritenLineText;
            string expectedValue = $"{nameof(iPhoneHeadset)} play {inputValue}";

            Assert.AreEqual(expectedValue, outputValue);
        }

        [TestMethod]
        public void CheckInputAndOutputSamsungHeadsetValue() {
            var output = new TestableOutput();
            SamsungHeadset samsungHeadset = new SamsungHeadset(output);

            string inputValue = "Madonna Song";
            samsungHeadset.Play(inputValue);

            string outputValue = output.WritenLineText;
            string expectedValue = $"{nameof(SamsungHeadset)} play {inputValue}";

            Assert.AreEqual(expectedValue, outputValue);
        }

        [TestMethod]
        public void CheckInputAndOutputUnofficialHeadsetValue() {
            var output = new TestableOutput();
            UnofficialiPhoneHeadset unofficialiPhoneHeadset = new UnofficialiPhoneHeadset(output);

            string inputValue = $"Madonna Song";
            unofficialiPhoneHeadset.Play(inputValue);

            string outputValue = output.WritenLineText;
            string expectedValue = $"{nameof(UnofficialiPhoneHeadset)} play {inputValue}";

            Assert.AreEqual(expectedValue, outputValue);
        }

        [TestMethod]
        public void CheckInputAndOutputPhoneSpeakerValue() {
            var output = new TestableOutput();
            PhoneSpeaker phoneSpeaker = new PhoneSpeaker(output);

            string inputValue = "Madonna Song";
            phoneSpeaker.Play(inputValue);

            string outputValue = output.WritenLineText;
            string expectedValue = $"{nameof(PhoneSpeaker)} play {inputValue}";

            Assert.AreEqual(expectedValue, outputValue);
        }
    }
}
