using System;

namespace Air_Ticket_Management_System
{
    partial class EmployeeRecord
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
            this.ResetBtn = new System.Windows.Forms.Button();
            this.RecordBtn = new System.Windows.Forms.Button();
            this.PhoneNumField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeIDField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NationalityField = new System.Windows.Forms.TextBox();
            this.GenderField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.DarkViolet;
            this.ResetBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ResetBtn.Location = new System.Drawing.Point(461, 256);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(120, 39);
            this.ResetBtn.TabIndex = 54;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // RecordBtn
            // 
            this.RecordBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.RecordBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RecordBtn.Location = new System.Drawing.Point(174, 256);
            this.RecordBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecordBtn.Name = "RecordBtn";
            this.RecordBtn.Size = new System.Drawing.Size(120, 39);
            this.RecordBtn.TabIndex = 53;
            this.RecordBtn.Text = "Record";
            this.RecordBtn.UseVisualStyleBackColor = false;
            this.RecordBtn.Click += new System.EventHandler(this.RecordBtn_Click);
            // 
            // PhoneNumField
            // 
            this.PhoneNumField.Location = new System.Drawing.Point(659, 147);
            this.PhoneNumField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneNumField.Multiline = true;
            this.PhoneNumField.Name = "PhoneNumField";
            this.PhoneNumField.Size = new System.Drawing.Size(187, 27);
            this.PhoneNumField.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(507, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 27);
            this.label9.TabIndex = 51;
            this.label9.Text = "Phone Num";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(510, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 27);
            this.label8.TabIndex = 48;
            this.label8.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(507, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 27);
            this.label7.TabIndex = 47;
            this.label7.Text = "Nationality";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 42;
            this.label2.Text = "Employee ID";
            // 
            // EmployeeIDField
            // 
            this.EmployeeIDField.Location = new System.Drawing.Point(237, 90);
            this.EmployeeIDField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeIDField.Multiline = true;
            this.EmployeeIDField.Name = "EmployeeIDField";
            this.EmployeeIDField.Size = new System.Drawing.Size(233, 27);
            this.EmployeeIDField.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 27);
            this.label4.TabIndex = 40;
            this.label4.Text = "Employee Name";
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new System.Drawing.Point(237, 144);
            this.EmployeeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeName.Multiline = true;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(233, 27);
            this.EmployeeName.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(350, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 28);
            this.label3.TabIndex = 37;
            this.label3.Text = "Record Employee";
            // 
            // NationalityField
            // 
            this.NationalityField.Location = new System.Drawing.Point(659, 85);
            this.NationalityField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NationalityField.Multiline = true;
            this.NationalityField.Name = "NationalityField";
            this.NationalityField.Size = new System.Drawing.Size(187, 32);
            this.NationalityField.TabIndex = 56;
            // 
            // GenderField
            // 
            this.GenderField.Location = new System.Drawing.Point(662, 203);
            this.GenderField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenderField.Multiline = true;
            this.GenderField.Name = "GenderField";
            this.GenderField.Size = new System.Drawing.Size(184, 27);
            this.GenderField.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 27);
            this.label5.TabIndex = 58;
            this.label5.Text = "Password";
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(237, 195);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordField.Multiline = true;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(233, 27);
            this.PasswordField.TabIndex = 57;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.DarkViolet;
            this.BackBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackBtn.Location = new System.Drawing.Point(606, 256);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(120, 39);
            this.BackBtn.TabIndex = 59;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.DeleteBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DeleteBtn.Location = new System.Drawing.Point(317, 256);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(120, 39);
            this.DeleteBtn.TabIndex = 60;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(50, 317);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 51;
            this.dataGridViewEmployees.RowTemplate.Height = 24;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(800, 150);
            this.dataGridViewEmployees.TabIndex = 61;
            // 
            // EmployeeRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(925, 514);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.NationalityField);
            this.Controls.Add(this.GenderField);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.RecordBtn);
            this.Controls.Add(this.PhoneNumField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmployeeIDField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeRecord";
            this.Load += new System.EventHandler(this.EmployeeRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button RecordBtn;
        private System.Windows.Forms.TextBox PhoneNumField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmployeeIDField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NationalityField;
        private System.Windows.Forms.TextBox GenderField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
    }
}