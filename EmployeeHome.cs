using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Ticket_Management_System
{
    public partial class EmployeeHome : Form
    {
        public EmployeeHome()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) =>
            {
                Application.Exit();
            };
        }

        private void ViewPassengerBtn_Click(object sender, EventArgs e)
        {
            ViewPassengers viewpassengerForm = new ViewPassengers();
            viewpassengerForm.Show();
            this.Hide();
        }

        private void BookingBtn_Click(object sender, EventArgs e)
        {
            Booking bookingForm = new Booking();
            bookingForm.Show();
            this.Hide();
        }
    }
}
