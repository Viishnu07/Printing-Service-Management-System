using LiveCharts.Wpf.Charts.Base;
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
    public partial class IncomeReport : Form
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter dataAdapter;
        private DataTable chartData;
        public IncomeReport()
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
            // Set your connection string
            string connectionString = "Data Source=.;Initial Catalog=Payment;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        private void InitializeChart()
        {
            // Check if chart area already exists, create a new one if not
            if (chart1.ChartAreas.Count == 0)
            {
                chart1.ChartAreas.Add(new ChartArea());
            }

            // Clear existing series before adding a new one
            chart1.Series.Clear();

            // Add a new series with the desired chart type
            chart1.Series.Add(new Series());
            chart1.Series[0].ChartType = SeriesChartType.Bar;
        }
        private void GetDataFromDatabase()
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

                // Modify your SQL query to sum the income for each Servicetype and month
                string query = $"SELECT FORMAT(Date, 'MM-yyyy') AS MonthYear, SUM(Subtotal) as TotalIncome FROM payment WHERE MONTH(Date) = {GetMonthNumber(selectedMonth)} AND YEAR(Date) = {selectedYear} GROUP BY FORMAT(Date, 'MM-yyyy')";

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
                chart1.DataSource = chartData;
                chart1.Series[0].XValueMember = "MonthYear";
                chart1.Series[0].YValueMembers = "TotalIncome"; // Display the total income for each month
                chart1.DataBind();

                // Use the chartData for the DataGridView
                DataTable gridViewData = chartData.Copy();

                // Show the data in a separate form
                IncomeGridView dataGridForm1 = new IncomeGridView(gridViewData);
                dataGridForm1.Show();
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

        private void IncomeReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the database connection when the form is closing
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        private void GenerateChartButton_Click(object sender, EventArgs e)
        {
            GetDataFromDatabase();
        }

        private void GenerateGridViewButton_Click(object sender, EventArgs e)
        {
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void IncomeReport_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
