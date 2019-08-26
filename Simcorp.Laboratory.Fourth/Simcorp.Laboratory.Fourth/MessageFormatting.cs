using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Simcorp.Laboratory.Fourth.MobileFeatures;

namespace Simcorp.Laboratory.Fourth {
    public partial class MessageFormatting : Form {
        private SimCorpMobile SimCorpMobile;
        private Func<Message, string[]> TextFormatter;
        private string UserFilterName;
        private int indexSearch = 0;

        public MessageFormatting() {
            InitializeComponent();
            DateTimePickerTo.Value = DateTime.Now;
            DateTimePickerTo.MaxDate = DateTime.Today;
            DateTimePickerFrom.MaxDate = DateTime.Today;
        }

        private void MessageFormatting_Load(object sender, EventArgs e) {
            SimCorpMobile = new SimCorpMobile(new MultiTouchScreen(), new LithiumIon(), new SingleModule(), new Stereo());
            AttachHandlers();
        }

        private void AttachHandlers() {
            SimCorpMobile.MessageAddedDelegate = OnMessageAdded;

            MessageComboBox.SelectionChangeCommitted -= OnSelected;
            MessageComboBox.SelectionChangeCommitted += OnSelected;
            SubscribersComboBox.SelectedIndexChanged -= OnUserChanged;
            SubscribersComboBox.SelectedIndexChanged += OnUserChanged;
        }

        private void DettachHandlers() {
            SimCorpMobile.MessageAddedDelegate = null;

            MessageComboBox.SelectionChangeCommitted -= OnSelected;
            SubscribersComboBox.SelectedIndexChanged -= OnUserChanged;
        }

        private void OnUserChanged(object sender, EventArgs e) {
            UserFilterName = SubscribersComboBox.SelectedItem.ToString();
        }

        private void SubscribersComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            MessageComboBox.Enabled = true;
        }

        private void OnSelected(object sender, EventArgs e) {
            TextFormatter = Program.FormatOfMessage[MessageComboBox.SelectedItem.ToString()];
        }

        private void OnMessageAdded(List<Message> messages) {
            if (TextFormatter == null) { return; }

            if (InvokeRequired) {
                Invoke(new SMSProvider.MessageStorageDelegate(OnMessageAdded), messages);
                return;
            }

            foreach (Message message in messages) {
                if (UserFilterName == message.User &&
                    DateTimePickerTo.Value.Date == DateTime.Today) {
                    MessageListView.Items.Add(new ListViewItem(TextFormatter(message)));
                }
            }
        }

        private void DateTimePickerTo_ValueChanged(object sender, EventArgs e) {
            if (DateTimePickerTo.Value.Date != DateTime.Today) {
                MessageListView.Items.Clear();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e) {
            if (SearchTextBox.Text == string.Empty) {
                MessageBox.Show("You have empty search line. Write what you want find.");
            } else {
                ListViewItem foundItem = MessageListView.FindItemWithText(SearchTextBox.Text, true, indexSearch, true);
                if (foundItem != null) {
                    foundItem.ForeColor = Color.Red;
                    indexSearch = foundItem.Index + 1;
                    if (indexSearch > MessageListView.Items.Count) {
                        MessageBox.Show("No more items found");
                    }
                } else {
                    MessageListView.Items.Clear();
                    indexSearch = 0;
                }
            }
        }

        private void FiltrationCheckBox_CheckedChanged(object sender, EventArgs e) {
            FilterGroupBox.Enabled = FiltrationCheckBox.Checked;
            if (!FiltrationCheckBox.Checked) {
                MessageListView.ForeColor = DefaultForeColor;
            }
        }
    }
}
