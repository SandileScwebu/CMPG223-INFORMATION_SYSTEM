using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
//datagridview stored procedure 
using System.Data.SqlClient;

namespace LibraryMS2.UserControls
{
    public partial class Event : UserControl
    {
        public void PlayNotificationSound()
        {
            // Ensure the file path points to a valid .wav file
            string soundFilePath = @"C:\Users\31765432\Desktop\LibraryMS2\notification.wav";

            try
            {
                SoundPlayer player = new SoundPlayer(soundFilePath);
                player.Play(); // Use PlaySync() for synchronous playback
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing sound: {ex.Message}");
            }
        }


        public Event()
        {
            InitializeComponent();
            ClearInputs();
        }

        //initial
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\31765432\Desktop\LibraryMS2\LibraryMS2\LibraryMS_Database.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter da;
        DataTable dt;

        

        //method

        private void PopulateControls(string eventTitle)
        {
            foreach (DataGridViewRow row in aLLEVENSNOIDSDataGridView.Rows)
            {
                // Clear previous selections

                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == eventTitle)
                {
                    // Select the row
                    row.Selected = true;

                    // Populate controls
                    event_TitleComboBox.Text = row.Cells[0].Value.ToString();       // Event Title
                    event_DetailsTextBox.Text = row.Cells[1].Value.ToString();      // Event Details
                    event_DateDateTimePicker.Value = Convert.ToDateTime(row.Cells[2].Value); // Event Date

                    // Handle large number of attendees
                    int attendees = Convert.ToInt32(row.Cells[3].Value);
                    if (attendees > 100)
                    {
                        attendees = 100;

                        // Update database if value exceeds 100
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE EVENTS SET ENoAttendees = @ENoAttendees WHERE ETitle = @ETitle", con))
                            {
                                cmd.Parameters.AddWithValue("@ENoAttendees", attendees);
                                cmd.Parameters.AddWithValue("@ETitle", event_TitleComboBox.Text);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                    }

                    available_SeatsNumericUpDown.Value = attendees; // Set NumericUpDown
                    book_TitleComboBox.Text = row.Cells[4].Value.ToString();        // Book Title

                    break;  // Exit after the first match
                }
            }
        }

