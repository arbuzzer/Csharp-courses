using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading;

namespace Simcorp.Laboratory.Test {
    [TestClass]
    public class CheckFiltersAndMessageStorageTest {
        [TestMethod]
        public void VerifyingThatMessagesAreBeingAddedToStorageAndCleanStorage() {
            var SMSProvider = new ThreadSMSProvider();
            var storage = new MessageStorage(SMSProvider);

            Thread.Sleep(2500);

            int expected = SMSProvider.Messages.Count;
            int actual = storage.Messages.Count;

            Assert.AreEqual(expected, actual);

            //Cleaning message storage
            storage.ReadMessage();
            actual = storage.Messages.Count;
            Assert.AreEqual(0, actual);
        }
    }
}
