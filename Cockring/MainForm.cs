using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
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

        // Путь к файлу с пациентами
        private string patientsFilePath = "c:\\Patients\\patients.xlsx";

        public MainForm()
        {
            InitializeComponent();
        }

        // Кнопка выбор пациента
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

        // Поиск ардуино
        private string DetectArduinoPort()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();

                    if (desc.Contains("Arduino"))
                    {
                        return deviceId;
                    }
                }
            }
            catch (ManagementException)
            {
                /* Do Nothing */
            }

            return null;
        }
        // Подключениие или откл от Ардуино в зависимости от значения флага
        private void ConnectOrDisconnectToArduino()
        {
            if (!isConnected)
            {
                string arduinoPort = DetectArduinoPort();
                if (!string.IsNullOrEmpty(arduinoPort))
                {
                    isConnected = true;
                    serialPort.PortName = arduinoPort;
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    serialPort.Open();
                    connectButton.Text = "Отключиться";
                }
                else
                {
                    MessageBox.Show("Arduino не обнаружена. Убедитесь, что она подключена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                disconnectFromArduino();
            }
        }

        // Отключение от ардуино
        private void disconnectFromArduino()
        {
            if (isConnected)
            {
                isConnected = false;
                serialPort.Close();
                connectButton.Text = "Подключиться";
            }
        }

        // Кнопка для подключения
        private void connectButton_Click(object sender, EventArgs e)
        {
            ConnectOrDisconnectToArduino();
        }

        //Кнопка "Выход"
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Кнопка реабилитирующие упражнения
        private void buttonRehabilitatingExercises_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (isSelectedPatient)
                {
                    // код для обработки клика на кнопку в режиме подключения
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

        // Кнопка для ассистирующего режима
        private void buttonAssistingMode_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                // код для обработки клика на кнопку в режиме подключения
            }
            else
            {
                MessageBox.Show("Необходимо установить подключение к устройству", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Кнопка информация
        private void buttonInformation_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort.Write("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort.Write("0");
        }

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string data = sp.ReadLine();
            textBoxArduinoData.Invoke(new Action(() => textBoxArduinoData.Text = data));
        }
    }
}
