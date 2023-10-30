using System;

namespace InterfaceReHub
{
    partial class AddPatientForm
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
            this.txtFootLength = new System.Windows.Forms.TextBox();
            this.txtCalfLength = new System.Windows.Forms.TextBox();
            this.txtThighLength = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.LabelThighLength = new System.Windows.Forms.Label();
            this.labelCalfLength = new System.Windows.Forms.Label();
            this.labelFootLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFootLength
            // 
            this.txtFootLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFootLength.Location = new System.Drawing.Point(196, 337);
            this.txtFootLength.Name = "txtFootLength";
            this.txtFootLength.Size = new System.Drawing.Size(197, 29);
            this.txtFootLength.TabIndex = 21;
            // 
            // txtCalfLength
            // 
            this.txtCalfLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCalfLength.Location = new System.Drawing.Point(196, 289);
            this.txtCalfLength.Name = "txtCalfLength";
            this.txtCalfLength.Size = new System.Drawing.Size(197, 29);
            this.txtCalfLength.TabIndex = 20;
            // 
            // txtThighLength
            // 
            this.txtThighLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtThighLength.Location = new System.Drawing.Point(196, 240);
            this.txtThighLength.Name = "txtThighLength";
            this.txtThighLength.Size = new System.Drawing.Size(197, 29);
            this.txtThighLength.TabIndex = 19;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMiddleName.Location = new System.Drawing.Point(196, 189);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(197, 29);
            this.txtMiddleName.TabIndex = 18;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastName.Location = new System.Drawing.Point(196, 94);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(197, 29);
            this.txtLastName.TabIndex = 16;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(196, 140);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(197, 29);
            this.txtFirstName.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(109, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(189, 40);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(12, 97);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(82, 21);
            this.labelLastName.TabIndex = 22;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(12, 143);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(44, 21);
            this.labelFirstName.TabIndex = 23;
            this.labelFirstName.Text = "Имя";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(12, 192);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(86, 21);
            this.labelMiddleName.TabIndex = 24;
            this.labelMiddleName.Text = "Отчество";
            // 
            // LabelThighLength
            // 
            this.LabelThighLength.AutoSize = true;
            this.LabelThighLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelThighLength.Location = new System.Drawing.Point(12, 243);
            this.LabelThighLength.Name = "LabelThighLength";
            this.LabelThighLength.Size = new System.Drawing.Size(149, 21);
            this.LabelThighLength.TabIndex = 25;
            this.LabelThighLength.Text = "Длина бедра (см)";
            // 
            // labelCalfLength
            // 
            this.labelCalfLength.AutoSize = true;
            this.labelCalfLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCalfLength.Location = new System.Drawing.Point(12, 292);
            this.labelCalfLength.Name = "labelCalfLength";
            this.labelCalfLength.Size = new System.Drawing.Size(158, 21);
            this.labelCalfLength.TabIndex = 26;
            this.labelCalfLength.Text = "Длина голени (см)";
            // 
            // labelFootLength
            // 
            this.labelFootLength.AutoSize = true;
            this.labelFootLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFootLength.Location = new System.Drawing.Point(12, 340);
            this.labelFootLength.Name = "labelFootLength";
            this.labelFootLength.Size = new System.Drawing.Size(169, 21);
            this.labelFootLength.TabIndex = 27;
            this.labelFootLength.Text = "Высота ступни (см)";
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 389);
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
            this.Name = "AddPatientForm";
            this.Text = " Добавить пациента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFootLength;
        private System.Windows.Forms.TextBox txtCalfLength;
        private System.Windows.Forms.TextBox txtThighLength;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label LabelThighLength;
        private System.Windows.Forms.Label labelCalfLength;
        private System.Windows.Forms.Label labelFootLength;
    }
}