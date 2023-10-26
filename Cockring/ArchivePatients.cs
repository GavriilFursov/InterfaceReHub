using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace InterfaceReHub
{
    public partial class ArchivePatients : System.Windows.Forms.Form
    {
        private string patientsFilePath;
        private Excel.Application excelApp;
        private Excel.Workbook workbook;
        private Excel.Worksheet worksheet;
        private List<Patient> patientList;
        private readonly DataGridView dataGridView;
        public string SelectedPatientFullName;

        public ArchivePatients(string patientsFilePath)
        {
            InitializeComponent();
            this.patientsFilePath = patientsFilePath;
            LoadPatients();
            dataGridViewPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // установка режима выделения полной строки
            dataGridViewPatients.SelectionChanged += DataGridViewPatients_SelectionChanged; // подписываемся на событие выбора строки
        }

        private void LoadPatients()
        {
            excelApp = new Excel.Application();
            patientList = new List<Patient>();

            workbook = excelApp.Workbooks.Open(patientsFilePath);
            worksheet = workbook.ActiveSheet;


            int rowCount = worksheet.UsedRange.Rows.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                var firstName = worksheet.Cells[i, 1].Value;
                var lastName = worksheet.Cells[i, 2].Value;
                var middleName = worksheet.Cells[i, 3].Value;
                var thighLength = worksheet.Cells[i, 4].Value;
                var calfLength = worksheet.Cells[i, 5].Value;
                var footLength = worksheet.Cells[i, 6].Value;

                if (firstName != null)
                {
                    Patient patient = new Patient()
                    {
                        FirstName = firstName.ToString(),
                        LastName = lastName != null ? lastName.ToString() : "",
                        MiddleName = middleName != null ? middleName.ToString() : "",
                        ThighLength = thighLength != null ? double.Parse(thighLength.ToString()) : 0,
                        CalfLength = calfLength != null ? double.Parse(calfLength.ToString()) : 0,
                        FootLength = footLength != null ? double.Parse(footLength.ToString()) : 0
                    };

                    patientList.Add(patient);
                }
            }
            workbook.Close();
            excelApp.Quit();
            UpdatePatientsList();
        }

        private void SavePatients()
        {
            excelApp = new Excel.Application();
            workbook = excelApp.Workbooks.Open(patientsFilePath);
            worksheet = workbook.ActiveSheet;

            int rowCount = worksheet.UsedRange.Rows.Count;

            // Удаление всех данных о пациентах в эксель файле
            for (int i = rowCount; i >= 1; i--)
            {
                worksheet.Rows[i].Delete();
            }

            // Запись данных о пациентах в эксель файл
            for (int i = 0; i < patientList.Count; i++)
            {
                Patient patient = patientList[i];
                worksheet.Cells[i + 1, 1] = patient.FirstName;
                worksheet.Cells[i + 1, 2] = patient.LastName;
                worksheet.Cells[i + 1, 3] = patient.MiddleName;
                worksheet.Cells[i + 1, 4] = patient.ThighLength;
                worksheet.Cells[i + 1, 5] = patient.CalfLength;
                worksheet.Cells[i + 1, 6] = patient.FootLength;
            }

            workbook.Save();
            workbook.Close();
            excelApp.Quit();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm(patientList);
            if (addPatientForm.ShowDialog() == DialogResult.OK)
            {
                SavePatients();
                UpdatePatientsList();
            }
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridViewPatients.SelectedRows[0].Index;

            if (selectedIndex != -1)
            {
                // Проверяем, что выбранная строка не пуста
                if (dataGridViewPatients.Rows[selectedIndex].Cells[0].Value != null && !string.IsNullOrEmpty(dataGridViewPatients.Rows[selectedIndex].Cells[0].Value.ToString()))
                {
                    Patient selectedPatient = patientList[selectedIndex];
                    EditPatientForm editPatientForm = new EditPatientForm(patientList, selectedPatient, dataGridView);
                    if (editPatientForm.ShowDialog() == DialogResult.OK)
                    {
                        SavePatients();
                        UpdatePatientsList();
                    }
                }
                else
                {
                    MessageBox.Show("Вы выбрали пустую строку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите пациента для изменения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridViewPatients.SelectedRows[0].Index;

            if (selectedIndex != -1)
            {
                // Проверяем, что выбранная строка не пуста
                if (dataGridViewPatients.Rows[selectedIndex].Cells[0].Value != null && !string.IsNullOrEmpty(dataGridViewPatients.Rows[selectedIndex].Cells[0].Value.ToString()))
                {
                    patientList.RemoveAt(selectedIndex);
                    SavePatients();
                    UpdatePatientsList();
                }
                else
                {
                    MessageBox.Show("Вы выбрали пустую строку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите пациента для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePatientsList()
        {
            dataGridViewPatients.Rows.Clear();

            foreach (Patient patient in patientList)
            {
                dataGridViewPatients.Rows.Add(patient.LastName, patient.FirstName, patient.MiddleName, patient.ThighLength, patient.CalfLength, patient.FootLength);
            }
        }
        private void DataGridViewPatients_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewPatients.SelectionChanged -= DataGridViewPatients_SelectionChanged; // отписываемся от события

            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewPatients.SelectedRows[0].Index;
                dataGridViewPatients.ClearSelection();
                dataGridViewPatients.Rows[selectedIndex].Selected = true;
            }

            dataGridViewPatients.SelectionChanged += DataGridViewPatients_SelectionChanged; // подписываемся на событие
        }

        public Patient SelectedPatient { get; private set; }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            dataGridViewPatients.SelectionChanged -= DataGridViewPatients_SelectionChanged;

            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewPatients.SelectedRows[0].Index;
                dataGridViewPatients.ClearSelection();
                dataGridViewPatients.Rows[selectedIndex].Selected = true;
                SelectedPatient = patientList[selectedIndex];
                SelectedPatientFullName = $"{SelectedPatient.LastName} {SelectedPatient.FirstName} {SelectedPatient.MiddleName}";
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите пациента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridViewPatients.SelectionChanged += DataGridViewPatients_SelectionChanged;
        }
    }
}
