using System;
using System.Threading;
using System.Windows.Forms;

namespace Simcorp.Laboratory.Third
{
    public partial class Form1 : Form
    {
        private delegate string FormatDelegate(string text);

        public Form1() {
            InitializeComponent();
            MessageComboBox.SelectedItem = "Start with DateTime";
        }

        private void Form1_Load(object sender, EventArgs e) {
            SMSProvider SMSProvider = new SMSProvider();

            SMSProvider.SMSReceived += OnSMSReceived;

            int number = 1;
            var autoEvent = new AutoResetEvent(false);
            var startMessage = new System.Threading.Timer(state => SMSProvider.RaiseSMSReceivedEvent($"Message #{number++} Received!"),
                                   autoEvent, 0, 1500);
        }

        private static string FormatStartWithTime(string message) {
            return $"[{DateTime.Now}] {message}";
        }
        private static string FormatEndWithTime(string message) {
            return $"{message}";
        }

        private readonly FormatDelegate FormatterStart = new FormatDelegate(FormatStartWithTime);
        private readonly FormatDelegate FormatterEnd = new FormatDelegate(FormatEndWithTime);

        private void OnSMSReceived(string message) {
            if (InvokeRequired) {
                Invoke(new SMSProvider.SMSProviderDelegate(OnSMSReceived), message);
                return;
            }

            switch (MessageComboBox.SelectedItem) {
                case "Start with DateTime":
                    string formattedStartMessage = FormatterStart($"{message}{Environment.NewLine}");
                    MessageRichTextBox.AppendText(formattedStartMessage);
                    break;
                case "End with DateTime":
                    string formattedEndMessage = FormatterEnd($"{message} [{DateTime.Now}]{Environment.NewLine}");
                    MessageRichTextBox.AppendText(formattedEndMessage);
                    break;
                case "Uppercase":
                    string formattedUpperMessage = FormatterStart($"{message.ToUpper()}{Environment.NewLine}");
                    MessageRichTextBox.AppendText(formattedUpperMessage);
                    break;
                case "Lowercase":
                    string formattedLowerMessage = FormatterStart($"{message.ToLower()}{Environment.NewLine}");
                    MessageRichTextBox.AppendText(formattedLowerMessage);
                    break;
            }
        }
    }
}
