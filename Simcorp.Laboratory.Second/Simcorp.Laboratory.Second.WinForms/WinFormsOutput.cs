using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simcorp.Laboratory.Second.WinForms
{
    public class WinFormsOutput : IOutput
    {
        private TextBox TextBox;
        public WinFormsOutput(TextBox textBox) {
            TextBox = textBox;
        }
        public void Write(string text) {
            TextBox.Text = text;
        }
    }
}
