using Microsoft.Vbe.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceReHub
{
    public partial class EditPatientForm : System.Windows.Forms.Form
    {
        private List<Patient> patientList;
        private Patient patient;
        private DataGridView dataGridView;

        public EditPatientForm(List<Patient> patientList, Patient patient, DataGridView dataGridView)
        {
            InitializeComponent();
            this.patientList = patientList;
            this.patient = patient;
            this.dataGridView = dataGridView;

            txtLastName.Text = patient.LastName;
            txtFirstName.Text = patient.FirstName;
            txtMiddleName.Text = patient.MiddleName;
            txtThighLength.Text = patient.ThighLength.ToString();
            txtCalfLength.Text = patient.CalfLength.ToString();
            txtFootLength.Text = patient.FootLength.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            patient.FirstName = txtFirstName.Text;
            patient.LastName = txtLastName.Text;
            patient.MiddleName = txtMiddleName.Text;

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Не указана фамилия.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Не указано имя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtMiddleName.Text))
            {
                MessageBox.Show("Не указано отчество.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                        
            if (double.TryParse(txtThighLength.Text, out double thighLength))
            {
                patient.ThighLength = thighLength;
            }
            else
            {
                MessageBox.Show("Не указано длина бедра.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (double.TryParse(txtCalfLength.Text, out double calfLength))
            {
                patient.CalfLength = calfLength;
            }
            else
            {
                MessageBox.Show("Не указана длина голени.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (double.TryParse(txtFootLength.Text, out double footLength))
            {
                patient.FootLength = footLength;
            }
            else
            {
                MessageBox.Show("Не указана высота ступни.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdateDataGridView(); // Call method to update DataGridView
            DialogResult = DialogResult.OK;
        }
        private void UpdateDataGridView()
        {
            if (dataGridView != null)
            {
                dataGridView.Rows.Clear();

                foreach (Patient patient in patientList)
                {
                    dataGridView.Rows.Add(patient.FirstName, patient.LastName, patient.MiddleName, patient.ThighLength, patient.CalfLength, patient.FootLength);
                }
            }
        }
    }
}
