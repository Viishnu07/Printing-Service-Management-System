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

namespace Admin
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }
        public string Username
        {
            get { return UserRegTextBox.Text; }
        }

        public string Password
        {
            get { return UserRegPasswordBox.Text; }
        }

        public string SelectedRole
        {
            get { return RegUserBox.SelectedItem.ToString(); }
        }

        public int UserID
        {
            get { return int.Parse(RegUserIDLabel.Text); }
        }

        public int PhoneNumber
        {
            get { return int.Parse(PhoneBox.Text); }
        }
        private void NewUser_Load(object sender, EventArgs e)
        {
            int randomUserID = GenerateRandomUserID();
            RegUserIDLabel.Text = randomUserID.ToString("D6"); // Display as 6-digit with leading zeros

            // Set PasswordChar to '*' to display password as asterisks
            UserRegPasswordBox.PasswordChar = '*';

        }
        private int GenerateRandomUserID()
        {
            // Generate a random 5-digit UserID
            Random random = new Random();
            return random.Next(100000, 999999); // Generate a random number between 100000 and 999999
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            string username = Username.Trim();
            string phoneNumberText = PhoneBox.Text.Trim();

            //error validation
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password) || RegUserBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else if (!IsValidUsername(username))
            {
                MessageBox.Show("Username can only contain letters.");
            }
            else if (!IsValidPhoneNumber(phoneNumberText))
            {
                MessageBox.Show("Phone number must be at least 8 digits.");
            }
            else
            {
                int phoneNumber = int.Parse(phoneNumberText);


                using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=LoginInfo;Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO LoginInfo (UserName, UserPassword, UserRole, UserID, PhoneNumber) VALUES (@UserName, @UserPassword, @UserRole, @UserID, @PhoneNumber)", con))
                    {
                        cmd.Parameters.AddWithValue("@UserName", Username);
                        cmd.Parameters.AddWithValue("@UserPassword", Password);
                        cmd.Parameters.AddWithValue("@UserRole", SelectedRole);
                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        cmd.ExecuteNonQuery();
                    }
                }
                DialogResult = DialogResult.OK;
                Close();


            }
        }

        private bool IsValidUsername(string username)
        {
            return !username.Any(char.IsDigit); // Check if username contains any digits
        }

        private bool IsValidPhoneNumber(string phoneNumberText)
        {
            if (phoneNumberText.Length >= 8 && phoneNumberText.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        private void UserRegPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
