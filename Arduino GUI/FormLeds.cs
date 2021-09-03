using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_GUI
{
    public partial class FormLeds : Form
    {
        public FormLeds()
        {
            InitializeComponent();
        }

        private void toggleLed1_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleLed1.Checked == true)
                Form1.session.SetDigitalPin(10, true);
            else
                Form1.session.SetDigitalPin(10, false);
        }
    }
}
