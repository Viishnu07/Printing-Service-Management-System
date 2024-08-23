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

namespace IOOP1
{
    public partial class WorkRequest : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Payment;Integrated Security=True");
        private Request request;
        public WorkRequest(Request request)
        {
            InitializeComponent();
            this.request = request;
            InitializeForm();
        }

        private void InitializeForm()
        {
            txtReceiptID.Text = this.request.ReceiptID.ToString();
            txtServicetype.Text = this.request.ServiceType;
            txtFees.Text = this.request.Fees.ToString();
            txtQuantity.Text = this.request.Quantity.ToString();
            checkBoxUrgent.Checked = this.request.UrgentRequest;
            txtCustomerID.Text = this.request.CustomerID.ToString();
            cbStatus.Text = this.request.Status;

        }

        private void WorkRequest_Load(object sender, EventArgs e)
        {
            cbStatus.Items.Add("Work in Progress");
            cbStatus.Items.Add("Completed");

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex <0)
            {
                MessageBox.Show("Please choose a Status.");
                return;
            }

            SqlCommand cmd = new SqlCommand
                (
                "UPDATE [Payment] SET [Status] = @Status WHERE [ReceiptID]=@ReceiptID" 
                ,conn
                );

            cmd.Parameters.AddWithValue("@Status", cbStatus.Text);
            cmd.Parameters.AddWithValue("@ReceiptID", txtReceiptID.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Status Updated");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
