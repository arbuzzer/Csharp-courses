using System.Collections.Generic;

namespace Simcorp.Laboratory.Fourth {
    internal class MessageStorage {
        private SMSProvider SMSProvider;

        public readonly List<Message> Messages = new List<Message>();

        public MessageStorage(SMSProvider sMSProvider) {
            SMSProvider = sMSProvider;
            AttachHandlers();
        }

        private void AttachHandlers() {
            SMSProvider.MessageAdded -= OnAdded;
            SMSProvider.MessageAdded += OnAdded;
        }

        private void DettachHandlers() {
            SMSProvider.MessageAdded -= OnAdded;
        }

        public void OnAdded(List<Message> messages) {
            Messages.AddRange(messages);
        }

        public List<Message> ReadMessage() {
            try {
                return Messages;
            } finally {
                Messages.Clear();
            }
        }
    }
}
