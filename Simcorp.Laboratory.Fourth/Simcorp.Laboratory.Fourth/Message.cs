using System;

namespace Simcorp.Laboratory.Fourth {
    public class Message {
        public string User { get; private set; }

        public string Notification { get; private set; }

        public string Text { get; private set; }

        public DateTime ReceivingTime { get; private set; }

        public Message(string user, string notification, string text, DateTime receivingTime)
        {
            User = user;
            Notification = notification;
            Text = text;
            ReceivingTime = receivingTime;
        }
    }
}
