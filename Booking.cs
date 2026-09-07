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
    public partial class Booking : Form
    {
        private readonly string connectionString = DatabaseConfig.ConnectionString;
        public Booking()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) => Application.Exit();
        }

        private void Booking_Load_1(object sender, EventArgs e)
        {
            LoadFlightRecords();
            LoadBookingRecords();
        }

        private void LoadFlightRecords()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FlightRecords", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvFlightRecords.DataSource = dt;
            }
        }

        private void LoadBookingRecords()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Booking", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBooking.DataSource = dt;
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dgvFlightRecords.SelectedRows.Count > 0)
            {
                var selectedRow = dgvFlightRecords.SelectedRows[0];
                string flightCode = selectedRow.Cells["FlightCode"].Value.ToString();
                int passengerid = int.Parse(PassangerIDField.Text);
                string name = NameField.Text;
                string email = EmailField.Text;
                string passportNumber = PassportNumField.Text;
                string nationality = NationalityField.Text;
                double amount = double.Parse(AmountField.Text);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Booking (FlightCode, PassengerID, Name, Email, PassportNum, Nationality, Amount) VALUES (@FlightCode, @PassengerID, @Name, @Email, @PassportNum, @Nationality, @Amount)", conn);
                    cmd.Parameters.AddWithValue("@FlightCode", flightCode);
                    cmd.Parameters.AddWithValue("@PassengerID", passengerid);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PassportNum", passportNumber);
                    cmd.Parameters.AddWithValue("@Nationality", nationality);
                    cmd.Parameters.AddWithValue("@Amount", amount);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    SqlCommand updateSeatsCmd = new SqlCommand("UPDATE FlightRecords SET Seats = Seats - 1 WHERE Flightcode = @FlightCode AND Seats > 0", conn);
                    updateSeatsCmd.Parameters.AddWithValue("@FlightCode", flightCode);

                    int rowsAffected = updateSeatsCmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No available seats left for this flight.");
                    }
                    else
                    {
                        MessageBox.Show("Flight booked successfully!");
                    }

                    conn.Close();
                }

                LoadBookingRecords();
                LoadFlightRecords();
            }
            else
            {
                MessageBox.Show("Please select a flight to book.");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (dgvBooking.SelectedRows.Count > 0)
            {
                var selectedRow = dgvBooking.SelectedRows[0];
                int ticketId = Convert.ToInt32(selectedRow.Cells["BookingID"].Value);
                string flightCode = selectedRow.Cells["FlightCode"].Value.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Booking WHERE BookingID = @BookingID", conn);
                    cmd.Parameters.AddWithValue("@BookingID", ticketId);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    SqlCommand updateSeatsCmd = new SqlCommand("UPDATE FlightRecords SET Seats = Seats + 1 WHERE FlightCode = @FlightCode", conn);
                    updateSeatsCmd.Parameters.AddWithValue("@FlightCode", flightCode);

                    updateSeatsCmd.ExecuteNonQuery();

                    conn.Close();
                }

                LoadBookingRecords();
                LoadFlightRecords();

                MessageBox.Show("Booking cancelled and seat availability updated!");
            }
            else
            {
                MessageBox.Show("Please select a booking to cancel.");
            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            EmployeeHome EmployeeForm = new EmployeeHome();
            EmployeeForm.Show();
            this.Hide();
        }
    }
}