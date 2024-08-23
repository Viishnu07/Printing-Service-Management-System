using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MasterCopy3
{
    public partial class RequestReport : Form
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter dataAdapter;
        private DataTable chartData;
        public RequestReport()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeChart();

            // Add months to the month ComboBox
            for (int i = 1; i <= 12; i++)
            {
                comboBox1.Items.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
            }

            // Add years to the year ComboBox (you can set your range)
            for (int i = DateTime.Now.Year; i >= 2020; i--)
            {
                comboBox2.Items.Add(i.ToString());
            }
        }
        private void InitializeDatabaseConnection()
        {
            // Set  connection string
            string connectionString = "Data Source=.;Initial Catalog=Payment;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        private void InitializeChart()
        {
            
            
                // Check if chart area already exists, create a new one if not
                if (chart2.ChartAreas.Count == 0)
                {
                    chart2.ChartAreas.Add(new ChartArea());
                }

                // Clear existing series before adding a new one
                chart2.Series.Clear();

                // Add a new series with the desired chart type
                chart2.Series.Add(new Series());
                chart2.Series[0].ChartType = SeriesChartType.Bar;
            
        }
        private void GetDataFromDatabase(bool forChart)
        {
            try
            {
                sqlConnection.Open();

                // Get selected month and year
                string selectedMonth = comboBox1.SelectedItem?.ToString();
                string selectedYear = comboBox2.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedMonth) || string.IsNullOrEmpty(selectedYear))
                {
                    MessageBox.Show("Please select both a month and a year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Modify your SQL query to count the occurrences of each Servicetype
                string query = $"SELECT Servicetype, COUNT(*) as ServicetypeCount FROM payment WHERE MONTH(Date) = {GetMonthNumber(selectedMonth)} AND YEAR(Date) = {selectedYear} GROUP BY Servicetype";

                dataAdapter = new SqlDataAdapter(query, sqlConnection);

                chartData = new DataTable();
                dataAdapter.Fill(chartData);

                // Check if data is empty
                if (chartData.Rows.Count == 0)
                {
                    MessageBox.Show($"No data found for {selectedMonth} {selectedYear}.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Bind data to chart
                chart2.DataSource = chartData;
                chart2.Series[0].XValueMember = "Servicetype";
                chart2.Series[0].YValueMembers = "ServiceTypeCount"; // Display the count of each service type
                chart2.DataBind();

                if (forChart)
                {
                    // Use the chartData for the DataGridView
                    DataTable gridViewData = chartData.Copy();

                    // Show the data in a separate form
                    DataGrid dataGridForm = new DataGrid(gridViewData);
                    dataGridForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private int GetMonthNumber(string month)
        {
            DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
            return Array.IndexOf(dtfi.MonthNames, month) + 1;
        }


        private void RequestReport_Load(object sender, EventArgs e)
        {

        }

    
        private void RequestReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the database connection when the form is closing
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

     

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void GenerateButton_Click_1(object sender, EventArgs e)
        {
            GetDataFromDatabase(forChart: true);
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            GetDataFromDatabase(forChart: false);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
