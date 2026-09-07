namespace Air_Ticket_Management_System
{
    partial class AddFlightRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFlightRecords));
            this.label3 = new System.Windows.Forms.Label();
            this.FlightCodeField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumOfSeat = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ToField = new System.Windows.Forms.TextBox();
            this.FromField = new System.Windows.Forms.TextBox();
            this.TakeofDate = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.RecordBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(320, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Record New Flights";
            // 
            // FlightCodeField
            // 
            this.FlightCodeField.Location = new System.Drawing.Point(251, 146);
            this.FlightCodeField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FlightCodeField.Multiline = true;
            this.FlightCodeField.Name = "FlightCodeField";
            this.FlightCodeField.Size = new System.Drawing.Size(133, 27);
            this.FlightCodeField.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Flight Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(493, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "Num Of Seats";
            // 
            // NumOfSeat
            // 
            this.NumOfSeat.Location = new System.Drawing.Point(664, 270);
            this.NumOfSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumOfSeat.Multiline = true;
            this.NumOfSeat.Name = "NumOfSeat";
            this.NumOfSeat.Size = new System.Drawing.Size(155, 26);
            this.NumOfSeat.TabIndex = 9;
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.DarkViolet;
            this.ResetBtn.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ResetBtn.Location = new System.Drawing.Point(433, 359);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(104, 36);
            this.ResetBtn.TabIndex = 14;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "TakeofDate";
            // 
            // ToField
            // 
            this.ToField.Location = new System.Drawing.Point(251, 273);
            this.ToField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ToField.Multiline = true;
            this.ToField.Name = "ToField";
            this.ToField.Size = new System.Drawing.Size(133, 27);
            this.ToField.TabIndex = 16;
            // 
            // FromField
            // 
            this.FromField.Location = new System.Drawing.Point(251, 209);
            this.FromField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromField.Multiline = true;
            this.FromField.Name = "FromField";
            this.FromField.Size = new System.Drawing.Size(133, 27);
            this.FromField.TabIndex = 17;
            // 
            // TakeofDate
            // 
            this.TakeofDate.Location = new System.Drawing.Point(651, 145);
            this.TakeofDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TakeofDate.Multiline = true;
            this.TakeofDate.Name = "TakeofDate";
            this.TakeofDate.Size = new System.Drawing.Size(168, 27);
            this.TakeofDate.TabIndex = 18;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.BackBtn.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackBtn.Location = new System.Drawing.Point(567, 358);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(104, 36);
            this.BackBtn.TabIndex = 19;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RecordBtn
            // 
            this.RecordBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.RecordBtn.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RecordBtn.Location = new System.Drawing.Point(309, 359);
            this.RecordBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecordBtn.Name = "RecordBtn";
            this.RecordBtn.Size = new System.Drawing.Size(104, 36);
            this.RecordBtn.TabIndex = 13;
            this.RecordBtn.Text = "Record";
            this.RecordBtn.UseVisualStyleBackColor = false;
            this.RecordBtn.Click += new System.EventHandler(this.RecordBtn_Click);
            // 
            // AddFlightRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(925, 514);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.TakeofDate);
            this.Controls.Add(this.FromField);
            this.Controls.Add(this.ToField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.RecordBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumOfSeat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FlightCodeField);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddFlightRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FlightCodeField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NumOfSeat;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ToField;
        private System.Windows.Forms.TextBox FromField;
        private System.Windows.Forms.TextBox TakeofDate;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button RecordBtn;
    }
}