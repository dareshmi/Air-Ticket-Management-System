namespace Air_Ticket_Management_System
{
    partial class BookingForPassenger
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
            this.EmailField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NationalityField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PassportNumField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PassangerIDField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFlightRecords = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BackBTn = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlightRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailField
            // 
            this.EmailField.Location = new System.Drawing.Point(188, 179);
            this.EmailField.Multiline = true;
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(212, 36);
            this.EmailField.TabIndex = 112;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 27);
            this.label6.TabIndex = 111;
            this.label6.Text = "Email";
            // 
            // NationalityField
            // 
            this.NationalityField.Location = new System.Drawing.Point(648, 125);
            this.NationalityField.Multiline = true;
            this.NationalityField.Name = "NationalityField";
            this.NationalityField.Size = new System.Drawing.Size(199, 36);
            this.NationalityField.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 27);
            this.label7.TabIndex = 109;
            this.label7.Text = "Nationality";
            // 
            // PassportNumField
            // 
            this.PassportNumField.Location = new System.Drawing.Point(648, 71);
            this.PassportNumField.Multiline = true;
            this.PassportNumField.Name = "PassportNumField";
            this.PassportNumField.Size = new System.Drawing.Size(199, 36);
            this.PassportNumField.TabIndex = 108;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(461, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 27);
            this.label8.TabIndex = 107;
            this.label8.Text = "Passport Num";
            // 
            // PassangerIDField
            // 
            this.PassangerIDField.Location = new System.Drawing.Point(188, 125);
            this.PassangerIDField.Multiline = true;
            this.PassangerIDField.Name = "PassangerIDField";
            this.PassangerIDField.Size = new System.Drawing.Size(212, 36);
            this.PassangerIDField.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 27);
            this.label4.TabIndex = 103;
            this.label4.Text = "Passenger ID";
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(192, 71);
            this.NameField.Multiline = true;
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(208, 36);
            this.NameField.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 27);
            this.label3.TabIndex = 101;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(396, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 27);
            this.label1.TabIndex = 100;
            this.label1.Text = "Ticket Book";
            // 
            // dgvFlightRecords
            // 
            this.dgvFlightRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlightRecords.Location = new System.Drawing.Point(13, 259);
            this.dgvFlightRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFlightRecords.Name = "dgvFlightRecords";
            this.dgvFlightRecords.RowHeadersWidth = 51;
            this.dgvFlightRecords.RowTemplate.Height = 24;
            this.dgvFlightRecords.Size = new System.Drawing.Size(447, 167);
            this.dgvFlightRecords.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(146, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 98;
            this.label2.Text = "Filght List";
            // 
            // BackBTn
            // 
            this.BackBTn.BackColor = System.Drawing.Color.Violet;
            this.BackBTn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBTn.Location = new System.Drawing.Point(543, 452);
            this.BackBTn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBTn.Name = "BackBTn";
            this.BackBTn.Size = new System.Drawing.Size(116, 39);
            this.BackBTn.TabIndex = 96;
            this.BackBTn.Text = "Back";
            this.BackBTn.UseVisualStyleBackColor = false;
            this.BackBTn.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnBook.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(257, 452);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(116, 39);
            this.btnBook.TabIndex = 95;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // dgvBooking
            // 
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(466, 259);
            this.dgvBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.RowTemplate.Height = 24;
            this.dgvBooking.Size = new System.Drawing.Size(448, 167);
            this.dgvBooking.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(626, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 27);
            this.label11.TabIndex = 93;
            this.label11.Text = "Booking List";
            // 
            // BookingForPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(925, 514);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NationalityField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PassportNumField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PassangerIDField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFlightRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackBTn);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.dgvBooking);
            this.Controls.Add(this.label11);
            this.Name = "BookingForPassenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingTicket";
            this.Load += new System.EventHandler(this.BookingForPassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlightRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NationalityField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PassportNumField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PassangerIDField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFlightRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackBTn;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Label label11;
    }
}