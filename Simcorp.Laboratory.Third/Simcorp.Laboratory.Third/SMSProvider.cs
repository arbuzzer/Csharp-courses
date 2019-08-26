using System.Threading;

namespace Simcorp.Laboratory.Third {
    internal class SMSProvider {
        public delegate void SMSProviderDelegate(string message);

        public event SMSProviderDelegate SMSReceived;

        public int CurrentNumber { get; private set; } = 1;

        public SMSProvider() {
            StartTimer();
        }

        private Timer StartTimer() {
            AutoResetEvent autoEvent = new AutoResetEvent(false);
            var startMessage = new Timer(state => RaiseSMSReceivedEvent($"Message #{CurrentNumber++} Received!"), autoEvent, 0, 1500);
            return startMessage;
        }

        private void RaiseSMSReceivedEvent(string message) {
            SMSReceived?.Invoke(message);
        }
    }
}
