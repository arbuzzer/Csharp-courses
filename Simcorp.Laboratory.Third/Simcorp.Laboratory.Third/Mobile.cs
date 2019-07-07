using System;
using System.Text;
using Simcorp.Laboratory.Third.MobileChargers;
using Simcorp.Laboratory.Third.MobileFeatures;
using Simcorp.Laboratory.Third.MobileSpeakers;

namespace Simcorp.Laboratory.Third
{
    public abstract class Mobile
    {
        public Screen Screen { get; }

        public Battery Battery { get; }

        public Camera Camera { get; }

        public Speaker Speaker { get; }

        public SMSProvider SMSProvider { get; }

        public ICharger ChargerComponent { get; set; }

        public IPlayback PlaybackComponent { get; set; }
 
        public Action<string> SMSReceivedDelegate { get; internal set; }

        public Mobile(Screen screen, Battery battery, Camera camera, Speaker speaker, SMSProvider smsProvider) {
            Screen = screen;
            Battery = battery;
            Camera = camera;
            Speaker = speaker;
            SMSProvider = smsProvider;

            SMSProvider.SMSReceived += OnSMSReceived;
        }

        private void OnSMSReceived(string message) {
            if (SMSReceivedDelegate == null) { return; }
            SMSReceivedDelegate(message);
        }

        public string ToString() {
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
