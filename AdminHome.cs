using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Ticket_Management_System
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) =>
            {
                    Application.Exit();
            };
            this.Size = new Size(800, 530);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void AddFlightDetailBtn_Click(object sender, EventArgs e)
        {
            AddFlightRecords addFlightForm = new AddFlightRecords();
            addFlightForm.Show();
            this.Hide();
        }

        private void ViewFlightTableBtn_Click(object sender, EventArgs e)
        {
            ViewFlightTable viewflighttableForm = new ViewFlightTable();
            viewflighttableForm.Show();
            this.Hide();
        }

        private void EmployeeRecordBtn_Click(object sender, EventArgs e)
        {
            EmployeeRecord employeerecordForm = new EmployeeRecord();
            employeerecordForm.Show();
            this.Hide();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }
    }
}
