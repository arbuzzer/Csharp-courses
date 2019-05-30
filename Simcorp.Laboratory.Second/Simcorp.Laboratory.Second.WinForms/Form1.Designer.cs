namespace Simcorp.Laboratory.Second.WinForms
{
    partial class Form1
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
            this.ChooseChargerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChargeTextBox = new System.Windows.Forms.TextBox();
            this.WirelessRadioButton = new System.Windows.Forms.RadioButton();
            this.LightningRadioButton = new System.Windows.Forms.RadioButton();
            this.UsbTypeCRadioButton = new System.Windows.Forms.RadioButton();
            this.MicroUsbRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ChooseChargerButton
            // 
            this.ChooseChargerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseChargerButton.Location = new System.Drawing.Point(72, 275);
            this.ChooseChargerButton.Name = "ChooseChargerButton";
            this.ChooseChargerButton.Size = new System.Drawing.Size(124, 32);
            this.ChooseChargerButton.TabIndex = 0;
            this.ChooseChargerButton.Text = "Apply";
            this.ChooseChargerButton.UseVisualStyleBackColor = true;
            this.ChooseChargerButton.Click += new System.EventHandler(this.ChooseChargerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select charger component:";
            // 
            // ChargeTextBox
            // 
            this.ChargeTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChargeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargeTextBox.Location = new System.Drawing.Point(264, 12);
            this.ChargeTextBox.Multiline = true;
            this.ChargeTextBox.Name = "ChargeTextBox";
            this.ChargeTextBox.ReadOnly = true;
            this.ChargeTextBox.Size = new System.Drawing.Size(300, 311);
            this.ChargeTextBox.TabIndex = 6;
            // 
            // WirelessRadioButton
            // 
            this.WirelessRadioButton.AutoSize = true;
            this.WirelessRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WirelessRadioButton.Location = new System.Drawing.Point(35, 220);
            this.WirelessRadioButton.Name = "WirelessRadioButton";
            this.WirelessRadioButton.Size = new System.Drawing.Size(145, 24);
            this.WirelessRadioButton.TabIndex = 5;
            this.WirelessRadioButton.TabStop = true;
            this.WirelessRadioButton.Tag = typeof(Simcorp.Laboratory.Second.WinForms.WirelessCharger);
            this.WirelessRadioButton.Text = "Wireless charger";
            this.WirelessRadioButton.UseVisualStyleBackColor = true;
            this.WirelessRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // LightningRadioButton
            // 
            this.LightningRadioButton.AutoSize = true;
            this.LightningRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightningRadioButton.Location = new System.Drawing.Point(35, 180);
            this.LightningRadioButton.Name = "LightningRadioButton";
            this.LightningRadioButton.Size = new System.Drawing.Size(150, 24);
            this.LightningRadioButton.TabIndex = 4;
            this.LightningRadioButton.TabStop = true;
            this.LightningRadioButton.Tag = typeof(Simcorp.Laboratory.Second.WinForms.LightningCharger);
            this.LightningRadioButton.Text = "Lightning charger";
            this.LightningRadioButton.UseVisualStyleBackColor = true;
            this.LightningRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // UsbTypeCRadioButton
            // 
            this.UsbTypeCRadioButton.AutoSize = true;
            this.UsbTypeCRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsbTypeCRadioButton.Location = new System.Drawing.Point(35, 140);
            this.UsbTypeCRadioButton.Name = "UsbTypeCRadioButton";
            this.UsbTypeCRadioButton.Size = new System.Drawing.Size(173, 24);
            this.UsbTypeCRadioButton.TabIndex = 3;
            this.UsbTypeCRadioButton.TabStop = true;
            this.UsbTypeCRadioButton.Tag = typeof(Simcorp.Laboratory.Second.WinForms.UsbTypeCCharger);
            this.UsbTypeCRadioButton.Text = "USB Type-C charger";
            this.UsbTypeCRadioButton.UseVisualStyleBackColor = true;
            this.UsbTypeCRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // MicroUsbRadioButton
            // 
            this.MicroUsbRadioButton.AutoSize = true;
            this.MicroUsbRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MicroUsbRadioButton.Location = new System.Drawing.Point(35, 100);
            this.MicroUsbRadioButton.Name = "MicroUsbRadioButton";
            this.MicroUsbRadioButton.Size = new System.Drawing.Size(161, 24);
            this.MicroUsbRadioButton.TabIndex = 2;
            this.MicroUsbRadioButton.TabStop = true;
            this.MicroUsbRadioButton.Tag = typeof(Simcorp.Laboratory.Second.WinForms.MicroUsbCharger);
            this.MicroUsbRadioButton.Text = "Micro USB charger";
            this.MicroUsbRadioButton.UseVisualStyleBackColor = true;
            this.MicroUsbRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 335);
            this.Controls.Add(this.ChargeTextBox);
            this.Controls.Add(this.WirelessRadioButton);
            this.Controls.Add(this.LightningRadioButton);
            this.Controls.Add(this.UsbTypeCRadioButton);
            this.Controls.Add(this.MicroUsbRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseChargerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose charger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseChargerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton MicroUsbRadioButton;
        private System.Windows.Forms.RadioButton UsbTypeCRadioButton;
        private System.Windows.Forms.RadioButton LightningRadioButton;
        private System.Windows.Forms.RadioButton WirelessRadioButton;
        private System.Windows.Forms.TextBox ChargeTextBox;
    }
}

