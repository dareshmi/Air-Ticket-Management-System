namespace Air_Ticket_Management_System
{
    partial class Booking
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
            this.label11 = new System.Windows.Forms.Label();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFlightRecords = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.PassangerIDField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NationalityField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PassportNumField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlightRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(625, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 27);
            this.label11.TabIndex = 47;
            this.label11.Text = "Booking List";
            // 
            // dgvBooking
            // 
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(465, 244);
            this.dgvBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.RowTemplate.Height = 24;
            this.dgvBooking.Size = new System.Drawing.Size(448, 167);
            this.dgvBooking.TabIndex = 68;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnBook.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(256, 437);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(116, 39);
            this.btnBook.TabIndex = 71;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Crimson;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(542, 437);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(116, 39);
            this.btnLogout.TabIndex = 72;
            this.btnLogout.Text = "Back";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(400, 437);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 39);
            this.btnCancel.TabIndex = 77;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(145, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 78;
            this.label2.Text = "Filght List";
            // 
            // dgvFlightRecords
            // 
            this.dgvFlightRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlightRecords.Location = new System.Drawing.Point(12, 244);
            this.dgvFlightRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFlightRecords.Name = "dgvFlightRecords";
            this.dgvFlightRecords.RowHeadersWidth = 51;
            this.dgvFlightRecords.RowTemplate.Height = 24;
            this.dgvFlightRecords.Size = new System.Drawing.Size(447, 167);
            this.dgvFlightRecords.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(395, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 27);
            this.label1.TabIndex = 80;
            this.label1.Text = "Ticket Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 27);
            this.label3.TabIndex = 81;
            this.label3.Text = "Name";
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(191, 56);
            this.NameField.Multiline = true;
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(208, 36);
            this.NameField.TabIndex = 82;
            // 
            // PassangerIDField
            // 
            this.PassangerIDField.Location = new System.Drawing.Point(187, 110);
            this.PassangerIDField.Multiline = true;
            this.PassangerIDField.Name = "PassangerIDField";
            this.PassangerIDField.Size = new System.Drawing.Size(212, 36);
            this.PassangerIDField.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 27);
            this.label4.TabIndex = 83;
            this.label4.Text = "Passenger ID";
            // 
            // AmountField
            // 
            this.AmountField.Location = new System.Drawing.Point(647, 164);
            this.AmountField.Multiline = true;
            this.AmountField.Name = "AmountField";
            this.AmountField.Size = new System.Drawing.Size(191, 36);
            this.AmountField.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(510, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 27);
            this.label5.TabIndex = 85;
            this.label5.Text = "Amount";
            // 
            // NationalityField
            // 
            this.NationalityField.Location = new System.Drawing.Point(647, 110);
            this.NationalityField.Multiline = true;
            this.NationalityField.Name = "NationalityField";
            this.NationalityField.Size = new System.Drawing.Size(199, 36);
            this.NationalityField.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(478, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 27);
            this.label7.TabIndex = 89;
            this.label7.Text = "Nationality";
            // 
            // PassportNumField
            // 
            this.PassportNumField.Location = new System.Drawing.Point(647, 56);
            this.PassportNumField.Multiline = true;
            this.PassportNumField.Name = "PassportNumField";
            this.PassportNumField.Size = new System.Drawing.Size(199, 36);
            this.PassportNumField.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(460, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 27);
            this.label8.TabIndex = 87;
            this.label8.Text = "Passport Num";
            // 
            // EmailField
            // 
            this.EmailField.Location = new System.Drawing.Point(187, 164);
            this.EmailField.Multiline = true;
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(212, 36);
            this.EmailField.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 27);
            this.label6.TabIndex = 91;
            this.label6.Text = "Email";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 514);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NationalityField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PassportNumField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AmountField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PassangerIDField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFlightRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.dgvBooking);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Booking_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlightRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFlightRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox PassangerIDField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AmountField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NationalityField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PassportNumField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.Label label6;
    }
}