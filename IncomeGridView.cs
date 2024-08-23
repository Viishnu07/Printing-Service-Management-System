using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace MasterCopy3
{
    public partial class IncomeGridView : Form
    {
        public IncomeGridView(DataTable gridViewData)
        {
            InitializeComponent();
            UpdateDataGridView(gridViewData);
        }
        public void UpdateDataGridView(DataTable gridViewData)
        {
            dataGridView1.DataSource = gridViewData;
        }

        private void IncomeGridView_Load(object sender, EventArgs e)
        {

        }
    }
}
