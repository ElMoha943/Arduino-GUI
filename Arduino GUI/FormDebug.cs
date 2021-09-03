using Solid.Arduino.Firmata;
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
    public partial class FormDebug : Form
    {
        public FormDebug()
        {
            InitializeComponent();
        }

        private void FormDebug_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BoardCapability cap = Form1.session.GetBoardCapability();
            dt.Columns.Add("Number");
            dt.Columns.Add("Input");
            dt.Columns.Add("Output");
            dt.Columns.Add("Analog");
            dt.Columns.Add("Pwm");
            dt.Columns.Add("Servo");
            dt.Columns.Add("Serial");
            foreach (var pin in cap.Pins)
            {
                dt.Rows.Add(pin.PinNumber, pin.DigitalInput, pin.DigitalOutput, pin.Analog, pin.Pwm, pin.Servo, pin.Serial);
            }
            dataGridView1.DataSource = dt;
        }
    }
}
