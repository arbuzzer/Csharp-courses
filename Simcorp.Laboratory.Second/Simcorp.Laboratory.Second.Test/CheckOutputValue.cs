using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Simcorp.Laboratory.Second.Test
{
    public class TestableOutput : IOutput
    {
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
    public class CheckOutputValue
    {
        [TestMethod]
        public void CheckInputAndOutputiPhoneHeadsetValue() {
            var output = new TestableOutput();
            iPhoneHeadset iphoneHeadset = new iPhoneHeadset(output);

            string inputValue = $"Madonna Song";
            iphoneHeadset.Play(inputValue);

            string outputValue = output.WritenLineText;
            string expectedValue = $"{nameof(iPhoneHeadset)} soud {inputValue}";

            Assert.AreEqual(expectedValue, outputValue);
        }
        [TestMethod]
        public void CheckInputAndOutputSamsungHeadsetValue() {
            var output = new TestableOutput();
            SamsungHeadset samsungHeadset = new SamsungHeadset(output);

            string inputValue = $"{nameof(SamsungHeadset)} sound";
            samsungHeadset.Play(inputValue);

            string outputValue = output.WritenLineText;
            string expectedValue = $"{nameof(SamsungHeadset)} sound {inputValue}";

            Assert.AreEqual(expectedValue, outputValue);
        }
        [TestMethod]
        public void CheckInputAndOutputUnofficialHeadsetValue() {
            var output = new TestableOutput();
            UnofficialiPhoneHeadset unofficialiPhoneHeadset = new UnofficialiPhoneHeadset(output);

            string inputValue = $"{nameof(UnofficialiPhoneHeadset)} sound";
            unofficialiPhoneHeadset.Play(inputValue);

            string outputValue = output.WritenLineText;
            string expectedValue = $"{nameof(UnofficialiPhoneHeadset)} sound {inputValue}";

            Assert.AreEqual(expectedValue, outputValue);
        }
        [TestMethod]
        public void CheckInputAndOutputPhoneSpeakerValue() {
            var output = new TestableOutput();
            PhoneSpeaker phoneSpeaker = new PhoneSpeaker(output);

            string inputValue = $"{nameof(PhoneSpeaker)} sound";
            phoneSpeaker.Play(inputValue);

            string outputValue = output.WritenLineText;
            string expectedValue = $"{nameof(PhoneSpeaker)} sound {inputValue}";

            Assert.AreEqual(expectedValue, outputValue);
        }
    }
}
