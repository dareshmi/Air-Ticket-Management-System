using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Air_Ticket_Management_System
{
    public partial class ViewFlightTable : Form
    {
        private readonly string connectionString = DatabaseConfig.ConnectionString;

        public ViewFlightTable()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) => Application.Exit();
        }
        private void ViewTable_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FlightRecords", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int numOfSeat = (int)numericUpDownSeats.Value;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE FlightRecords SET Source = @From, Destination = @To, TakeoffDate = @TakeOfDate, Seats = @NumOfSeat WHERE FlightCode = @Flightcode";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Flightcode", textBox1.Text);
                        cmd.Parameters.AddWithValue("@From", textBox5.Text);
                        cmd.Parameters.AddWithValue("@To", textBox3.Text);
                        cmd.Parameters.AddWithValue("@TakeOfDate", textBox2.Text);
                        cmd.Parameters.AddWithValue("@NumOfSeat", numOfSeat);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Flight Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            BindData();
                        }
                        else
                        {
                            MessageBox.Show("Flight Code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a Flight Code to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM FlightRecords WHERE FlightCode = @Flightcode";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Flightcode", textBox1.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Flight Record Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            BindData();
                        }
                        else
                        {
                            MessageBox.Show("Flight Code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
            BindData();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }
    }
}