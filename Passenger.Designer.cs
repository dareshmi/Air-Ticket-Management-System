namespace Air_Ticket_Management_System
{
    partial class Passenger
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBookingDetails = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.BookBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(316, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 28);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ticket Booking";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 27);
            this.label5.TabIndex = 39;
            this.label5.Text = "Ticket ID";
            // 
            // dgvBookingDetails
            // 
            this.dgvBookingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingDetails.Location = new System.Drawing.Point(43, 293);
            this.dgvBookingDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBookingDetails.Name = "dgvBookingDetails";
            this.dgvBookingDetails.RowHeadersWidth = 51;
            this.dgvBookingDetails.RowTemplate.Height = 24;
            this.dgvBookingDetails.Size = new System.Drawing.Size(861, 210);
            this.dgvBookingDetails.TabIndex = 47;
            this.dgvBookingDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SearchBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(232, 158);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(132, 49);
            this.SearchBtn.TabIndex = 49;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(397, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 27);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ticket List";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(388, 105);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(229, 34);
            this.textBoxSearch.TabIndex = 52;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LogoutBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(546, 158);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(132, 49);
            this.LogoutBtn.TabIndex = 55;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // BookBtn
            // 
            this.BookBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BookBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookBtn.Location = new System.Drawing.Point(388, 158);
            this.BookBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(132, 49);
            this.BookBtn.TabIndex = 56;
            this.BookBtn.Text = "Book";
            this.BookBtn.UseVisualStyleBackColor = false;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // Passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(925, 514);
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.dgvBookingDetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Passenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passenger";
            this.Load += new System.EventHandler(this.Passenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvBookingDetails;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button BookBtn;
    }
}