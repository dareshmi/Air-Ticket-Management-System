namespace Air_Ticket_Management_System
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.AddFlightDetailBtn = new System.Windows.Forms.Button();
            this.ViewFlightTableBtn = new System.Windows.Forms.Button();
            this.EmployeeRecordBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddFlightDetailBtn
            // 
            this.AddFlightDetailBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.AddFlightDetailBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFlightDetailBtn.Location = new System.Drawing.Point(5, 303);
            this.AddFlightDetailBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddFlightDetailBtn.Name = "AddFlightDetailBtn";
            this.AddFlightDetailBtn.Size = new System.Drawing.Size(151, 55);
            this.AddFlightDetailBtn.TabIndex = 0;
            this.AddFlightDetailBtn.Text = "Add Filght Details";
            this.AddFlightDetailBtn.UseVisualStyleBackColor = false;
            this.AddFlightDetailBtn.Click += new System.EventHandler(this.AddFlightDetailBtn_Click);
            // 
            // ViewFlightTableBtn
            // 
            this.ViewFlightTableBtn.BackColor = System.Drawing.Color.Aquamarine;
            this.ViewFlightTableBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewFlightTableBtn.Location = new System.Drawing.Point(4, 198);
            this.ViewFlightTableBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewFlightTableBtn.Name = "ViewFlightTableBtn";
            this.ViewFlightTableBtn.Size = new System.Drawing.Size(151, 55);
            this.ViewFlightTableBtn.TabIndex = 1;
            this.ViewFlightTableBtn.Text = "View Flight Table";
            this.ViewFlightTableBtn.UseVisualStyleBackColor = false;
            this.ViewFlightTableBtn.Click += new System.EventHandler(this.ViewFlightTableBtn_Click);
            // 
            // EmployeeRecordBtn
            // 
            this.EmployeeRecordBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.EmployeeRecordBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeRecordBtn.Location = new System.Drawing.Point(12, 116);
            this.EmployeeRecordBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeRecordBtn.Name = "EmployeeRecordBtn";
            this.EmployeeRecordBtn.Size = new System.Drawing.Size(140, 55);
            this.EmployeeRecordBtn.TabIndex = 2;
            this.EmployeeRecordBtn.Text = "Employee Record";
            this.EmployeeRecordBtn.UseVisualStyleBackColor = false;
            this.EmployeeRecordBtn.Click += new System.EventHandler(this.EmployeeRecordBtn_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(678, 479);
            this.Controls.Add(this.EmployeeRecordBtn);
            this.Controls.Add(this.ViewFlightTableBtn);
            this.Controls.Add(this.AddFlightDetailBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 530);
            this.MinimumSize = new System.Drawing.Size(700, 530);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Home Page";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddFlightDetailBtn;
        private System.Windows.Forms.Button ViewFlightTableBtn;
        private System.Windows.Forms.Button EmployeeRecordBtn;
    }
}