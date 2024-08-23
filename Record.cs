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

namespace Customer
{
    public partial class Record : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Payment;Integrated Security=True");
        private string userID;

        public Record()
        {
            InitializeComponent();

        }

        public Record(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void Request_Load(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT ReceiptID FROM payment WHERE CustomerID = @userID", conn);
            cmd.Parameters.AddWithValue("@userID", userID); ;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string ID = reader["ReceiptID"].ToString();
                cmb_REQUEST.Items.Add(ID);
            }
            conn.Close();
        }

        private void cmb_REQUEST_SelectedIndexChanged(object sender, EventArgs e)
        {


            string selectedID = cmb_REQUEST.SelectedItem.ToString();

    

            conn.Open();
            SqlCommand cmd = new SqlCommand("select Servicetype,Fees,Quantity,[Date],UrgentRequest,[Status] from payment where ReceiptID=@selectedID /*AND CustomerID=@userID*/", conn);
            cmd.Parameters.AddWithValue("@selectedID", selectedID);
            //cmd.Parameters.AddWithValue("@userID", userID);
            SqlDataReader reader = cmd.ExecuteReader();
            listView3.Items.Clear();
            int i = 0;

            while (reader.Read())
            {
                ListViewItem item3 = new ListViewItem();
                i += 1;
                DateTime dateValue = (DateTime)reader["Date"];
                string formattedDate = dateValue.ToString("dd-MM-yyyy");

                item3.Text = i.ToString();
                item3.SubItems.Add(reader["Servicetype"].ToString());
                item3.SubItems.Add(reader["Fees"].ToString());
                item3.SubItems.Add(reader["Quantity"].ToString());
                item3.SubItems.Add(formattedDate.ToString());
                item3.SubItems.Add(reader["Status"].ToString());
                listView3.Items.Add(item3);
                if (reader.GetBoolean(reader.GetOrdinal("UrgentRequest")))
                    lb_Request_UR.Text = "Urgent Request is chosen";
                else
                    lb_Request_UR.Text = string.Empty;
            }
            conn.Close();
        }


        private void btn_Request_Back_Click(object sender, EventArgs e)
        {
            Customer form1 = Application.OpenForms["Customer"] as Customer;

            if (form1 != null)
            {
                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Error: Unable to find the Customer form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

