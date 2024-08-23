using Admin;
using MasterCopy1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer
{
    public partial class Payment : Form
    {
        int i;
        string[] servicetype;
        double[] fees;
        int[] quantity;
        double[] subtotal;
        string UR;
        string TOTAL;
        string UR_number;
        string id;


        public Payment(int _i, string[] _servicetype, double[] _fees, int[] _quantity, double[] _subtotal, string _ur)
        {
            InitializeComponent();
            i = _i;
            servicetype = _servicetype;
            fees = _fees;
            quantity = _quantity;
            subtotal = _subtotal;
            UR = _ur;
            id = Globals.GlobalUserID;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            for (int j=0;j<i;j++)
            {
                ListViewItem item = new ListViewItem();
                int r = j + 1;
                item.Text = r.ToString();
                item.SubItems.Add(servicetype[j]);
                item.SubItems.Add(fees[j].ToString());
                item.SubItems.Add(quantity[j].ToString());
                item.SubItems.Add(subtotal[j].ToString());
                listView1.Items.Add(item);
            }

            Count count = new Count();
            (double ur, double total) = count.Calculate2(i, subtotal, UR);
            UR_number = "Urgent Request Charges: RM " + ur.ToString();
            TOTAL = "Total: RM " + total.ToString();
            lb_UR.Text = UR_number;
            lb_TOTAL.Text = TOTAL;
        }

        private void btn_CP_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Payment;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into payment (ReceiptID,Servicetype,Fees,Quantity,Subtotal,[Date],UrgentRequest,PaymentMethod,CustomerID,[Status])" + "values (@receiptid,@servicetype,@fees,@quantity,@subtotal,@date,@urgentrequest,@paymentmethod,@customerid,@status)", conn);
            conn.Open();

            Random random = new Random();
            int receipt = random.Next(100000, 999999);
            DateTime currentDate = DateTime.Now;

            
            string s = "New";

            string method;
            if (radioButton1.Checked)
                method = "TNG";
            else if (radioButton2.Checked)
                method = "Credit/Debit Card";
            else if (radioButton3.Checked)
                method = "Online Banking";
            else
            {
                MessageBox.Show("Plaese select payment method!");
                return;
            }

            for (int j=0;j<i;j++)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@receiptid", receipt);
                cmd.Parameters.AddWithValue("@servicetype", servicetype[j]);
                cmd.Parameters.AddWithValue("@fees", fees[j]);
                cmd.Parameters.AddWithValue("@quantity", quantity[j]);
                cmd.Parameters.AddWithValue("@subtotal", subtotal[j]);
                cmd.Parameters.AddWithValue("@date", currentDate);
                cmd.Parameters.AddWithValue("@paymentmethod", method);
                cmd.Parameters.AddWithValue("@urgentrequest", UR);
                cmd.Parameters.AddWithValue("@customerid", id);
                cmd.Parameters.AddWithValue("@status", s);
                cmd.ExecuteNonQuery();
            }
            conn.Close();

            Receipt form3 = new Receipt(i,servicetype,fees,quantity,UR_number,TOTAL,receipt);
            this.Close();
            form3.ShowDialog();
        }

        private void btn_BACK_Click(object sender, EventArgs e)
        {
            // Try to cast to Customer.Customer
            Customer mainForm = Application.OpenForms.OfType<Customer>().FirstOrDefault();

            if (mainForm != null)
            {
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Main form not found or not of type Customer.Customer!");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
