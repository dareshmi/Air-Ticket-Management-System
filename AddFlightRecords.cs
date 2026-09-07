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
    public partial class AddFlightRecords : Form
    {
        private readonly string connectionString = DatabaseConfig.ConnectionString;

        public AddFlightRecords()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) =>
            {
                Application.Exit();
            };
        }

        private void RecordBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FlightCodeField.Text) ||
                string.IsNullOrWhiteSpace(FromField.Text) ||
                string.IsNullOrWhiteSpace(ToField.Text) ||
                string.IsNullOrWhiteSpace(TakeofDate.Text) ||
                string.IsNullOrWhiteSpace(NumOfSeat.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    string query = "INSERT INTO FlightRecords (FlightCode, Source, Destination, TakeoffDate, Seats) VALUES (@Code, @From, @To, @Date, @NumOfSeat)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Code", FlightCodeField.Text.Trim());
                        cmd.Parameters.AddWithValue("@From", FromField.Text.Trim());
                        cmd.Parameters.AddWithValue("@To", ToField.Text.Trim());
                        cmd.Parameters.AddWithValue("@Date", TakeofDate.Text.Trim());
                        cmd.Parameters.AddWithValue("@NumOfSeat", int.Parse(NumOfSeat.Text.Trim()));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Flight Recorded Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FlightCodeField.Clear();
                FromField.Clear();
                ToField.Clear();
                TakeofDate.Clear();
                NumOfSeat.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            FlightCodeField.Clear();
            FromField.Clear();
            ToField.Clear();
            TakeofDate.Clear();
            NumOfSeat.Clear();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }
    }
}