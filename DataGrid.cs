﻿using System;
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
    public partial class DataGrid : Form
    {
        public DataGrid(DataTable data)
        {
            InitializeComponent();
            dataGridView1.DataSource = data;
        }

        private void DataGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
