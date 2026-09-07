namespace Air_Ticket_Management_System
{
    partial class EmployeeHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeHome));
            this.ViewPassengerBtn = new System.Windows.Forms.Button();
            this.BookingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewPassengerBtn
            // 
            this.ViewPassengerBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.ViewPassengerBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPassengerBtn.Location = new System.Drawing.Point(89, 115);
            this.ViewPassengerBtn.Name = "ViewPassengerBtn";
            this.ViewPassengerBtn.Size = new System.Drawing.Size(129, 74);
            this.ViewPassengerBtn.TabIndex = 1;
            this.ViewPassengerBtn.Text = "View Passenger";
            this.ViewPassengerBtn.UseVisualStyleBackColor = false;
            this.ViewPassengerBtn.Click += new System.EventHandler(this.ViewPassengerBtn_Click);
            // 
            // BookingBtn
            // 
            this.BookingBtn.AutoSize = true;
            this.BookingBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.BookingBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingBtn.Location = new System.Drawing.Point(89, 236);
            this.BookingBtn.MaximumSize = new System.Drawing.Size(129, 74);
            this.BookingBtn.MinimumSize = new System.Drawing.Size(129, 74);
            this.BookingBtn.Name = "BookingBtn";
            this.BookingBtn.Size = new System.Drawing.Size(129, 74);
            this.BookingBtn.TabIndex = 2;
            this.BookingBtn.Text = "Booking";
            this.BookingBtn.UseVisualStyleBackColor = false;
            this.BookingBtn.Click += new System.EventHandler(this.BookingBtn_Click);
            // 
            // EmployeeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(842, 489);
            this.Controls.Add(this.BookingBtn);
            this.Controls.Add(this.ViewPassengerBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(860, 536);
            this.MinimumSize = new System.Drawing.Size(860, 536);
            this.Name = "EmployeeHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ViewPassengerBtn;
        private System.Windows.Forms.Button BookingBtn;
    }
}