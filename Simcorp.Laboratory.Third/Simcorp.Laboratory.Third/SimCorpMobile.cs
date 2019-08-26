using System;
using System.Text;
using Simcorp.Laboratory.Third.MobileChargers;
using Simcorp.Laboratory.Third.MobileFeatures;
using Simcorp.Laboratory.Third.MobileSpeakers;

namespace Simcorp.Laboratory.Third {
    internal class SimCorpMobile {
        public Screen Screen { get; }

        private Battery Battery { get; }

        private Camera Camera { get; }

        private Speaker Speaker { get; }

        private SMSProvider SMSProvider { get; }

        public ICharger ChargerComponent { get; set; }

        private IPlayback PlaybackComponent { get; set; }
 
        public Action<string> SMSReceivedDelegate { get; internal set; }

        public SimCorpMobile(Screen screen, Battery battery, Camera camera, Speaker speaker, SMSProvider smsProvider) {
            Screen = screen;
            Battery = battery;
            Camera = camera;
            Speaker = speaker;
            SMSProvider = smsProvider;

            AttachHandlers();
        }

        private void AttachHandlers() {
            SMSProvider.SMSReceived -= OnSMSReceived;
            SMSProvider.SMSReceived += OnSMSReceived;
        }

        private void DettachHandlers() {
            SMSProvider.SMSReceived -= OnSMSReceived;
        }

        private void OnSMSReceived(string message) {
            SMSReceivedDelegate?.Invoke(message);
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
            if (ChargerComponent == null) { return; }
            ChargerComponent?.Charge();
        }

        public void Play(object data) {
            PlaybackComponent.Play(data);
        }
    }
}
