namespace InterfaceReHub
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.buttonSelectPatients = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.arduinoButton = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonInformation = new System.Windows.Forms.Button();
            this.labelPrescriptionSelectionPatient = new System.Windows.Forms.Label();
            this.buttonAssistingMode = new System.Windows.Forms.Button();
            this.buttonRehabilitatingExercises = new System.Windows.Forms.Button();
            this.textBoxPatientFullName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSelectPatients
            // 
            this.buttonSelectPatients.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectPatients.Location = new System.Drawing.Point(951, 11);
            this.buttonSelectPatients.Name = "buttonSelectPatients";
            this.buttonSelectPatients.Size = new System.Drawing.Size(213, 50);
            this.buttonSelectPatients.TabIndex = 0;
            this.buttonSelectPatients.Text = "Выбор пациента";
            this.buttonSelectPatients.UseVisualStyleBackColor = true;
            this.buttonSelectPatients.Click += new System.EventHandler(this.buttonSelectPatients_Click);
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectButton.Location = new System.Drawing.Point(32, 121);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(140, 49);
            this.connectButton.TabIndex = 18;
            this.connectButton.Text = "Подключиться";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(32, 75);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(140, 21);
            this.comboBoxPort.TabIndex = 17;
            // 
            // arduinoButton
            // 
            this.arduinoButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arduinoButton.Location = new System.Drawing.Point(32, 11);
            this.arduinoButton.Name = "arduinoButton";
            this.arduinoButton.Size = new System.Drawing.Size(140, 49);
            this.arduinoButton.TabIndex = 16;
            this.arduinoButton.Text = "Выберите порт";
            this.arduinoButton.UseVisualStyleBackColor = true;
            this.arduinoButton.Click += new System.EventHandler(this.arduinoButton_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(1089, 747);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 33);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonInformation
            // 
            this.buttonInformation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInformation.Location = new System.Drawing.Point(32, 747);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(140, 33);
            this.buttonInformation.TabIndex = 14;
            this.buttonInformation.Text = "Информация";
            this.buttonInformation.UseVisualStyleBackColor = true;
            this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // labelPrescriptionSelectionPatient
            // 
            this.labelPrescriptionSelectionPatient.AutoSize = true;
            this.labelPrescriptionSelectionPatient.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrescriptionSelectionPatient.ForeColor = System.Drawing.Color.Red;
            this.labelPrescriptionSelectionPatient.Location = new System.Drawing.Point(445, 59);
            this.labelPrescriptionSelectionPatient.Name = "labelPrescriptionSelectionPatient";
            this.labelPrescriptionSelectionPatient.Size = new System.Drawing.Size(285, 15);
            this.labelPrescriptionSelectionPatient.TabIndex = 13;
            this.labelPrescriptionSelectionPatient.Text = "Перед началом реабилитации, выберите пациента";
            // 
            // buttonAssistingMode
            // 
            this.buttonAssistingMode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAssistingMode.Location = new System.Drawing.Point(404, 380);
            this.buttonAssistingMode.Name = "buttonAssistingMode";
            this.buttonAssistingMode.Size = new System.Drawing.Size(357, 80);
            this.buttonAssistingMode.TabIndex = 12;
            this.buttonAssistingMode.Text = "Ассистирующий режим";
            this.buttonAssistingMode.UseVisualStyleBackColor = true;
            this.buttonAssistingMode.Click += new System.EventHandler(this.buttonAssistingMode_Click);
            // 
            // buttonRehabilitatingExercises
            // 
            this.buttonRehabilitatingExercises.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRehabilitatingExercises.Location = new System.Drawing.Point(404, 272);
            this.buttonRehabilitatingExercises.Name = "buttonRehabilitatingExercises";
            this.buttonRehabilitatingExercises.Size = new System.Drawing.Size(356, 80);
            this.buttonRehabilitatingExercises.TabIndex = 11;
            this.buttonRehabilitatingExercises.Text = "Реабилитирующие упражнения";
            this.buttonRehabilitatingExercises.UseVisualStyleBackColor = true;
            this.buttonRehabilitatingExercises.Click += new System.EventHandler(this.buttonRehabilitatingExercises_Click);
            // 
            // textBoxPatientFullName
            // 
            this.textBoxPatientFullName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatientFullName.Location = new System.Drawing.Point(379, 27);
            this.textBoxPatientFullName.Name = "textBoxPatientFullName";
            this.textBoxPatientFullName.Size = new System.Drawing.Size(405, 29);
            this.textBoxPatientFullName.TabIndex = 20;
            this.textBoxPatientFullName.Text = "Пациент не выбран";
            this.textBoxPatientFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 792);
            this.Controls.Add(this.textBoxPatientFullName);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.arduinoButton);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonInformation);
            this.Controls.Add(this.labelPrescriptionSelectionPatient);
            this.Controls.Add(this.buttonAssistingMode);
            this.Controls.Add(this.buttonRehabilitatingExercises);
            this.Controls.Add(this.buttonSelectPatients);
            this.Name = "MainForm";
            this.Text = "ReHab Монитор пациента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectPatients;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Button arduinoButton;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonInformation;
        private System.Windows.Forms.Label labelPrescriptionSelectionPatient;
        private System.Windows.Forms.Button buttonAssistingMode;
        private System.Windows.Forms.Button buttonRehabilitatingExercises;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox textBoxPatientFullName;
    }
}

