namespace Air_Ticket_Management_System
{
    partial class ViewPassengers
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
            this.label3 = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.passportnum = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.PassengerEmailField = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PassengerIDField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(321, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "View Passengers";
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.DarkViolet;
            this.ResetBtn.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(368, 298);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(104, 36);
            this.ResetBtn.TabIndex = 44;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.BackBtn.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(616, 298);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(104, 36);
            this.BackBtn.TabIndex = 43;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DarkViolet;
            this.DeleteBtn.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(495, 298);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(104, 36);
            this.DeleteBtn.TabIndex = 42;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(91, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 163);
            this.dataGridView1.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 27);
            this.label5.TabIndex = 78;
            this.label5.Text = "Passport NUM";
            // 
            // passportnum
            // 
            this.passportnum.Location = new System.Drawing.Point(405, 140);
            this.passportnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passportnum.Multiline = true;
            this.passportnum.Name = "passportnum";
            this.passportnum.Size = new System.Drawing.Size(203, 35);
            this.passportnum.TabIndex = 77;
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.Location = new System.Drawing.Point(405, 242);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordField.Multiline = true;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(203, 34);
            this.PasswordField.TabIndex = 74;
            // 
            // PassengerEmailField
            // 
            this.PassengerEmailField.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerEmailField.Location = new System.Drawing.Point(405, 196);
            this.PassengerEmailField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassengerEmailField.Multiline = true;
            this.PassengerEmailField.Name = "PassengerEmailField";
            this.PassengerEmailField.Size = new System.Drawing.Size(203, 30);
            this.PassengerEmailField.TabIndex = 73;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(255, 244);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(122, 27);
            this.PasswordLabel.TabIndex = 71;
            this.PasswordLabel.Text = "Password";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(180, 198);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(197, 27);
            this.EmailLabel.TabIndex = 70;
            this.EmailLabel.Text = "Passenger Email";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DarkViolet;
            this.UpdateBtn.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(245, 298);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(104, 36);
            this.UpdateBtn.TabIndex = 87;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 27);
            this.label2.TabIndex = 89;
            this.label2.Text = "PassengerID";
            // 
            // PassengerIDField
            // 
            this.PassengerIDField.Location = new System.Drawing.Point(405, 89);
            this.PassengerIDField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassengerIDField.Multiline = true;
            this.PassengerIDField.Name = "PassengerIDField";
            this.PassengerIDField.Size = new System.Drawing.Size(203, 35);
            this.PassengerIDField.TabIndex = 88;
            // 
            // ViewPassengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(926, 515);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassengerIDField);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passportnum);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.PassengerEmailField);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label3);
            this.Name = "ViewPassengers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPassengers";
            this.Load += new System.EventHandler(this.ViewPassengers_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passportnum;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox PassengerEmailField;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassengerIDField;
    }
}