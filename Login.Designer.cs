namespace Air_Ticket_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.passportnum = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.RegisterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(191, 153);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 38);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(191, 213);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 38);
            this.textBox2.TabIndex = 3;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Blue;
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LoginBtn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(300, 257);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(105, 34);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Blue;
            this.Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Register.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Register.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.Color.White;
            this.Register.Location = new System.Drawing.Point(191, 257);
            this.Register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(105, 34);
            this.Register.TabIndex = 5;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RegisterPanel.Controls.Add(this.EmailField);
            this.RegisterPanel.Controls.Add(this.label5);
            this.RegisterPanel.Controls.Add(this.passportnum);
            this.RegisterPanel.Controls.Add(this.RegisterBtn);
            this.RegisterPanel.Controls.Add(this.PasswordField);
            this.RegisterPanel.Controls.Add(this.RegistrationLabel);
            this.RegisterPanel.Controls.Add(this.PasswordLabel);
            this.RegisterPanel.Controls.Add(this.EmailLabel);
            this.RegisterPanel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPanel.Location = new System.Drawing.Point(4, 2);
            this.RegisterPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(925, 518);
            this.RegisterPanel.TabIndex = 6;
            this.RegisterPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 27);
            this.label5.TabIndex = 38;
            this.label5.Text = "Passport Num";
            // 
            // passportnum
            // 
            this.passportnum.Location = new System.Drawing.Point(382, 146);
            this.passportnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passportnum.Multiline = true;
            this.passportnum.Name = "passportnum";
            this.passportnum.Size = new System.Drawing.Size(272, 27);
            this.passportnum.TabIndex = 37;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.Blue;
            this.RegisterBtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(385, 331);
            this.RegisterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(155, 52);
            this.RegisterBtn.TabIndex = 11;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.Location = new System.Drawing.Point(383, 249);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordField.Multiline = true;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(271, 34);
            this.PasswordField.TabIndex = 9;
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationLabel.Location = new System.Drawing.Point(287, 38);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(380, 70);
            this.RegistrationLabel.TabIndex = 5;
            this.RegistrationLabel.Text = "Registration";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(233, 251);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(122, 27);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(282, 199);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(73, 27);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email";
            // 
            // EmailField
            // 
            this.EmailField.Location = new System.Drawing.Point(382, 199);
            this.EmailField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailField.Multiline = true;
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(272, 27);
            this.EmailField.TabIndex = 39;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(917, 514);
            this.Controls.Add(this.RegisterPanel);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Air Ticket Management System";
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Panel RegisterPanel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passportnum;
        private System.Windows.Forms.TextBox EmailField;
    }
}

