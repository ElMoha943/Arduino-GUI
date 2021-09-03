using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Arduino;
using Solid.Arduino.Firmata;
using System.Windows.Forms;
using Arduino_GUI;
using System.Runtime.InteropServices;

namespace Arduino_GUI
{
    public partial class Form1 : Form
    {
        private Form formActual;
        public static ArduinoSession session;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TEST CONNECTION
            ISerialConnection connection = GetConnection();
            Console.WriteLine("--------------------------------------");

            session = new ArduinoSession(connection);
        }

        //CONNECTION
        private ISerialConnection GetConnection()
        {
            labelStatus.Text = "Searching Arduino connection...";
            ISerialConnection connection = EnhancedSerialConnection.Find();

            if (connection == null)
                labelStatus.Text = "No connection found. Make shure your Arduino board is attached to a USB port.";
            else
                labelStatus.Text = $"Connected to port {connection.PortName} at {connection.BaudRate} baud.";

            return connection;
        }

        private void btnLeds_Click_1(object sender, EventArgs e)
        {
            abrirForm(new FormLeds());
        }

        private void btnSensors_Click(object sender, EventArgs e)
        {
            abrirForm(new FormSensors());
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            abrirForm(new FormDebug());
        }

        private void abrirForm(Form child)
        {
            if (formActual != null)
                formActual.Close();
            formActual = child;
            child.TopLevel = false;
            formHijo.Controls.Add(child);
            formHijo.Tag = child;
            child.BringToFront();
            child.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
