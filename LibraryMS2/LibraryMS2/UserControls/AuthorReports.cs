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
    public partial class AuthorReports : UserControl
    {
        public AuthorReports()
        {
            InitializeComponent();
            setData();


        }

        //initial
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\31765432\Desktop\LibraryMS2\LibraryMS2\LibraryMS_Database.mdf;Integrated Security=True;Connect Timeout=30";


        //method

        private void RefreshDataGridView()
        {
            try
            {
                // Use the same stored procedure as in the chart
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("TOP10AUTHORTOTALBOOKS", con))
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
                    tOP10AUTHORTOTALBOOKSDataGridView.DataSource = dt; // Binding data to the correct DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing DataGridView: " + ex.Message, "Refresh Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadTop10AuthorsChart()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("TOP10AUTHORTOTALBOOKS", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Clear old data
                chartTopAuthor.Series.Clear();
                chartTopAuthor.ChartAreas.Clear();
                chartTopAuthor.ChartAreas.Add("ChartArea1");

                // Create new series
                Series series = new Series("Author");
                series.ChartType = SeriesChartType.Column; // Bar, Pie, Line, etc.
                series.XValueMember = "Author Name";
                series.YValueMembers = "Number Of Books";

                chartTopAuthor.Series.Add(series);
                chartTopAuthor.DataSource = dt;
                chartTopAuthor.DataBind();

                chartTopAuthor.ChartAreas[0].AxisX.Interval = 1;
            }
        }

        private void setData()
        {
            try
            {
                // Refresh the DataGridView
                RefreshDataGridView();

                // Refresh the chart
                LoadTop10AuthorsChart();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message, "Refresh Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        //event

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AuthorReports_Load(object sender, EventArgs e)
        {
            setData();

        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the Dashboard form
            Dashboard dash = (Dashboard)this.FindForm();
            // Then load HomeDashboard (or whichever you want last visible)
            dash.addUserControl(new LibraryMS2.UserControls.HomeDashboard());
        }
    }
}
