using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace InterfaceReHub
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public string SelectedPatientFullName { get; set; }
        bool isConnected = false;
        private string patientsFilePath = "c:\\Patients\\patients.xlsx"; // Путь к файлу с пациентами

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArchivePatients archiveForm = new ArchivePatients(patientsFilePath);
            if (archiveForm.ShowDialog() == DialogResult.OK)
            {
                textBoxPatientFullName.Text = archiveForm.SelectedPatientFullName;
            }
        }

        private void arduinoButton_Click(object sender, EventArgs e) 
        {
            comboBoxPort.Items.Clear();
            string[] portnames = SerialPort.GetPortNames();
            if (portnames.Length == 0)
            {
                MessageBox.Show("COM PORT not found");
            }
            foreach (string portName in portnames)
            {
                comboBoxPort.Items.Add(portName);
                Console.WriteLine(portnames.Length);
                if (portnames[0] != null)
                {
                    comboBoxPort.SelectedItem = portnames[0];
                }
            }
        }
        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBoxPort.GetItemText(comboBoxPort.SelectedItem);
            serialPort.PortName = selectedPort;
            serialPort.Open();
            connectButton.Text = "Отключиться";
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            serialPort.Close();
            connectButton.Text = "Подключиться";
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
