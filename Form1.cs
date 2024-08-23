using Admin;
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
    public partial class MainPage : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Payment;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        private string workerID; // Field to store the WorkerID
        public MainPage(string workerID)
        {
            InitializeComponent();
            this.workerID = workerID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newRequest._NewRequest' table. You can move, or remove it, as needed.
            LoadData();

        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Payment WHERE WorkerID = @WorkerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@WorkerID", workerID); // Add the WorkerID as a parameter
                adapter.SelectCommand = cmd;
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // var dataIndexNo = dataGridView1.Rows[e.RowIndex].Index.ToString();//
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int parsedIntValue;
                double parsedDoubleValue;
                bool parsedBoolValue;

                if (int.TryParse(row.Cells[0].Value.ToString(), out parsedIntValue) &&
                    double.TryParse(row.Cells[2].Value.ToString(), out parsedDoubleValue) &&
                    int.TryParse(row.Cells[3].Value.ToString(), out parsedIntValue) &&
                    bool.TryParse(row.Cells[4].Value.ToString(), out parsedBoolValue) &&
                    int.TryParse(row.Cells[5].Value.ToString(), out parsedIntValue))
                {
                    Request request = new Request(
                        int.Parse(row.Cells[0].Value.ToString()),
                        row.Cells[1].Value.ToString(),
                        double.Parse(row.Cells[2].Value.ToString()),
                        int.Parse(row.Cells[3].Value.ToString()),
                        bool.Parse(row.Cells[4].Value.ToString()),
                        int.Parse(row.Cells[5].Value.ToString()),
                        row.Cells[6].Value.ToString()
                    );

                    WorkRequest workRequest = new WorkRequest(request);
                    workRequest.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error: Unable to parse one or more values from cell.");
                }
            }
        }

            private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Login new1 = new Login();
            new1.ShowDialog();
        }
    }
}
