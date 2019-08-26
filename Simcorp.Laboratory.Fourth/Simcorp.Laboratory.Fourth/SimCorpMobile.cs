using System;
using System.Collections.Generic;
using System.Text;
using Simcorp.Laboratory.Fourth.MobileChargers;
using Simcorp.Laboratory.Fourth.MobileFeatures;
using Simcorp.Laboratory.Fourth.MobileSpeakers;

namespace Simcorp.Laboratory.Fourth {
    internal class SimCorpMobile {
        private SMSProvider SMSProvider;

        public Screen Screen { get; }

        private Battery Battery { get; }

        private Camera Camera { get; }

        private Speaker Speaker { get; }

        public MessageStorage MessageStorage { get; }

        private ICharger ChargerComponent { get; set; }

        private IPlayback PlaybackComponent { get; set; }

        public Action<List<Message>> MessageAddedDelegate { private get; set; }

        public SimCorpMobile(Screen screen, Battery battery, Camera camera, Speaker speaker) {
            SMSProvider = new SMSProvider();

            Screen = screen;
            Battery = battery;
            Camera = camera;
            Speaker = speaker;
            MessageStorage = new MessageStorage(SMSProvider);

            AttachHandlers();
        }

        private void AttachHandlers() {
            SMSProvider.MessageAdded -= OnMessageAdded;
            SMSProvider.MessageAdded += OnMessageAdded;
        }

        private void DettachHandlers() {
            SMSProvider.MessageAdded -= OnMessageAdded;
        }

        private void OnMessageAdded(List<Message> messages) {
            MessageAddedDelegate?.Invoke(messages);
        }

        public override string ToString() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Battery type: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Camera type: {Camera.ToString()}");
            descriptionBuilder.AppendLine($"Speaker description: {Speaker.ToString()}");
            return descriptionBuilder.ToString();
        }

        public void Charge() {
            ChargerComponent.Charge();
        }

        public void Play(object data) {
            PlaybackComponent.Play(data);
        }
    }
}
