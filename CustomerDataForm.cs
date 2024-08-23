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
    public partial class CustomerDataForm : Form
    {
        public CustomerDataForm()
        {
            InitializeComponent();
        }

        private void CustomerDataForm_Load(object sender, EventArgs e)
        {
            // Define your SQL connection string.
            string connectionString = "Data Source=.;Initial Catalog=Payment;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Define your SQL query to retrieve data.
                string query = "SELECT * FROM Payment";

                // Create a SQLDataAdapter to execute the query and fill a DataTable.
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Open the database connection and fill the DataTable.
                connection.Open();
                adapter.Fill(dataTable);
                connection.Close();

                // Bind the DataTable to the DataGridView.
                dataGridView1.DataSource = dataTable;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells[0].Value != null && row.Cells[1].Value != null &&
                    row.Cells[2].Value != null && row.Cells[3].Value != null &&
                    row.Cells[4].Value != null && row.Cells[5].Value != null &&
                    row.Cells[6].Value != null && row.Cells[7].Value != null)
                {
                    Customer customer = new Customer
                    (
                        row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        double.Parse(row.Cells[2].Value.ToString()),
                        int.Parse(row.Cells[3].Value.ToString()),
                        double.Parse(row.Cells[4].Value.ToString()),
                        (DateTime.Parse(row.Cells[5].Value.ToString())).Date,
                        bool.Parse(row.Cells[6].Value.ToString()),
                        row.Cells[7].Value.ToString(),
                        row.Cells[8].Value.ToString()
                    );

                    AssignmentForm assignmentForm = new AssignmentForm(customer);
                    assignmentForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selected row contains null values. Please ensure the data is complete and try again.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AssignButton_Click(object sender, EventArgs e)
        {

        }
    }
}
