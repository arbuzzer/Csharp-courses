using System;

namespace Simcorp.Laboratory.Third
{
    public class SMSProvider
    {
        public delegate void SMSProviderDelegate(string message);
        public event SMSProviderDelegate SMSReceived;

        public void RaiseSMSReceivedEvent(string message) {
            SMSReceived?.Invoke(message);
        }
    }
}
