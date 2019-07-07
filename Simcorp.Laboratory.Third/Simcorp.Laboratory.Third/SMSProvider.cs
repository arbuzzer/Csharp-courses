using System;
using System.Threading;

namespace Simcorp.Laboratory.Third
{
    public class SMSProvider
    {
        public delegate void SMSProviderDelegate(string message);
        public event SMSProviderDelegate SMSReceived;

        public SMSProvider() {
            int number = 1;
            var autoEvent = new AutoResetEvent(false);
            var startMessage = new Timer(state => RaiseSMSReceivedEvent($"Message #{number++} Received!"), autoEvent, 0, 1500);
        }

        private void RaiseSMSReceivedEvent(string message) {
            SMSReceived?.Invoke(message);
        }
    }
}
