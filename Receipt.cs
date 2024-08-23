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
    public partial class Receipt : Form
    {
        int i;
        string[] servicetype;
        double[] fees;
        int[] quantity;
        string UR;
        string TOTAL;
        int receipt;

        public Receipt(int _i, string[] _servicetype, double[] _fees, int[] _quantity, string _ur, string _total,int _receipt)
        {
            InitializeComponent();
            i = _i;
            servicetype = _servicetype;
            fees = _fees;
            quantity = _quantity;
            UR = _ur;
            TOTAL = _total;
            receipt = _receipt;

        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            lb_RID.Text = receipt.ToString();
            DateTime currentDate = DateTime.Now;
            lb_DATE.Text = currentDate.ToString();

            for (int j = 0; j < i; j++)
            {
                ListViewItem item2 = new ListViewItem();
                int r = j + 1;
                item2.Text = r.ToString();
                item2.SubItems.Add(servicetype[j]);
                item2.SubItems.Add(fees[j].ToString());
                item2.SubItems.Add(quantity[j].ToString());
                listView2.Items.Add(item2);
            }

            lb_UR2.Text = UR;
            lb_TOTAL2.Text = TOTAL;
        }

        private void btn_CLOSE_Click(object sender, EventArgs e)
        {
            Customer form1 = new Customer();
            this.Hide();
            
        }
    }
}
