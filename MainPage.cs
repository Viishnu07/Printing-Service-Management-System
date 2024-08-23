using Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer
{
    public partial class Customer : Form
    {
        private string userID;

       
        public Customer(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        public Customer()
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btn_check_Click(object sender, EventArgs e)
        {
            int bw = (int)updw_PrintingBW.Value;
            int c = (int)updw_PrintingC.Value;
            int cb = (int)updw_BindingCB.Value;
            int tc = (int)updw_BindingTC.Value;
            int p = (int)updw_Poster.Value;
            int b = (int)updw_Banner.Value;

            if (updw_PrintingBW.Text == "")
                bw = 0;
            if (updw_BindingCB.Text == "")
                cb = 0;
            if (updw_PrintingC.Text == "")
                c = 0;
            if (updw_BindingTC.Text == "")
                tc = 0;
            if(updw_Poster.Text == "")
                p = 0;
            if(updw_Banner.Text == "")
                b = 0;         
            
            if(bw == 0 && cb == 0 && c == 0 && tc == 0 && p == 0 && b == 0)
            {
                MessageBox.Show("Please input quantity");
                return;
            }

            Count count = new Count(bw,c,cb,tc,p,b);
            int i = count.Detail();
            string[] servicetype = count.ServiceType;
            double[] fees = count.Fees;
            int[] quantity = count.Qauntity;
            double[] subtotal = count.Subtotal;
            string _Ur = cb_UrgentRequests.Checked.ToString();

           

            Payment form2 = new Payment(i, servicetype, fees, quantity, subtotal, _Ur);
            this.Hide();
            form2.Show();          
        }

        private void btn_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
            Login Login2 = new Login();
            Login2.Show();
        }

        private void btn_REQUEST_Click(object sender, EventArgs e)
        {
            Record form4 = new Record(userID);
            this.Hide();
            form4.Show();
        }
    }
}
