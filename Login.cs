using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Air_Ticket_Management_System
{
    public partial class Login : Form
    {
        private readonly string connectionString = DatabaseConfig.ConnectionString;
        public Login()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) =>
            {
                Application.Exit();
            };
        }
        
        private void Register_Click(object sender, EventArgs e)
        {
            RegisterPanel.Visible = true;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passportnum.Text) || string.IsNullOrWhiteSpace(EmailField.Text) || string.IsNullOrWhiteSpace(PasswordField.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Passenger (PassportNum, PassengerEmail, Password) VALUES (@PassportNum, @PassengerEmail, @Password)", conn);
            cmd.Parameters.AddWithValue("@PassportNum", (passportnum.Text));
            cmd.Parameters.AddWithValue("@PassengerEmail", (EmailField.Text));
            cmd.Parameters.AddWithValue("@Password", (PasswordField.Text));
            cmd.ExecuteNonQuery();

            conn.Close();
            passportnum.Clear();
            EmailField.Clear();
            PasswordField.Clear();
            RegisterPanel.Visible = false;
            MessageBox.Show("Passenger Added Successfully");

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(userInput) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your Username/ID and Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Admin Login
            if (userInput == "admin" && password == "admin")
            {
                AdminHome adminHome = new AdminHome();
                this.Hide();
                adminHome.Show();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if input is a number (for Employee ID)
                    bool isNumeric = int.TryParse(userInput, out int userId);

                    if (isNumeric)
                    {
                        // **Employee Login - Must use ID**
                        string empQuery = "SELECT EmployeeID FROM Employee WHERE EmployeeID = @EmployeeID AND Password = @Password";
                        using (SqlCommand empCmd = new SqlCommand(empQuery, conn))
                        {
                            empCmd.Parameters.AddWithValue("@EmployeeID", userId);
                            empCmd.Parameters.AddWithValue("@Password", password);

                            object empResult = empCmd.ExecuteScalar();

                            if (empResult != null)
                            {
                                EmployeeHome employeeHome = new EmployeeHome();
                                this.Hide();
                                employeeHome.Show();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Invalid Employee ID or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    else
                    {
                        // **Passenger Login - Must use Email**
                        string custEmailQuery = "SELECT PassengerEmail FROM Passenger WHERE PassengerEmail = @PassengerEmail AND Password = @Password";
                        using (SqlCommand custCmd = new SqlCommand(custEmailQuery, conn))
                        {
                            custCmd.Parameters.AddWithValue("@PassengerEmail", userInput);
                            custCmd.Parameters.AddWithValue("@Password", password);

                            object custResult = custCmd.ExecuteScalar();

                            if (custResult != null)
                            {
                                Passenger customer = new Passenger();
                                this.Hide();
                                customer.Show();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Invalid Passenger Email or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
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
