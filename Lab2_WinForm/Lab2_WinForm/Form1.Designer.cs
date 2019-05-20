namespace Lab2_WinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LightningChargerRadioButton = new System.Windows.Forms.RadioButton();
            this.MicroUsbChargerRadioButton = new System.Windows.Forms.RadioButton();
            this.UsbCChargerRadioButton = new System.Windows.Forms.RadioButton();
            this.WirelessChargerRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select charger type:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(200, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LightningChargerRadioButton
            // 
            this.LightningChargerRadioButton.AutoSize = true;
            this.LightningChargerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightningChargerRadioButton.Location = new System.Drawing.Point(16, 45);
            this.LightningChargerRadioButton.Name = "LightningChargerRadioButton";
            this.LightningChargerRadioButton.Size = new System.Drawing.Size(141, 22);
            this.LightningChargerRadioButton.TabIndex = 2;
            this.LightningChargerRadioButton.TabStop = true;
            this.LightningChargerRadioButton.Text = "Lightning Charger";
            this.LightningChargerRadioButton.UseVisualStyleBackColor = true;
            // 
            // MicroUsbChargerRadioButton
            // 
            this.MicroUsbChargerRadioButton.AutoSize = true;
            this.MicroUsbChargerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MicroUsbChargerRadioButton.Location = new System.Drawing.Point(16, 75);
            this.MicroUsbChargerRadioButton.Name = "MicroUsbChargerRadioButton";
            this.MicroUsbChargerRadioButton.Size = new System.Drawing.Size(152, 22);
            this.MicroUsbChargerRadioButton.TabIndex = 3;
            this.MicroUsbChargerRadioButton.TabStop = true;
            this.MicroUsbChargerRadioButton.Text = "MicroUSB Charger";
            this.MicroUsbChargerRadioButton.UseVisualStyleBackColor = true;
            // 
            // UsbCChargerRadioButton
            // 
            this.UsbCChargerRadioButton.AutoSize = true;
            this.UsbCChargerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsbCChargerRadioButton.Location = new System.Drawing.Point(16, 105);
            this.UsbCChargerRadioButton.Name = "UsbCChargerRadioButton";
            this.UsbCChargerRadioButton.Size = new System.Drawing.Size(166, 22);
            this.UsbCChargerRadioButton.TabIndex = 4;
            this.UsbCChargerRadioButton.TabStop = true;
            this.UsbCChargerRadioButton.Text = "USB Type-C Charger";
            this.UsbCChargerRadioButton.UseVisualStyleBackColor = true;
            // 
            // WirelessChargerRadioButton
            // 
            this.WirelessChargerRadioButton.AutoSize = true;
            this.WirelessChargerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WirelessChargerRadioButton.Location = new System.Drawing.Point(16, 135);
            this.WirelessChargerRadioButton.Name = "WirelessChargerRadioButton";
            this.WirelessChargerRadioButton.Size = new System.Drawing.Size(141, 22);
            this.WirelessChargerRadioButton.TabIndex = 5;
            this.WirelessChargerRadioButton.TabStop = true;
            this.WirelessChargerRadioButton.Text = "Wireless Charger";
            this.WirelessChargerRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 215);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(291, 223);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.WirelessChargerRadioButton);
            this.Controls.Add(this.UsbCChargerRadioButton);
            this.Controls.Add(this.MicroUsbChargerRadioButton);
            this.Controls.Add(this.LightningChargerRadioButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForms Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton LightningChargerRadioButton;
        private System.Windows.Forms.RadioButton MicroUsbChargerRadioButton;
        private System.Windows.Forms.RadioButton UsbCChargerRadioButton;
        private System.Windows.Forms.RadioButton WirelessChargerRadioButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

