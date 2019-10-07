using System.Threading;

namespace Simcorp.Laboratory {
    internal class ThreadSMSProvider : SMSProvider {
        public ThreadSMSProvider() {
            StartMessageThread();
        }

        private void StartMessageThread() {
            var messageThread = new Thread(StartTimer);
            messageThread.Start();
        }
    }
}
