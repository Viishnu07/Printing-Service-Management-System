using MasterCopy3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Admin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Login Login1 = new Login();
            Login1.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (RegNewRadio.Checked)
            {
                NewUser newUserForm = new NewUser();
                newUserForm.ShowDialog(); 
            }

            else if (UpdateRadio.Checked)
            {
                UpdateUser newUpdateRadio = new UpdateUser();
                newUpdateRadio.ShowDialog();
            }

            else if (RequestRadio.Checked)
            {
               RequestReport radioReport = new RequestReport();
               radioReport.ShowDialog();
            }

            else if (TotalIncomeRadio.Checked) 
            { 
                IncomeReport radioReport1 = new IncomeReport();
                radioReport1.ShowDialog();
            }

            else
            {
                MessageBox.Show("Please select an option before confirming.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void RequestRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TotalIncomeRadio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
