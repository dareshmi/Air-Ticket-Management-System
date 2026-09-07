using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Ticket_Management_System
{
    public partial class Passenger : Form
    {
        private readonly string connectionString = DatabaseConfig.ConnectionString;

        public Passenger()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) => { Application.Exit(); };
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Get the TicketID entered by the user
            string ticketID = textBoxSearch.Text;

            if (string.IsNullOrWhiteSpace(ticketID))
            {
                MessageBox.Show("Please enter a TicketID.");
                return;
            }

            // Call method to search the booking and load it into the DataGridView
            SearchBookingByTicketID(ticketID);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void BookBtn_Click(object sender, EventArgs e)
        {
            BookingForPassenger booking = new BookingForPassenger();
            booking.Show();
            this.Hide();
        }

        // This method searches for a booking by TicketID and shows the details in the DataGridView
        private void SearchBookingByTicketID(string ticketID)
        {
            // SQL query to get booking details by TicketID
            string query = "SELECT * FROM Booking WHERE BookingID = @TicketID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@TicketID", ticketID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                // Check if any results are returned
                if (dt.Rows.Count > 0)
                {
                    dgvBookingDetails.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No booking found with the provided TicketID.");
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Passenger_Load(object sender, EventArgs e)
        {

        }
    }
}