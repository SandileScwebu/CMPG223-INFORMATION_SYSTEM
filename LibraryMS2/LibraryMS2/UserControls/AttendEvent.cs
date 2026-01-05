using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace LibraryMS2.UserControls
{
    public partial class AttendEvent : UserControl
    {
        public AttendEvent()
        {
            InitializeComponent();
            HideIDColumns();
            
        }

        //initial
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\31765432\Desktop\LibraryMS2\LibraryMS2\LibraryMS_Database.mdf;Integrated Security=True;Connect Timeout=30";



        //method

        

        private void LoadAttendanceDataByEvent(int eventId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT er.Reader_ID, er.Event_ID, CONCAT(r.FName,' ', r.LName) AS Reader_Name, er.isAttend
            FROM EVENTREADER er
            INNER JOIN READER r ON er.Reader_ID = r.Reader_ID
            WHERE er.Event_ID = @Event_ID
            ORDER BY Reader_Name ASC;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Event_ID", eventId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                getEventReader02DataGridView.AutoGenerateColumns = true;
                getEventReader02DataGridView.DataSource = dt;

                // Hide ID columns
                if (getEventReader02DataGridView.Columns.Contains("Reader_ID"))
                    getEventReader02DataGridView.Columns["Reader_ID"].Visible = false;

                if (getEventReader02DataGridView.Columns.Contains("Event_ID"))
                    getEventReader02DataGridView.Columns["Event_ID"].Visible = false;

                // Rename headers
                if (getEventReader02DataGridView.Columns.Contains("Reader_Name"))
                    getEventReader02DataGridView.Columns["Reader_Name"].HeaderText = "Reader";

                if (getEventReader02DataGridView.Columns.Contains("isAttend"))
                    getEventReader02DataGridView.Columns["isAttend"].HeaderText = "Attendance";
            }
        }

        private void HideIDColumns()
        {
            // Assuming your DataGridView is named 'rEADERATEVENTASCDataGridView'

            // Hide
            getEventReader02DataGridView.Columns[0].Visible = false;

            getEventReader02DataGridView.Columns[1].Visible = false;

            getEventReader02DataGridView.Columns[2].Visible = false;

        }


        //populate combobox event
        private void PopulateComboBoxEvents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Get events the reader has not attended yet (or attended, depending on use case)
                SqlCommand cmd = new SqlCommand("SELECT e.Event_ID, e.ETitle FROM EVENTS e ", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                event_TitleComboBox.DataSource = dt;
                event_TitleComboBox.DisplayMember = "ETitle";
                event_TitleComboBox.ValueMember = "Event_ID";
            }
        }

        //Populate combobox reader
        private void PopulateComboBoxReaders()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Reader_ID, FName + ' ' + LName AS FullName FROM READER", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                readerComboBox.DataSource = dt;
                readerComboBox.DisplayMember = "FullName";
                readerComboBox.ValueMember = "Reader_ID";
            }
        }

        private void UpdateAttendance(int readerId, int eventId, bool isAttend)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UPDATE_ATTENDANCE", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Reader_ID", readerId);
                cmd.Parameters.AddWithValue("@Event_ID", eventId);
                cmd.Parameters.AddWithValue("@isAttend", isAttend);

                conn.Open();
                cmd.ExecuteNonQuery();

            }
        }

        private void AddAttendance(int readerId, int eventId, bool isAttend)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("ADD_ATTENDANCE", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Reader_ID", readerId);
                cmd.Parameters.AddWithValue("@Event_ID", eventId);
                cmd.Parameters.AddWithValue("@isAttend", isAttend);

                conn.Open();
                cmd.ExecuteNonQuery();

            }
        }


        // Insert/Update depending on existence
        private void SaveAttendance(int readerId, int eventId, bool isAttend)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SAVE_ATTENDANCE", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Reader_ID", readerId);
                cmd.Parameters.AddWithValue("@Event_ID", eventId);
                cmd.Parameters.AddWithValue("@isAttend", isAttend);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        private void LoadAttendanceData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetEventReader02", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                getEventReader02DataGridView.DataSource = dt;
            }
        }





        //events

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAttendEvent_Click(object sender, EventArgs e)
        {
            if (readerComboBox.SelectedValue != null && event_TitleComboBox.SelectedValue != null)
            {
                int readerId = Convert.ToInt32(readerComboBox.SelectedValue);
                int eventId = Convert.ToInt32(event_TitleComboBox.SelectedValue);

                // Mark attendance as true (attended)
                SaveAttendance(readerId, eventId, true);

                // Refresh the grid for this reader
                LoadAttendanceDataByEvent(eventId);
                MessageBox.Show("Attendance successfully updated.");

                // Ask if the user wants to rate the event now
                DialogResult result = MessageBox.Show("Do you want to rate the event now?", "Rate Event", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Load the RateEvent user control
                    Dashboard dash = (Dashboard)this.FindForm();
                    dash.addUserControl(new LibraryMS2.UserControls.RateEvent());
                }
                else
                {
                    // Optional: do nothing or show a message
                    MessageBox.Show("Please rate the event later!");
                }
            }
            else
            {
                MessageBox.Show("Please select both a reader and an event.");
            }
        }

        private void AttendEvent_Load(object sender, EventArgs e)
        {
            PopulateComboBoxEvents();
            PopulateComboBoxReaders();

            event_TitleComboBox.SelectedIndexChanged += event_TitleComboBox_SelectedIndexChanged;


            

            if (readerComboBox.SelectedValue != null)
            {
                int readerId = Convert.ToInt32(readerComboBox.SelectedValue);
                LoadAttendanceData();
            }
        }

        private void getEventReader02DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                
        }

        private void btnWontAttend_Click(object sender, EventArgs e)
        {
            if (readerComboBox.SelectedValue != null && event_TitleComboBox.SelectedValue != null)
            {
                int readerId = Convert.ToInt32(readerComboBox.SelectedValue);
                int eventId = Convert.ToInt32(event_TitleComboBox.SelectedValue);

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("DELETE_ATTENDANCE", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Reader_ID", readerId);
                        cmd.Parameters.AddWithValue("@Event_ID", eventId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    // Refresh the grid
                    LoadAttendanceDataByEvent(eventId);
                    MessageBox.Show("Attendance record deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting attendance: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select both a reader and an event.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the Dashboard form
            Dashboard dash = (Dashboard)this.FindForm();



            // Then load HomeDashboard 
            dash.addUserControl(new LibraryMS2.UserControls.HomeDashboard());
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            
        }

        private void event_TitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (event_TitleComboBox.SelectedValue != null && int.TryParse(event_TitleComboBox.SelectedValue.ToString(), out int eventId))
            {
                LoadAttendanceDataByEvent(eventId);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void getEventReader02DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            

        }
    }
}
