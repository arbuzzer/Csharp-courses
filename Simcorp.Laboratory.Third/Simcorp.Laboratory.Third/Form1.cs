using System;
using System.Threading;
using System.Windows.Forms;
using Simcorp.Laboratory.Third.MobileFeatures;

namespace Simcorp.Laboratory.Third
{
    public partial class Form1 : Form
    {
        private delegate string FormatDelegate(string text);

        private Func<string, string> TextFormatter;

        public Form1() {
            InitializeComponent();
            MessageComboBox.SelectedItem = "None";
        }

        private void Form1_Load(object sender, EventArgs e) {
            SimcorpMobile simcorpMobile = new SimcorpMobile(new MultiTouchScreen(), new LithiumIon(), new SingleModule(), new Stereo(), new SMSProvider());
            simcorpMobile.SMSReceivedDelegate = OnSMSReceived;
            MessageComboBox.SelectionChangeCommitted += OnSelected;
        }

        private void OnSelected(object sender, EventArgs e) {
            switch (MessageComboBox.SelectedItem) {
                case "Start with DateTime":
                TextFormatter = (message) => $"[{DateTime.Now}] {message}{Environment.NewLine}";
                break;
                case "End with DateTime":
                TextFormatter = (message) => $"{message} [{DateTime.Now}]{Environment.NewLine}";
                break;
                case "Uppercase":
                TextFormatter = (message) => $"[{DateTime.Now}] {message.ToUpper()}{Environment.NewLine}";
                break;
                case "Lowercase":
                TextFormatter = (message) => $"[{DateTime.Now}] {message.ToLower()}{Environment.NewLine}";
                break;
            }
        }

        private void OnSMSReceived(string message) {
            if (InvokeRequired) {
                Invoke(new SMSProvider.SMSProviderDelegate(OnSMSReceived), message);
                return;
            }

            if (TextFormatter == null) { return; }

            MessageRichTextBox.AppendText(TextFormatter(message));
        }
    }
}
