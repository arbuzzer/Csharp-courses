using System;
using System.Collections.Generic;
using System.Text;
using Simcorp.Laboratory.MobileChargers;
using Simcorp.Laboratory.MobileFeatures;
using Simcorp.Laboratory.MobileSpeakers;

namespace Simcorp.Laboratory {
    internal class SimCorpMobile {
        private SMSProvider SMSProvider;

        public Screen Screen { get; }

        public Battery Battery { get; }

        private Camera Camera { get; }

        private Speaker Speaker { get; }

        public MessageStorage MessageStorage { get; }

        private ICharger ChargerComponent { get; set; }

        private IPlayback PlaybackComponent { get; set; }

        public Action<List<Message>> MessageAddedDelegate { private get; set; }

        public Action<int> BatteryChargedDelegate { private get; set; }

        public SimCorpMobile(Screen screen, Battery battery, Camera camera, Speaker speaker) {
            SMSProvider = new ThreadSMSProvider();

            Screen = screen;
            Battery = battery;
            Camera = camera;
            Speaker = speaker;
            MessageStorage = new MessageStorage(SMSProvider);

            AttachHandlers();
        }

        private void AttachHandlers() {
            DetachHandlers();
            SMSProvider.MessageAdded += OnMessageAdded;
            Battery.BatteryCharged += OnBatteryCharged;
        }

        private void DetachHandlers() {
            SMSProvider.MessageAdded -= OnMessageAdded;
            Battery.BatteryCharged -= OnBatteryCharged;
        }

        private void OnMessageAdded(List<Message> messages) {
            MessageAddedDelegate?.Invoke(messages);
        }

        private void OnBatteryCharged(int percentage) {
            BatteryChargedDelegate?.Invoke(percentage);
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
