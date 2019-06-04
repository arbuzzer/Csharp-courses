using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simcorp.Laboratory.Library;

namespace Simcorp.Laboratory.Second.WinForms
{
    public class WinFormsOutput : IOutput
    {
        private TextBox TextBox;
        public WinFormsOutput(TextBox textBox) {
            TextBox = textBox;
        }
        public void WriteLine(string text) {
            TextBox.Text += "Set charger to Mobile...\r\n" +
                "Start charging the Mobile:\r\n" + 
                text;
        }
    }
}
