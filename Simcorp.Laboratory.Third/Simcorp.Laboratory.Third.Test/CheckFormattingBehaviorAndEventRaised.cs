using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Simcorp.Laboratory.Third.Test
{
    [TestClass]
    public class CheckFormattingBehaviorAndEventRaised
    {
        [TestMethod]
        public void CheckEventRaisedWhenMessageIsGenerated() {
            SMSProvider SMSProvider = new SMSProvider();
            var wait = new AutoResetEvent(false);
            SMSProvider.SMSReceived += (message) => { wait.Set(); };
            Assert.IsTrue(wait.WaitOne(TimeSpan.FromSeconds(1.5)));
        }
    }
}
