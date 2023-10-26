namespace InterfaceReHub
{
    partial class EditPatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFootLength = new System.Windows.Forms.TextBox();
            this.txtCalfLength = new System.Windows.Forms.TextBox();
            this.txtThighLength = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(29, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFootLength
            // 
            this.txtFootLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFootLength.Location = new System.Drawing.Point(29, 349);
            this.txtFootLength.Name = "txtFootLength";
            this.txtFootLength.Size = new System.Drawing.Size(183, 29);
            this.txtFootLength.TabIndex = 14;
            this.txtFootLength.Text = "Длина ступни (см)";
            // 
            // txtCalfLength
            // 
            this.txtCalfLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCalfLength.Location = new System.Drawing.Point(29, 301);
            this.txtCalfLength.Name = "txtCalfLength";
            this.txtCalfLength.Size = new System.Drawing.Size(183, 29);
            this.txtCalfLength.TabIndex = 13;
            this.txtCalfLength.Text = "Длина голени (см)";
            // 
            // txtThighLength
            // 
            this.txtThighLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtThighLength.Location = new System.Drawing.Point(29, 252);
            this.txtThighLength.Name = "txtThighLength";
            this.txtThighLength.Size = new System.Drawing.Size(183, 29);
            this.txtThighLength.TabIndex = 12;
            this.txtThighLength.Text = "Длина бедра (см)";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMiddleName.Location = new System.Drawing.Point(29, 201);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(183, 29);
            this.txtMiddleName.TabIndex = 11;
            this.txtMiddleName.Text = "Отчество";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastName.Location = new System.Drawing.Point(29, 106);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(183, 29);
            this.txtLastName.TabIndex = 9;
            this.txtLastName.Text = "Фамилия";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(29, 152);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(183, 29);
            this.txtFirstName.TabIndex = 10;
            this.txtFirstName.Text = "Имя";
            // 
            // EditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 404);
            this.Controls.Add(this.txtFootLength);
            this.Controls.Add(this.txtCalfLength);
            this.Controls.Add(this.txtThighLength);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnSave);
            this.Name = "EditPatientForm";
            this.Text = "Изменить пациента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFootLength;
        private System.Windows.Forms.TextBox txtCalfLength;
        private System.Windows.Forms.TextBox txtThighLength;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
    }
}