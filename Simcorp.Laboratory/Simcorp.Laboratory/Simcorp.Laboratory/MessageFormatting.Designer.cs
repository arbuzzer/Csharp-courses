namespace Simcorp.Laboratory
{
    partial class MessageFormatting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MessageListView = new System.Windows.Forms.ListView();
            this.firstMessageColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secondMessageColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thirdMessageColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fourthMessageColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FiltrationCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MessageFormatLabel = new System.Windows.Forms.Label();
            this.SubscribersComboBox = new System.Windows.Forms.ComboBox();
            this.MessageComboBox = new System.Windows.Forms.ComboBox();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.StartThread = new System.Windows.Forms.Button();
            this.StopThread = new System.Windows.Forms.Button();
            this.ChargingProgressBar = new System.Windows.Forms.ProgressBar();
            this.StartCharging = new System.Windows.Forms.Button();
            this.StopCharging = new System.Windows.Forms.Button();
            this.FilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageListView
            // 
            this.MessageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstMessageColumn,
            this.secondMessageColumn,
            this.thirdMessageColumn,
            this.fourthMessageColumn});
            this.MessageListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageListView.HideSelection = false;
            this.MessageListView.Location = new System.Drawing.Point(12, 338);
            this.MessageListView.Name = "MessageListView";
            this.MessageListView.Size = new System.Drawing.Size(431, 359);
            this.MessageListView.TabIndex = 0;
            this.MessageListView.TileSize = new System.Drawing.Size(350, 90);
            this.MessageListView.UseCompatibleStateImageBehavior = false;
            this.MessageListView.View = System.Windows.Forms.View.Tile;
            // 
            // FiltrationCheckBox
            // 
            this.FiltrationCheckBox.AutoSize = true;
            this.FiltrationCheckBox.Enabled = false;
            this.FiltrationCheckBox.Location = new System.Drawing.Point(230, 117);
            this.FiltrationCheckBox.Name = "FiltrationCheckBox";
            this.FiltrationCheckBox.Size = new System.Drawing.Size(75, 17);
            this.FiltrationCheckBox.TabIndex = 1;
            this.FiltrationCheckBox.Text = "Add filters";
            this.FiltrationCheckBox.UseVisualStyleBackColor = true;
            this.FiltrationCheckBox.CheckedChanged += new System.EventHandler(this.FiltrationCheckBoxCheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose contact";
            // 
            // MessageFormatLabel
            // 
            this.MessageFormatLabel.AutoSize = true;
            this.MessageFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageFormatLabel.Location = new System.Drawing.Point(9, 184);
            this.MessageFormatLabel.Name = "MessageFormatLabel";
            this.MessageFormatLabel.Size = new System.Drawing.Size(155, 16);
            this.MessageFormatLabel.TabIndex = 3;
            this.MessageFormatLabel.Text = "Choose message format";
            // 
            // SubscribersComboBox
            // 
            this.SubscribersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubscribersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubscribersComboBox.Items.AddRange(new object[] {
            "+380667243917",
            "+380974108621",
            "+380504620705"});
            this.SubscribersComboBox.Location = new System.Drawing.Point(12, 135);
            this.SubscribersComboBox.Name = "SubscribersComboBox";
            this.SubscribersComboBox.Size = new System.Drawing.Size(157, 28);
            this.SubscribersComboBox.TabIndex = 4;
            this.SubscribersComboBox.SelectedIndexChanged += new System.EventHandler(this.SubscribersComboBoxSelectedIndexChanged);
            // 
            // MessageComboBox
            // 
            this.MessageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MessageComboBox.Enabled = false;
            this.MessageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageComboBox.Items.AddRange(new object[] {
            "Start with DateTime",
            "End with DateTime",
            "Uppercase",
            "Lowercase"});
            this.MessageComboBox.Location = new System.Drawing.Point(12, 203);
            this.MessageComboBox.Name = "MessageComboBox";
            this.MessageComboBox.Size = new System.Drawing.Size(157, 28);
            this.MessageComboBox.TabIndex = 5;
            this.MessageComboBox.SelectedIndexChanged += new System.EventHandler(this.MessageComboBoxSelectedIndexChanged);
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.Controls.Add(this.SearchTextBox);
            this.FilterGroupBox.Controls.Add(this.SearchButton);
            this.FilterGroupBox.Controls.Add(this.DateTimePickerTo);
            this.FilterGroupBox.Controls.Add(this.DateTimePickerFrom);
            this.FilterGroupBox.Enabled = false;
            this.FilterGroupBox.Location = new System.Drawing.Point(230, 150);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(213, 100);
            this.FilterGroupBox.TabIndex = 6;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Filters";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(63, 72);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(143, 20);
            this.SearchTextBox.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(6, 72);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(50, 20);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // DateTimePickerTo
            // 
            this.DateTimePickerTo.Location = new System.Drawing.Point(6, 45);
            this.DateTimePickerTo.Name = "DateTimePickerTo";
            this.DateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerTo.TabIndex = 1;
            this.DateTimePickerTo.ValueChanged += new System.EventHandler(this.DateTimePickerToValueChanged);
            // 
            // DateTimePickerFrom
            // 
            this.DateTimePickerFrom.Location = new System.Drawing.Point(6, 19);
            this.DateTimePickerFrom.Name = "DateTimePickerFrom";
            this.DateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerFrom.TabIndex = 0;
            // 
            // StartThread
            // 
            this.StartThread.Enabled = false;
            this.StartThread.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartThread.Location = new System.Drawing.Point(11, 279);
            this.StartThread.Name = "StartThread";
            this.StartThread.Size = new System.Drawing.Size(125, 30);
            this.StartThread.TabIndex = 7;
            this.StartThread.Text = "Start thread";
            this.StartThread.UseVisualStyleBackColor = true;
            this.StartThread.Click += new System.EventHandler(this.StartThreadClick);
            // 
            // StopThread
            // 
            this.StopThread.Enabled = false;
            this.StopThread.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopThread.Location = new System.Drawing.Point(179, 279);
            this.StopThread.Name = "StopThread";
            this.StopThread.Size = new System.Drawing.Size(125, 30);
            this.StopThread.TabIndex = 8;
            this.StopThread.Text = "Stop thread";
            this.StopThread.UseVisualStyleBackColor = true;
            this.StopThread.Click += new System.EventHandler(this.StopThreadClick);
            // 
            // ChargingProgressBar
            // 
            this.ChargingProgressBar.ForeColor = System.Drawing.Color.Green;
            this.ChargingProgressBar.Location = new System.Drawing.Point(11, 12);
            this.ChargingProgressBar.Name = "ChargingProgressBar";
            this.ChargingProgressBar.Size = new System.Drawing.Size(432, 40);
            this.ChargingProgressBar.TabIndex = 9;
            // 
            // StartCharging
            // 
            this.StartCharging.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartCharging.Location = new System.Drawing.Point(11, 68);
            this.StartCharging.Name = "StartCharging";
            this.StartCharging.Size = new System.Drawing.Size(125, 30);
            this.StartCharging.TabIndex = 10;
            this.StartCharging.Text = "Start charging";
            this.StartCharging.UseVisualStyleBackColor = true;
            this.StartCharging.Click += new System.EventHandler(this.StartChargingButtonClick);
            // 
            // StopCharging
            // 
            this.StopCharging.Enabled = false;
            this.StopCharging.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopCharging.Location = new System.Drawing.Point(179, 68);
            this.StopCharging.Name = "StopCharging";
            this.StopCharging.Size = new System.Drawing.Size(125, 30);
            this.StopCharging.TabIndex = 11;
            this.StopCharging.Text = "Stop charging";
            this.StopCharging.UseVisualStyleBackColor = true;
            this.StopCharging.Click += new System.EventHandler(this.StopChargingButtonClick);
            // 
            // MessageFormatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 709);
            this.Controls.Add(this.StopCharging);
            this.Controls.Add(this.StartCharging);
            this.Controls.Add(this.ChargingProgressBar);
            this.Controls.Add(this.StopThread);
            this.Controls.Add(this.StartThread);
            this.Controls.Add(this.FilterGroupBox);
            this.Controls.Add(this.MessageComboBox);
            this.Controls.Add(this.SubscribersComboBox);
            this.Controls.Add(this.MessageFormatLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrationCheckBox);
            this.Controls.Add(this.MessageListView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageFormatting";
            this.Text = "Message Formatting";
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MessageListView;
        private System.Windows.Forms.ColumnHeader firstMessageColumn;
        private System.Windows.Forms.ColumnHeader secondMessageColumn;
        private System.Windows.Forms.ColumnHeader thirdMessageColumn;
        private System.Windows.Forms.ColumnHeader fourthMessageColumn;
        private System.Windows.Forms.CheckBox FiltrationCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MessageFormatLabel;
        private System.Windows.Forms.ComboBox SubscribersComboBox;
        private System.Windows.Forms.ComboBox MessageComboBox;
        private System.Windows.Forms.GroupBox FilterGroupBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DateTimePicker DateTimePickerTo;
        private System.Windows.Forms.DateTimePicker DateTimePickerFrom;
        private System.Windows.Forms.Button StartThread;
        private System.Windows.Forms.Button StopThread;
        private System.Windows.Forms.ProgressBar ChargingProgressBar;
        private System.Windows.Forms.Button StartCharging;
        private System.Windows.Forms.Button StopCharging;
    }
}

