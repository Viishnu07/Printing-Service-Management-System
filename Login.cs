using ASS;
using Customer;
using IOOP1;
using MasterCopy1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    
    public partial class Login : Form
    {
        string UserID;
        public Login()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = UserTextBox.Text;
            string password = PasswordTextBox.Text;

            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=LoginInfo;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT UserRole, UserID FROM [LoginInfo] WHERE [UserName] = @UserName AND [UserPassword] = @Password", con))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader["UserRole"].ToString();
                            UserID = reader["UserID"].ToString();

                            if (role == "Admin")
                            {
                                // Show Admin Menu form
                                Admin admin = new Admin();
                                admin.ShowDialog();
                                this.Hide();

                            }
                            else if (role == "Student")
                            {
                                Globals.GlobalUserID = UserID;
                                Customer.Customer New = new Customer.Customer(UserID);
                                this.Hide();
                                New.Show();
                            }
                            else if (role == "Worker") 
                            { 
                                MainPage New1 = new MainPage(UserID);
                                New1.Show();
                                this.Hide();
                            }
                            else if (role == "Manager") 
                            {
                                CustomerDataForm New2 = new CustomerDataForm();
                                New2.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid user role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*';
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
