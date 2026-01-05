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
    public partial class EventReports : UserControl
    {
        public EventReports()
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
                using (SqlCommand cmd = new SqlCommand("TOP10EVENTS", con))
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
                    tOP10EVENTSDataGridView.DataSource = dt; // Binding data to the correct DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing DataGridView: " + ex.Message, "Refresh Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EventReport_Load(object sender, EventArgs e)
        {
            this.tOP10EVENTSTableAdapter.Fill(this.libraryMS_DatabaseDataSet.TOP10EVENTS);

            // Fill the DataSet
            this.tOP10EVENTSTableAdapter.Fill(this.libraryMS_DatabaseDataSet.TOP10EVENTS);

            // Clear previous series
            chartEvents.Series.Clear();

            // Create a radar (spider) series
            Series series = new Series("Attendees")
            {
                ChartType = SeriesChartType.Radar,
                XValueMember = "Event Title", // Event Title
                YValueMembers = "Attendees",     // Number of attendees
                BorderWidth = 2,
                IsValueShownAsLabel = true
            };

            chartEvents.Series.Add(series);

            // Set the DataSource
            chartEvents.DataSource = this.libraryMS_DatabaseDataSet.TOP10EVENTS;

            // Optional chart formatting
            chartEvents.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartEvents.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartEvents.ChartAreas[0].AxisY.Maximum = this.libraryMS_DatabaseDataSet.TOP10EVENTS.AsEnumerable()
                .Max(row => Convert.ToInt32(row["Attendees"])); // scale to max attendees

            chartEvents.DataBind();

            setData();
        }

        private void setData()
        {
            try
            {
                // Refresh the DataGridView first to load the latest data
                RefreshDataGridView();

                // Refresh the chart
                chartEvents.Series.Clear();

                // Create a radar (spider) series
                Series series = new Series("Attendees")
                {
                    ChartType = SeriesChartType.Radar,
                    XValueMember = "Event Title",  // Event Title
                    YValueMembers = "Attendees",  // Number of attendees
                    BorderWidth = 2,
                    IsValueShownAsLabel = true
                };

                // Add the series to the chart
                chartEvents.Series.Add(series);

                // Set the DataSource for the chart
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("TOP10EVENTS", con))
                {
                    // Set the command type to StoredProcedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Create a DataAdapter to fill the data
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    // Create a DataTable to hold the data
                    DataTable dt = new DataTable();

                    // Fill the DataTable with data from the stored procedure
                    da.Fill(dt);

                    // Bind the data to the chart
                    chartEvents.DataSource = dt;
                }

                // Optional chart formatting
                chartEvents.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
                chartEvents.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

                // Adjust Y-axis max dynamically
                if (chartEvents.DataSource != null && chartEvents.DataSource is DataTable dtSource)
                {
                    int maxAttendees = dtSource.AsEnumerable()
                        .Max(row => Convert.ToInt32(row["Attendees"]));
                    chartEvents.ChartAreas[0].AxisY.Maximum = maxAttendees;
                }

                chartEvents.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message, "Refresh Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartEvents_Click(object sender, EventArgs e)
        {

        }
    }
}
