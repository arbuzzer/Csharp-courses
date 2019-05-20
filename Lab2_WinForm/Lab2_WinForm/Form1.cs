using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_WinForm
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            LightningCharger lightningCharger = new LightningCharger();
            MicroUsbCharger microUsbCharger = new MicroUsbCharger();
            UsbCCharger usbCCharger = new UsbCCharger();
            WirelessCharger wirelessCharger = new WirelessCharger();

            //List<ICharge> chargers = new List<ICharge> {
            //    { lightningCharger },
            //    { microUsbCharger },
            //    { usbCCharger },
            //    { wirelessCharger },
            //};

            if (LightningChargerRadioButton.Checked == true) {
                textBox1.Text = nameof(LightningCharger) + " charger selected" + "\r\n";
                textBox1.Text += "Set charger to Mobile..." + "\r\n";
                textBox1.Text += "Start charging the Mobile:" + "\r\n";
                textBox1.Text += lightningCharger.Charge();
            }
            else if (MicroUsbChargerRadioButton.Checked == true) {
                textBox1.Text = nameof(MicroUsbCharger) + " charger selected" + "\r\n";
                textBox1.Text += "Set charger to Mobile..." + "\r\n";
                textBox1.Text += "Start charging the Mobile:" + "\r\n";
                textBox1.Text += microUsbCharger.Charge();
            }
            else if (UsbCChargerRadioButton.Checked == true) {
                textBox1.Text = nameof(UsbCCharger) + " charger selected" + "\r\n";
                textBox1.Text += "Set charger to Mobile..." + "\r\n";
                textBox1.Text += "Start charging the Mobile:" + "\r\n";
                textBox1.Text += usbCCharger.Charge();
            }
            else if (WirelessChargerRadioButton.Checked == true) {
                textBox1.Text = nameof(WirelessCharger) + " charger selected" + "\r\n";
                textBox1.Text += "Set charger to Mobile..." + "\r\n";
                textBox1.Text += "Start charging the Mobile:" + "\r\n";
                textBox1.Text += wirelessCharger.Charge();
            }
            else {
                MessageBox.Show("Choose one of the option");
            }
        }
    }
}
