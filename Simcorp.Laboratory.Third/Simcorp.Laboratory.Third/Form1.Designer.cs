namespace Simcorp.Laboratory.Third
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
            this.MessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MessageComboBox = new System.Windows.Forms.ComboBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // MessageRichTextBox
            // 
            this.MessageRichTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.MessageRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MessageRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageRichTextBox.Location = new System.Drawing.Point(12, 82);
            this.MessageRichTextBox.Name = "MessageRichTextBox";
            this.MessageRichTextBox.ReadOnly = true;
            this.MessageRichTextBox.Size = new System.Drawing.Size(389, 356);
            this.MessageRichTextBox.TabIndex = 0;
            this.MessageRichTextBox.Text = "";
            // 
            // MessageComboBox
            // 
            this.MessageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MessageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageComboBox.Items.AddRange(new object[] {
            "End with DateTime",
            "Lowercase",
            "None",
            "Start with DateTime",
            "Uppercase"});
            this.MessageComboBox.Location = new System.Drawing.Point(12, 26);
            this.MessageComboBox.Name = "MessageComboBox";
            this.MessageComboBox.Size = new System.Drawing.Size(160, 28);
            this.MessageComboBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.MessageComboBox);
            this.Controls.Add(this.MessageRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Message Formatting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessageRichTextBox;
        private System.Windows.Forms.ComboBox MessageComboBox;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FontDialog fontDialog2;
    }
}

