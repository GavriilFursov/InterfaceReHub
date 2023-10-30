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
    public partial class AddPatientForm : System.Windows.Forms.Form
    {
        private List<Patient> patientList;
        public AddPatientForm(List<Patient> patientList)
        {
            InitializeComponent();
            this.patientList = patientList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string middleName = txtMiddleName.Text;
            double thighLength, calfLength, footLength;

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
            if (!double.TryParse(txtThighLength.Text, out thighLength))
            {
                MessageBox.Show("Не указана длина бедра.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtCalfLength.Text, out calfLength))
            {
                MessageBox.Show("Не указана длина голени.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtFootLength.Text, out footLength))
            {
                MessageBox.Show("Не указана высота ступни.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Patient patient = new Patient()
            {
                FirstName = firstName,
                LastName = lastName,
                MiddleName = middleName,
                ThighLength = thighLength,
                CalfLength = calfLength,
                FootLength = footLength
            };
            patientList.Add(patient);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}