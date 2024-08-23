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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void LoadUserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedUserId = GetUserSelectedId(); // Get the user's selected ID.

            if (selectedUserId > 0)
            {
                LoadUserData(selectedUserId);
            }
        }

        private int GetUserSelectedId()
        {
            // Extract the selected user's ID from the ComboBox item.
            if (UserComboBox.SelectedIndex >= 0)
            {
                if (int.TryParse(UserComboBox.SelectedItem.ToString(), out int selectedUserId))
                {
                    return selectedUserId;
                }
            }
            return -1; // Return -1 for no selection or parsing error.
        }

        private void LoadUsersIntoComboBox()
        {
            UserComboBox.Items.Clear(); // Clear existing items to avoid duplicates.

            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=LoginInfo;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT UserID, UserName FROM LoginInfo", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Populate the ComboBox with user IDs as text.
                            string userName = reader["UserName"].ToString();
                            UserComboBox.Items.Add(reader["UserID"].ToString());
                        }
                    }
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Delete the user's account from the database.
            int selectedUserId = GetUserSelectedId();

            if (selectedUserId <= 0)
            {
                MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=LoginInfo;Integrated Security=True"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM LoginInfo WHERE UserID = @UserId", con))
                        {
                            cmd.Parameters.AddWithValue("@UserId", selectedUserId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User account deleted successfully.");
                                LoadUsersIntoComboBox(); // Reload ComboBox items after deletion.
                                ClearUserData(); // Clear user data from labels and textboxes.
                            }
                            else
                            {
                                MessageBox.Show("User deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Update the user's information in the database.
            int selectedUserId = GetUserSelectedId();

            if (selectedUserId <= 0)
            {
                MessageBox.Show("Please select a user to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newUserName = UserNameTextBox.Text;
            string newUserPassword = UserPasswordTextBox.Text;
            string newUserRole = UserRoleComboBox.SelectedItem?.ToString() ?? ""; // Ensure selected item is not null.
            string newPhoneNumber = PhoneNumberTextBox.Text;

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=LoginInfo;Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE LoginInfo SET UserName = @UserName, UserPassword = @UserPassword, UserRole = @UserRole, PhoneNumber = @PhoneNumber WHERE UserID = @UserId", con))
                    {
                        cmd.Parameters.AddWithValue("@UserId", selectedUserId);
                        cmd.Parameters.AddWithValue("@UserName", newUserName);
                        cmd.Parameters.AddWithValue("@UserPassword", newUserPassword);
                        cmd.Parameters.AddWithValue("@UserRole", newUserRole);
                        cmd.Parameters.AddWithValue("@PhoneNumber", newPhoneNumber);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User information updated successfully.");
                            LoadUserData(selectedUserId); // Reload user data after updating.
                        }
                        else
                        {
                            MessageBox.Show("User information update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearUserData()
        {
            // Clear user data from labels and textboxes.
            UserNameLabel.Text = "Username: ";
            UserPasswordLabel.Text = "Password: ";
            UserRoleLabel.Text = "Role: ";
            PhoneNumberLabel.Text = "Phone Number: ";

            UserNameTextBox.Clear();
            UserPasswordTextBox.Clear();
            PhoneNumberTextBox.Clear();
        }


        private void UpdateUser_Load(object sender, EventArgs e)
        {
            LoadUsersIntoComboBox();
        }

        private void LoadUserData(int userId)
        {
            // Retrieve the user's data from the database and display it in the GroupBox's textboxes.
            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=LoginInfo;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT UserName, UserPassword, UserRole, PhoneNumber FROM LoginInfo WHERE UserID = @UserId", con))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UserNameLabel.Text = "Username: " + reader.GetString(0);
                            UserPasswordLabel.Text = "Password: " + reader.GetString(1);
                            UserRoleLabel.Text = "Role: " + reader.GetString(2);
                            PhoneNumberLabel.Text = "Phone Number: " + reader.GetString(3);

                            // Set the selected role in the ComboBox.
                            string userRole = reader["UserRole"].ToString();
                            UserRoleComboBox.SelectedItem = userRole;

                            UserNameTextBox.Text = reader["UserName"].ToString();          
                            UserPasswordTextBox.Text = reader["UserPassword"].ToString();
                            PhoneNumberTextBox.Text = reader["PhoneNumber"].ToString();
                        }
                    }
                }
            }
        }

    }
}

