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
        bool isSelectedPatient = false;

        private string patientsFilePath = "c:\\Patients\\patients.xlsx"; // Путь к файлу с пациентами

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSelectPatients_Click(object sender, EventArgs e)
        {
            ArchivePatients archiveForm = new ArchivePatients(patientsFilePath);
            if (archiveForm.ShowDialog() == DialogResult.OK)
            {
                textBoxPatientFullName.Text = archiveForm.SelectedPatientFullName;
                isSelectedPatient = true;
                this.Controls.Remove(labelPrescriptionSelectionPatient);
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
            string selectedPort = comboBoxPort.GetItemText(comboBoxPort.SelectedItem);
            if (!string.IsNullOrEmpty(selectedPort))
            {
                isConnected = true;
                serialPort.PortName = selectedPort;
                serialPort.Open();
                connectButton.Text = "Отключиться";
            }
            else
            {
                MessageBox.Show("Выберите порт для подключения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void buttonRehabilitatingExercises_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (isSelectedPatient)
                {
                    // Ваш код для обработки клика на кнопку в режиме подключения
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать пациента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Необходимо установить подключение к устройству","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonAssistingMode_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                // Ваш код для обработки клика на кнопку в режиме подключения
            }
            else
            {
                MessageBox.Show("Необходимо установить подключение к устройству", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {

        }
    }
}
