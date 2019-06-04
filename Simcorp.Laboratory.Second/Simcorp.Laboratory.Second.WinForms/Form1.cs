using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simcorp.Laboratory.Library;

namespace Simcorp.Laboratory.Second.WinForms
{
    public partial class Form1 : Form
    {
        private ICharger Charger;
        private IOutput vOutput;
        public IOutput Output
        {
            get
            {
                if (vOutput == null) {
                    vOutput = new WinFormsOutput(ChargeTextBox);
                }
                return vOutput;
            }
        }

        public Form1() {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e) {
            Type typeOfCharger = (Type)((Control)sender).Tag;
            Charger = (ICharger)Activator.CreateInstance(typeOfCharger, Output);
            //ChargeTextBox.Text = $"{typeOfCharger.Name} selected";
        }

        private void ChooseChargerButton_Click(object sender, EventArgs e) {
            if(Charger == null)
            {
                MessageBox.Show("Please choose one of the option", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                ChargeTextBox.Text = $"{Charger.GetType().Name} selected\r\n";
                Charger.Charge();
            }
        }
    }
}
