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
    public partial class BookingForPassenger : Form
    {
        private readonly string connectionString = DatabaseConfig.ConnectionString;

        public BookingForPassenger()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) => Application.Exit();
        }

        // Refresh Datagridview table
        private void BookingForPassenger_Load(object sender, EventArgs e)
        {
            LoadFlightRecords();
            LoadBookingRecords();
        }

        private void LoadFlightRecords()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FlightRecords", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Reset DataSource and bind the data
                    dgvFlightRecords.DataSource = null; // Reset DataSource to prevent binding issues
                    dgvFlightRecords.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading flight records: {ex.Message}");
                }
            }
        }

        private void LoadBookingRecords()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Booking", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Reset DataSource and bind the data
                    dgvBooking.DataSource = null; // Reset DataSource to prevent binding issues
                    dgvBooking.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading booking records: {ex.Message}");
                }
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dgvFlightRecords.SelectedRows.Count > 0)
            {
                try
                {
                    // Get selected flight information
                    var selectedRow = dgvFlightRecords.SelectedRows[0];
                    string flightCode = selectedRow.Cells["FlightCode"].Value.ToString();
                    int passengerid = int.Parse(PassangerIDField.Text);
                    string name = NameField.Text;
                    string email = EmailField.Text;
                    string passportNumber = PassportNumField.Text;
                    string nationality = NationalityField.Text;
                    decimal flightPrice = 0;

       

                    // Add 100,000 to the flight price
                    decimal finalAmount = 100000;

                    // Begin a transaction to ensure both operations succeed or fail together
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            // Insert booking into the database
                            SqlCommand cmd = new SqlCommand("INSERT INTO Booking (FlightCode, PassengerID, Name, Email, PassportNum, Nationality, Amount) VALUES (@FlightCode, @PassengerID, @Name, @Email, @PassportNum, @Nationality, @Amount)", conn, transaction);
                            cmd.Parameters.AddWithValue("@FlightCode", flightCode);
                            cmd.Parameters.AddWithValue("@PassengerID", passengerid);
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@PassportNum", passportNumber);
                            cmd.Parameters.AddWithValue("@Nationality", nationality);
                            cmd.Parameters.AddWithValue("@Amount", finalAmount);

                            cmd.ExecuteNonQuery();

                            // Update available seats in the FlightRecords table
                            SqlCommand updateSeatsCmd = new SqlCommand("UPDATE FlightRecords SET Seats = Seats - 1 WHERE FlightCode = @FlightCode AND Seats > 0", conn, transaction);
                            updateSeatsCmd.Parameters.AddWithValue("@FlightCode", flightCode);

                            int rowsAffected = updateSeatsCmd.ExecuteNonQuery();

                            // If no rows were affected, it means there are no seats left
                            if (rowsAffected == 0)
                            {
                                transaction.Rollback();
                                MessageBox.Show("No available seats left for this flight.");
                            }
                            else
                            {
                                // Commit transaction if both operations succeeded
                                transaction.Commit();
                                MessageBox.Show("Flight booked successfully!");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Rollback transaction if an error occurs
                            transaction.Rollback();
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                        finally
                        {
                            conn.Close();
                        }

                    }

                    // Refresh the Booking DataGridView
                    LoadBookingRecords();
                    // Refresh the Flight DataGridView
                    LoadFlightRecords();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a flight to book.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Passenger passsengerform = new Passenger();
            passsengerform.Show();
            this.Hide();
        }


    }
}
