using System.Collections.Generic;

namespace Simcorp.Laboratory {
    internal class MessageStorage {
        private readonly SMSProvider SMSProvider;

        public readonly List<Message> Messages = new List<Message>();

        public MessageStorage(SMSProvider sMSProvider) {
            SMSProvider = sMSProvider;
            AttachHandlers();
        }

        private void AttachHandlers() {
            DetachHandlers();
            SMSProvider.MessageAdded += OnAdded;
        }

        private void DetachHandlers() {
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
