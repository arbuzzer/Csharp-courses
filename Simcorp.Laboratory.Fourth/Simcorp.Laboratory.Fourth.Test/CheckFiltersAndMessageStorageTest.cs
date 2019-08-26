using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading;

namespace Simcorp.Laboratory.Fourth.Test {
    [TestClass]
    public class CheckFiltersAndMessageStorageTest {
        [TestMethod]
        public void VerifyingThatMessagesAreBeingAddedToStorageAndCleanStorage() {
            SMSProvider SMSProvider = new SMSProvider();
            MessageStorage storage = new MessageStorage(SMSProvider);

            Thread.Sleep(2000);

            int expected = SMSProvider.Messages.Count;
            int actual = storage.Messages.Count;

            Assert.AreEqual(expected, actual);

            //Cleaning message storage
            storage.ReadMessage();
            actual = storage.Messages.Count;
            Assert.AreEqual(0, actual);
        }


        [TestMethod]
        public void VerifyingMessageFilters() {
            
        }
    }
}