        public void LoadEventByTitle(string title)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM EVENTS WHERE ETitle = @title", conn);
                cmd.Parameters.AddWithValue("@title", title);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    event_TitleComboBox.Text = reader["ETitle"].ToString();
                    event_DetailsTextBox.Text = reader["EDetails"].ToString();
                    available_SeatsNumericUpDown.Text = reader["ENoAttendees"].ToString();
                    event_DateDateTimePicker.Value = Convert.ToDateTime(reader["EDateTime"]);

                }
            }

        }


        private void ClearInputs()
        {
            event_TitleComboBox.Text = " ";
            book_TitleComboBox.Text = " ";
            event_DetailsTextBox.Clear();
            event_DateDateTimePicker.Value = DateTime.Now;
            available_SeatsNumericUpDown.Value = 0;
        }

        //method to refresh datagridview
        private void LoadEvents()
        {
            ClearInputs();

            SqlConnection con = new SqlConnection(connectionString);
            da = new SqlDataAdapter("ALLEVENSNOIDS", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            da.Fill(dt);

            aLLEVENSNOIDSDataGridView.DataSource = dt;

            ClearInputs();
        }

        //event



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Event_Load(object sender, EventArgs e)
        {
            ClearInputs();

            //aLLEVENSNOIDSDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //autopopulate controls and dataset

            


            //ComboBox Event Books
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT e.ETitle FROM EVENTS e", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    event_TitleComboBox.Items.Add(reader["ETitle"].ToString());
                }
                reader.Close();
            }

            event_TitleComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            event_TitleComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            event_TitleComboBox.DropDownStyle = ComboBoxStyle.DropDown;

            //ComboBox BOOK TITLE
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();


                SqlDataAdapter da = new SqlDataAdapter("SELECT b.Book_ID, b.BTitle FROM BOOK b", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                book_TitleComboBox.DataSource = dt;
                book_TitleComboBox.DisplayMember = "BTitle";
                book_TitleComboBox.ValueMember = "Book_ID";

            }

            book_TitleComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            book_TitleComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            //book_TitleComboBox.DropDownStyle = ComboBoxStyle.DropDown;



            ////Add to datagridview from stored procedure

            SqlConnection con = new SqlConnection(connectionString);
            da = new SqlDataAdapter("ALLEVENSNOIDS", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            da.Fill(dt);

            aLLEVENSNOIDSDataGridView.DataSource = dt;

            ClearInputs();



        }

        private void event_TitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(event_TitleComboBox.Text))
            {
                PopulateControls(event_TitleComboBox.Text);
            }



        }

        private void btnSaveBooksForm_Click(object sender, EventArgs e)
        {
            //UpdateButton for book form


            SqlConnection con = new SqlConnection(connectionString);
            using (SqlCommand cmd = new SqlCommand("ALLEVENSNOIDSUPDATE", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Parameters for title and description
                cmd.Parameters.Add(new SqlParameter("@ETitle", SqlDbType.VarChar, 55) { Value = event_TitleComboBox.Text });
                cmd.Parameters.Add(new SqlParameter("@EDetails", SqlDbType.VarChar, 55) { Value = event_DetailsTextBox.Text });

                // example of validation for input
                //if (!decimal.TryParse(priceTextBox.Text, out decimal price))
                //{
                //    MessageBox.Show("Please enter a valid price (e.g., 12.50).");
                //    return;
                //}

                cmd.Parameters.Add(new SqlParameter("@EDateTime", SqlDbType.Date) { Value = event_DateDateTimePicker.Value });

                cmd.Parameters.Add(new SqlParameter("@ENoAttendees", SqlDbType.Int) { Value = available_SeatsNumericUpDown.Value });

                cmd.Parameters.Add(new SqlParameter("@Book_ID", SqlDbType.Int)
                {
                    Value = book_TitleComboBox.SelectedValue   //This gives you the ID, not the title to store in db
                });


                //changes datagridview
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                //
                MessageBox.Show($"{rowsAffected} event(s) updated.");
            }

            // Refresh DataGridView using load method
            LoadEvents();
        }

        private void btnAddBooksForm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            //add to db
            using (SqlCommand cmd = new SqlCommand("ALLEVENSNOIDSINSERT", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ETitle", event_TitleComboBox.Text);
                cmd.Parameters.AddWithValue("@EDetails", event_DetailsTextBox.Text);
                //decimal price;
                //if (!decimal.TryParse(priceTextBox.Text, out price))
                //{
                //    MessageBox.Show("Please enter a valid price.");
                //    return;
                //}


                cmd.Parameters.Add(new SqlParameter("@EDateTime", SqlDbType.Date) { Value = event_DateDateTimePicker.Value });

                cmd.Parameters.Add(new SqlParameter("@ENoAttendees", SqlDbType.Int) { Value = available_SeatsNumericUpDown.Value });

                cmd.Parameters.Add(new SqlParameter("@Book_ID", SqlDbType.Int)
                {
                    Value = book_TitleComboBox.SelectedValue   //This gives you the ID, not the title to store in db
                });

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Event added successfully!");
                PlayNotificationSound();
            }
            ClearInputs();
            LoadEvents();

            // Refresh the HomeDashboard labels after adding an event
            Dashboard dash = (Dashboard)this.FindForm();
            if (dash != null)
            {
                var homeDashboard = dash.Controls.OfType<HomeDashboard>().FirstOrDefault();
                if (homeDashboard != null)
                {
                    homeDashboard.RefreshLatestEvent();
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteBooksForm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                using (SqlCommand cmd = new SqlCommand("ALLEVENSNOIDSDELETE", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ETitle", event_TitleComboBox.Text);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show($"{rowsAffected} event(s) deleted.");
                }
            }
            catch (SqlException ex)
            {
                // Check for foreign key violation (usually error number 547 in SQL Server)
                if (ex.Number == 547)
                {
                    MessageBox.Show(
                        "Cannot delete this event because there are readers associated with it. Remove associated records first.",
                        "Delete Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    // Other SQL errors
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Refresh DataGridView
            LoadEvents();
        }

        private void aLLEVENSNOIDSDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the Dashboard form
            Dashboard dash = (Dashboard)this.FindForm();

            // Then load HomeDashboard (or whichever you want last visible)
            dash.addUserControl(new LibraryMS2.UserControls.HomeDashboard());
        }

        private void aLLEVENSNOIDSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aLLEVENSNOIDSDataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            if (aLLEVENSNOIDSDataGridView.CurrentRow != null && aLLEVENSNOIDSDataGridView.CurrentRow.Cells[0].Value != null)
            {
                string selectedEventTitle = aLLEVENSNOIDSDataGridView.CurrentRow.Cells[0].Value.ToString();
                PopulateControls(selectedEventTitle);
            }
            //aLLEVENSNOIDSDataGridView.ClearSelection();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Get the Dashboard form
            Dashboard dash = (Dashboard)this.FindForm();
            // Then load HomeDashboard (or whichever you want last visible)
            dash.addUserControl(new LibraryMS2.UserControls.HelpEvents());
        }
    }
}
