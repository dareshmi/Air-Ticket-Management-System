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
    public partial class EmployeeRecord : Form
    {
        private readonly string connectionString = DatabaseConfig.ConnectionString;

        public EmployeeRecord()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) => Application.Exit();
        }

        private void EmployeeRecord_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void ClearFields()
        {
            EmployeeIDField.Clear();
            EmployeeName.Clear();
            PasswordField.Clear();
            NationalityField.Clear();
            PhoneNumField.Clear();
            GenderField.Clear();
        }

        private void LoadEmployees()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT EmployeeID, EmployeeName, Password, Nationality, PhoneNum, Gender FROM Employee";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewEmployees.DataSource = dt;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RecordBtn_Click(object sender, EventArgs e)
        {
            string empID = EmployeeIDField.Text.Trim();
            string empName = EmployeeName.Text.Trim();
            string empPass = PasswordField.Text.Trim();
            string empNationality = NationalityField.Text.Trim();
            string empPhone = PhoneNumField.Text.Trim();
            string empGender = GenderField.Text.Trim();

            // Check if any field is empty, including EmployeeID
            if (string.IsNullOrWhiteSpace(empID) || string.IsNullOrWhiteSpace(empName) || string.IsNullOrWhiteSpace(empPass) ||
                string.IsNullOrWhiteSpace(empNationality) || string.IsNullOrWhiteSpace(empPhone) ||
                string.IsNullOrWhiteSpace(empGender))
            {
                MessageBox.Show("Please fill in all fields!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query matches all 6 columns perfectly
                    string insertQuery = "INSERT INTO Employee (EmployeeID, EmployeeName, Password, Nationality, Gender, PhoneNum) VALUES (@EmployeeID, @EmployeeName, @Password, @Nationality, @Gender, @PhoneNum)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@EmployeeID", empID);
                        insertCmd.Parameters.AddWithValue("@EmployeeName", empName);
                        insertCmd.Parameters.AddWithValue("@Password", empPass);
                        insertCmd.Parameters.AddWithValue("@Nationality", empNationality);
                        insertCmd.Parameters.AddWithValue("@Gender", empGender);
                        insertCmd.Parameters.AddWithValue("@PhoneNum", empPhone);

                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            LoadEmployees();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string employeeID = EmployeeIDField.Text.Trim();

            // Validate Employee ID
            if (string.IsNullOrWhiteSpace(employeeID))
            {
                MessageBox.Show("Please enter an Employee ID!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
                                LoadEmployees();
                            }
                            else
                            {
                                MessageBox.Show("No Employee found with this ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }
    }
}