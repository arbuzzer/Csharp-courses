using System;
using System.Linq;
using System.Windows.Forms;
using Simcorp.Laboratory.Third.MobileFeatures;

namespace Simcorp.Laboratory.Third {
    internal partial class Form1 : Form {
        private SimCorpMobile SimCorpMobile;
        private Func<string, string> TextFormatter;

        public Form1() {
            InitializeComponent();
            MessageComboBox.DataSource = Program.FormatOfMessage.Keys.ToList();
        }

        private void Form1_Load(object sender, EventArgs e) {
            SimCorpMobile = new SimCorpMobile(new MultiTouchScreen(), new LithiumIon(), new SingleModule(), new Stereo(), new SMSProvider());
            AttachHandlers();
        }

        private void AttachHandlers() {
            SimCorpMobile.SMSReceivedDelegate = OnSMSReceived;

            MessageComboBox.SelectionChangeCommitted -= OnSelected;
            MessageComboBox.SelectionChangeCommitted += OnSelected;
        }

        private void DettachHadlers() {
            SimCorpMobile.SMSReceivedDelegate = null;

            MessageComboBox.SelectionChangeCommitted -= OnSelected;
        }

        private void OnSelected(object sender, EventArgs e) {
            TextFormatter = Program.FormatOfMessage[MessageComboBox.SelectedItem.ToString()];
        }

        private void OnSMSReceived(string message) {
            if (InvokeRequired)
            {
                Invoke(new SMSProvider.SMSProviderDelegate(OnSMSReceived), message);
                return;
            }

            if (TextFormatter == null) { return; }

            MessageRichTextBox.AppendText(TextFormatter(message));
        }
    }
}
