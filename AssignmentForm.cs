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

namespace ASS
{
    public partial class AssignmentForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=LoginInfo;Integrated Security=True");
        public AssignmentForm(Customer customer)
        {
            InitializeComponent();

            // Populate worker names from the "LoginInfo" table
            PopulateWorkerNames();
            SetSelectedWorker(customer.CustomerID);

            // Set textboxes not editable
            txtCustomerID.ReadOnly = true;
            txtReceiptID.ReadOnly = true;
            txtService.ReadOnly = true;
            txtQuantity.ReadOnly = true;
            cbUrgent.Enabled = false; // Make checkbox not clickable
            txtDate.ReadOnly = true;
            txtStatus.ReadOnly = true;


            txtCustomerID.Text = customer.CustomerID;
            txtReceiptID.Text = customer.ReceiptID;
            txtService.Text = customer.ServiceType;
            txtQuantity.Text = customer.Quantity.ToString();
            cbUrgent.Checked = customer.UrgentRequest;
            txtDate.Text = customer.RequestDate.ToString("dd/MM/yyyy");
            txtStatus.Text = customer.Status;


            if (customer.Status == "New")
            {
                cbAssign.Enabled = true;
                btnAssign.Visible = true;
            }
            else
            {
                lblAssign.Visible = false;
                cbAssign.Visible = false;
                btnAssign.Visible = false;
            }


        }
        private void PopulateWorkerNames()
        {
            try
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT UserID FROM LoginInfo WHERE UserRole = 'Worker'", conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string workerName = reader["UserID"].ToString();
                        cbAssign.Items.Add(workerName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {

            try
            {
                // Check if an item is selected in the ComboBox
                if (cbAssign.SelectedItem == null)
                {
                    MessageBox.Show("Please select a worker from the list.", "Worker Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if no worker is selected
                }

                // Get the selected user's "UserID"
                string selectedUserID = cbAssign.SelectedItem.ToString();

                // Update the "WorkerName" field in the Payment table with the selected "UserID"
                SqlCommand cmd = new SqlCommand("UPDATE [Payment].[dbo].[payment] SET [WorkerID] = @WorkerID WHERE [ReceiptID] = @ReceiptID", conn);
                cmd.Parameters.AddWithValue("@WorkerID", selectedUserID);
                cmd.Parameters.AddWithValue("@ReceiptID", txtReceiptID.Text);


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Work Assigned Successfully");
            }
            catch (Exception ex)
            {
                // Handle any exception that may occur
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SetSelectedWorker(string workerName)
        {
            int selectedIndex = cbAssign.FindString(workerName);
            if (selectedIndex != -1)
            {
                cbAssign.SelectedIndex = selectedIndex;
            }

        }

        private void cbAssign_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AssignmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
