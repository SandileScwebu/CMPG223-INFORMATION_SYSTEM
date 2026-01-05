using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
namespace LibraryMS2.UserControls
{
    public partial class BooksReports : UserControl
    {
        public BooksReports()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\31765432\Desktop\LibraryMS2\LibraryMS2\LibraryMS_Database.mdf;Integrated Security=True;Connect Timeout=30";

        private void RefreshDataGridView()
        {
            try
            {
                // Use the same stored procedure as in the chart
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("TOP10BOOKS", con))
                {
                    // Set the command type to StoredProcedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Create a DataAdapter to fill the data
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    // Create a DataTable to hold the data
                    DataTable dt = new DataTable();

                    // Fill the DataTable with data from the stored procedure
                    da.Fill(dt);

                    // Set the DataGridView's DataSource to the DataTable
                    tOP10BOOKSDataGridView.DataSource = dt; // Binding data to the correct DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing DataGridView: " + ex.Message, "Refresh Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setData()
        {
            try
            {
                // Refresh the DataGridView
                RefreshDataGridView();

                // Refresh the chart
                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.Titles.Add("Top 10 Books by Quantity Sold");

                // Create a doughnut series
                Series series = new Series("Books");
                series.ChartType = SeriesChartType.Doughnut;
                series.LegendText = "#VALX";   // Show Book Title in the legend
                series.IsValueShownAsLabel = true;
                series.Label = "#VALY";        // Show Number of Books inside slice
                series.XValueMember = "Book Title";
                series.YValueMembers = "Number Of Books";

                chart1.Series.Add(series);

                // Load data from stored procedure
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("TOP10BOOKS", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(dt);
                }

                chart1.DataSource = dt;
                chart1.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message, "Refresh Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowChartSummary(Chart chart)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Series series in chart.Series)
            {
                sb.AppendLine($"Series: {series.Name}");
                foreach (DataPoint point in series.Points)
                {
                    sb.AppendLine($" - {point.AxisLabel}: {point.YValues[0]}");
                }
            }

            MessageBox.Show(sb.ToString(), "Chart Summary");
        }

        private void BooksReports_Load(object sender, EventArgs e)
        {
            chart1.Click += chart1_Click;

            RefreshDataGridView();

            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Top 10 Books by Quantity Sold");

            // Create a doughnut series
            Series series = new Series("Books");
            series.ChartType = SeriesChartType.Doughnut;

            // Set what will appear in the legend
            series.LegendText = "#VALX"; // Book Title in the legend

            // Show actual value inside slices
            series.IsValueShownAsLabel = true;
            series.Label = "#VALY"; // Number of books sold

            series.XValueMember = "Book Title";
            series.YValueMembers = "Number Of Books";

            chart1.Series.Add(series);

            // Data binding
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("TOP10BOOKS", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
            }

            chart1.DataSource = dt;
            chart1.DataBind();

            setData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the Dashboard form
            Dashboard dash = (Dashboard)this.FindForm();
            // Then load HomeDashboard (or whichever you want last visible)
            dash.addUserControl(new LibraryMS2.UserControls.HomeDashboard());
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            Chart chart = sender as Chart;

            if (chart == null) return;

            // Optional: get mouse position
            MouseEventArgs me = e as MouseEventArgs;
            if (me != null)
            {
                HitTestResult result = chart.HitTest(me.X, me.Y);

                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    int pointIndex = result.PointIndex;
                    Series series = result.Series;

                    // Get data value
                    double value = series.Points[pointIndex].YValues[0];
                    string label = series.Points[pointIndex].AxisLabel;

                    string summary = $"Series '{series.Name}', Point '{label}' has value {value}";
                    MessageBox.Show(summary, "Chart Summary");
                }
            }
        }
    }
}
