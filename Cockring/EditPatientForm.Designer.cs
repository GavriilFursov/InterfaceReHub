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
            this.labelFootLength = new System.Windows.Forms.Label();
            this.labelCalfLength = new System.Windows.Forms.Label();
            this.LabelThighLength = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(114, 12);
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
            this.txtFootLength.Location = new System.Drawing.Point(197, 340);
            this.txtFootLength.Name = "txtFootLength";
            this.txtFootLength.Size = new System.Drawing.Size(197, 29);
            this.txtFootLength.TabIndex = 14;
            // 
            // txtCalfLength
            // 
            this.txtCalfLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCalfLength.Location = new System.Drawing.Point(197, 292);
            this.txtCalfLength.Name = "txtCalfLength";
            this.txtCalfLength.Size = new System.Drawing.Size(197, 29);
            this.txtCalfLength.TabIndex = 13;
            // 
            // txtThighLength
            // 
            this.txtThighLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtThighLength.Location = new System.Drawing.Point(197, 243);
            this.txtThighLength.Name = "txtThighLength";
            this.txtThighLength.Size = new System.Drawing.Size(197, 29);
            this.txtThighLength.TabIndex = 12;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMiddleName.Location = new System.Drawing.Point(197, 192);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(197, 29);
            this.txtMiddleName.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastName.Location = new System.Drawing.Point(197, 97);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(197, 29);
            this.txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(197, 143);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(197, 29);
            this.txtFirstName.TabIndex = 10;
            // 
            // labelFootLength
            // 
            this.labelFootLength.AutoSize = true;
            this.labelFootLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFootLength.Location = new System.Drawing.Point(12, 343);
            this.labelFootLength.Name = "labelFootLength";
            this.labelFootLength.Size = new System.Drawing.Size(169, 21);
            this.labelFootLength.TabIndex = 33;
            this.labelFootLength.Text = "Высота ступни (см)";
            // 
            // labelCalfLength
            // 
            this.labelCalfLength.AutoSize = true;
            this.labelCalfLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCalfLength.Location = new System.Drawing.Point(12, 295);
            this.labelCalfLength.Name = "labelCalfLength";
            this.labelCalfLength.Size = new System.Drawing.Size(158, 21);
            this.labelCalfLength.TabIndex = 32;
            this.labelCalfLength.Text = "Длина голени (см)";
            // 
            // LabelThighLength
            // 
            this.LabelThighLength.AutoSize = true;
            this.LabelThighLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelThighLength.Location = new System.Drawing.Point(12, 246);
            this.LabelThighLength.Name = "LabelThighLength";
            this.LabelThighLength.Size = new System.Drawing.Size(149, 21);
            this.LabelThighLength.TabIndex = 31;
            this.LabelThighLength.Text = "Длина бедра (см)";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(12, 195);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(86, 21);
            this.labelMiddleName.TabIndex = 30;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(12, 146);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(44, 21);
            this.labelFirstName.TabIndex = 29;
            this.labelFirstName.Text = "Имя";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(12, 100);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(82, 21);
            this.labelLastName.TabIndex = 28;
            this.labelLastName.Text = "Фамилия";
            // 
            // EditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 388);
            this.Controls.Add(this.labelFootLength);
            this.Controls.Add(this.labelCalfLength);
            this.Controls.Add(this.LabelThighLength);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastName);
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
        private System.Windows.Forms.Label labelFootLength;
        private System.Windows.Forms.Label labelCalfLength;
        private System.Windows.Forms.Label LabelThighLength;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
    }
}