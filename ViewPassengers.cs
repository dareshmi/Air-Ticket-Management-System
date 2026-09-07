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
    public partial class ViewPassengers : Form
    {
        private readonly string connectionString = DatabaseConfig.ConnectionString;

        public ViewPassengers()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) => { Application.Exit(); };
        }

        private void ViewPassengers_Load_1(object sender, EventArgs e)
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
                    string query = "SELECT * FROM Passenger";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    using (SqlDataAdapter sd = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PassengerIDField.Text) ||
                string.IsNullOrWhiteSpace(passportnum.Text) ||
                string.IsNullOrWhiteSpace(PassengerEmailField.Text) ||
                string.IsNullOrWhiteSpace(PasswordField.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(PassengerIDField.Text, out int passengerID))
            {
                MessageBox.Show("Invalid Passenger ID. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Passenger SET PassportNum=@PassportNum, PassengerEmail=@PassengerEmail, Password=@Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PassengerID", passengerID);
                        cmd.Parameters.AddWithValue("@PassportNum", passportnum.Text.Trim());
                        cmd.Parameters.AddWithValue("@PassengerEmail", PassengerEmailField.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", PasswordField.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Passenger record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BindData();
                        }
                        else
                        {
                            MessageBox.Show("Passenger ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            PassengerIDField.Clear();
            passportnum.Clear();
            PassengerEmailField.Clear();
            PasswordField.Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PassengerIDField.Text))
            {
                MessageBox.Show("Please enter a Passenger ID to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(PassengerIDField.Text, out int passengerID))
            {
                MessageBox.Show("Invalid Passenger ID. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this passenger?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Passenger WHERE PassengerID=@PassengerID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@PassengerID", passengerID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Passenger record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                PassengerIDField.Clear();
                                BindData();
                            }
                            else
                            {
                                MessageBox.Show("Passenger ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            EmployeeHome employeeHome = new EmployeeHome();
            employeeHome.Show();
            this.Hide();
        }


    }
}
