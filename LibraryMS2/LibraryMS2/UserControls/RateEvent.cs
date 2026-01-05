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
using System.Drawing.Printing;

namespace LibraryMS2.UserControls
{
    public partial class RateEvent : UserControl
    {


        public RateEvent()
        {
            InitializeComponent();

            HideIDColumns();
            LoadEventRatings();

            // Populate Event ComboBox
            PopulateEventComboBox();

            event_TitleComboBox.SelectedIndexChanged += event_TitleComboBox_SelectedIndexChanged;

            // Populate Reader ComboBox
            PopulateReaderComboBox();

            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        public PrintDocument printDocument = new PrintDocument();
        public PrintPreviewDialog printPreview = new PrintPreviewDialog();
        private int currentPage = 1;
        private int totalPages = 0;
        private int currentRow = 0;


        public event EventHandler RatingsUpdated;

        //initial
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\31765432\Desktop\LibraryMS2\LibraryMS2\LibraryMS_Database.mdf;Integrated Security=True;Connect Timeout=30";

        //method
        private void HideIDColumns()
        {
            // Assuming your DataGridView is named 'rEADERATEVENTASCDataGridView'

            // Hide the last column (Event_ID)
            rEADERATEVENTASCDataGridView.Columns[0].Visible = false;

            
        }


        private void LoadEventRatings()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("READERATEVENTASC", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Bind directly to the DataGridView
                rEADERATEVENTASCDataGridView.AutoGenerateColumns = true;
                rEADERATEVENTASCDataGridView.DataSource = dataTable;

                // Show only the two columns we care about
                if (rEADERATEVENTASCDataGridView.Columns.Contains("Reader_Name"))
                {
                    rEADERATEVENTASCDataGridView.Columns["Reader_Name"].HeaderText = "Reader";
                }

                if (rEADERATEVENTASCDataGridView.Columns.Contains("Rating"))
                {
                    rEADERATEVENTASCDataGridView.Columns["Rating"].HeaderText = "Event Rating";
                }

            }
        }

        private void PopulateEventComboBox()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Query to get events
                SqlCommand command = new SqlCommand("SELECT Event_ID, ETitle FROM EVENTS", connection);

                // Open the connection
                connection.Open();

                // Execute the query and load the data into a DataTable
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Set ComboBox data source
                event_TitleComboBox.DataSource = dataTable;
                event_TitleComboBox.DisplayMember = "ETitle";  // Display event title
                event_TitleComboBox.ValueMember = "Event_ID"; // Store Event_ID as value
            }
        }

        private void PopulateReaderComboBox()
        {


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Query to get readers
                SqlCommand command = new SqlCommand("SELECT Reader_ID, CONCAT(FName, ' ', LName) AS Reader_Name FROM READER", connection);

                // Open the connection
                connection.Open();

                // Execute the query and load the data into a DataTable
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Set ComboBox data source
                reader_NameComboBox.DataSource = dataTable;
                reader_NameComboBox.DisplayMember = "Reader_Name";  // Display full name
                reader_NameComboBox.ValueMember = "Reader_ID"; // Store Reader_ID as value
            }
        }

        private bool HasAttendedEvent(int readerId, int eventId)
        {



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create the command to check if the reader has attended the event
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM EVENTREADER WHERE Reader_ID = @Reader_ID AND Event_ID = @Event_ID AND isAttend = 1", connection);
                command.Parameters.AddWithValue("@Reader_ID", readerId);
                command.Parameters.AddWithValue("@Event_ID", eventId);

                // Open the connection
                connection.Open();

                // Execute the query and check if any records are returned
                int count = (int)command.ExecuteScalar();

                // Return true if the reader has attended the event
                return count > 0;
            }
        }

        private void AddEventRating(int readerId, int eventId, int rating)
        {


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create the command to insert the rating into the database
                SqlCommand command = new SqlCommand("UPDATE_RATING", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters
                command.Parameters.AddWithValue("@Reader_ID", readerId);
                command.Parameters.AddWithValue("@Event_ID", eventId);
                command.Parameters.AddWithValue("@Rating", rating);

                // Open the connection and execute the command
                connection.Open();
                command.ExecuteNonQuery();

                // Optionally, refresh the DataGridView to show the new rating
                //LoadEventRatings();

                if (this.FindForm() is Dashboard dash)
                {
                    foreach (Control ctrl in dash.pnlMainDashboard.Controls)
                    {
                        if (ctrl is LibraryMS2.UserControls.HomeDashboard homeDash)
                        {
                            homeDash.RefreshRatingsForSelectedEvent(eventId);
                            break;
                        }
                    }
                }
            }
        }


        //event

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the selected reader and event IDs
            int readerId = Convert.ToInt32(reader_NameComboBox.SelectedValue);
            int eventId = Convert.ToInt32(event_TitleComboBox.SelectedValue);

            // Check if the reader has attended the event
            if (HasAttendedEvent(readerId, eventId))
            {
                // If attended, allow adding the rating
                int rating = ratingTrackBar.Value;  // Assuming you have a TrackBar for rating
                AddEventRating(readerId, eventId, rating);
                MessageBox.Show("Event rating complete!");
            }
            else
            {
                // Show a message if the user has not attended the event
                MessageBox.Show("You need to attend the event before rating it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ratingTrackBar_Scroll(object sender, EventArgs e)
        {
            lblRating.Text = $"Rating: {ratingTrackBar.Value}";  // Assuming you have a label named lblRating

        }

        private void btnCloseRateEvent_Click(object sender, EventArgs e)
        {
            // Get the Dashboard form
            Dashboard dash = (Dashboard)this.FindForm();



            // Then load HomeDashboard (or whichever you want last visible)
            dash.addUserControl(new LibraryMS2.UserControls.HomeDashboard());
        }

        private void event_TitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (event_TitleComboBox.SelectedValue is int eventId)
            {
                LoadEventRatingsByEvent(eventId);
            }
        }

        private void LoadEventRatingsByEvent(int eventId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT CONCAT(r.FName,' ', r.LName) AS Reader_Name, er.Rating
            FROM EVENTREADER er
            INNER JOIN READER r ON er.Reader_ID = r.Reader_ID
            WHERE er.Event_ID = @Event_ID AND er.isAttend = 1
            ORDER BY Reader_Name ASC;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Event_ID", eventId);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                rEADERATEVENTASCDataGridView.AutoGenerateColumns = true;
                rEADERATEVENTASCDataGridView.DataSource = dataTable;

                if (rEADERATEVENTASCDataGridView.Columns.Contains("Reader_Name"))
                    rEADERATEVENTASCDataGridView.Columns["Reader_Name"].HeaderText = "Reader";

                if (rEADERATEVENTASCDataGridView.Columns.Contains("Rating"))
                    rEADERATEVENTASCDataGridView.Columns["Rating"].HeaderText = "Event Rating";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblRating_Click(object sender, EventArgs e)
        {

        }

        private void ratingTrackBar_Scroll_1(object sender, EventArgs e)
        {
            lblRating.Text = $"Rating: {ratingTrackBar.Value}";
        }

        private void ratingLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Get the selected reader's details from controls
            string readerName = reader_NameComboBox.Text; // Selected reader's name
            string eventTitle = event_TitleComboBox.Text;  // Selected event title
            int rating = ratingTrackBar.Value;             // Rating from the TrackBar

            // Check if a reader is selected
            if (string.IsNullOrEmpty(readerName) || string.IsNullOrEmpty(eventTitle))
            {
                MessageBox.Show("Please select a reader and event before printing.");
                return;
            }

            // Ensure printDocument and printPreview are initialized
            if (printDocument == null)
            {
                printDocument = new PrintDocument();
            }
            if (printPreview == null)
            {
                printPreview = new PrintPreviewDialog();
            }

            // Clear any existing event handlers (prevents duplicate event wiring)
            printDocument.PrintPage -= PrintDocument_PrintPage;

            // Add the event handler for PrintPage
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Show the print preview
            printPreview.Document = printDocument;
            printPreview.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string readerName = reader_NameComboBox.Text; // Selected reader's name
            string eventTitle = event_TitleComboBox.Text;  // Selected event title
            int rating = ratingTrackBar.Value;             // Rating from the TrackBar

            Font font = new Font("Arial", 10);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Brush brush = Brushes.Black;
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int pageWidth = e.MarginBounds.Width;
            int pageHeight = e.MarginBounds.Height;

            // Centering all elements
            int y = topMargin + (pageHeight / 4);  // Start at around the center vertically

            // === Header ===
            string title = "CERTIFICATE of PARTICIPATION";
            SizeF titleSize = e.Graphics.MeasureString(title, headerFont);
            float titleX = (pageWidth - titleSize.Width) / 2 + leftMargin; // Center horizontally
            e.Graphics.DrawString(title, headerFont, brush, titleX, y);
            y += (int)titleSize.Height + 20;

            // === Reader's Name ===
            Font readerFont = new Font("Arial", 18, FontStyle.Bold);
            SizeF readerNameSize = e.Graphics.MeasureString(readerName, readerFont);
            float readerNameX = (pageWidth - readerNameSize.Width) / 2 + leftMargin; // Center horizontally
            e.Graphics.DrawString(readerName, readerFont, brush, readerNameX, y);
            y += (int)readerNameSize.Height + 20;

            // === Event Name ===
            Font eventFont = new Font("Arial", 12);
            string eventText = $"For participating in the {eventTitle} event.";
            SizeF eventSize = e.Graphics.MeasureString(eventText, eventFont);
            float eventX = (pageWidth - eventSize.Width) / 2 + leftMargin; // Center horizontally
            e.Graphics.DrawString(eventText, eventFont, brush, eventX, y);
            y += (int)eventSize.Height + 20;

            // === Rating Text ===
            Font ratingFont = new Font("Arial", 12);
            string ratingText = $"WE EXTEND OUR SINCERE APPRECIATION FOR THEIR ENTHUSIASM ";
            SizeF ratingSize = e.Graphics.MeasureString(ratingText, ratingFont);
            float ratingX = (pageWidth - ratingSize.Width) / 2 + leftMargin; // Center horizontally
            e.Graphics.DrawString(ratingText, ratingFont, brush, ratingX, y);
            y += (int)ratingSize.Height + 20;

            // === Star Emojis ===
            Font starFont = new Font("Arial", 60);  // Set a smaller font size to fit the stars within the page
            string stars = new string('⭐', rating); // Star emoticons
            SizeF starsSize = e.Graphics.MeasureString(stars, starFont);
            float starsX = (pageWidth - starsSize.Width) / 2 + leftMargin; // Center horizontally
            e.Graphics.DrawString(stars, starFont, brush, starsX, y);
            y += (int)starsSize.Height + 40;  // Adjust vertical spacing for stars

            // === Comment based on Rating ===
            string comment = GetRatingComment(rating);
            SizeF commentSize = e.Graphics.MeasureString($"Comment: {comment}", font);
            float commentX = (pageWidth - commentSize.Width) / 2 + leftMargin; // Center horizontally
            e.Graphics.DrawString($"Comment: {comment}", font, brush, commentX, y);
            y += (int)commentSize.Height + 40;

            // Footer (optional)
            string footer = $"Page 1 of 1";
            SizeF footerSize = e.Graphics.MeasureString(footer, font);
            float footerX = (pageWidth - footerSize.Width) / 2 + leftMargin; // Center horizontally
            e.Graphics.DrawString(footer, font, brush, footerX, e.MarginBounds.Bottom - footerSize.Height);

            // Indicate end of printing
            e.HasMorePages = false;
        }



        public string GetRatingComment(int rating)
        {
            switch (rating)
            {
                case 1: return "Very Poor Event";
                case 2: return "Poor Event";
                case 3: return "Average Event";
                case 4: return "Good Event";
                case 5: return "Excellent Event";
                default: return "This person did not rate the event";
            }
        }
        private void rEADERATEVENTASCDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header row clicks
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = rEADERATEVENTASCDataGridView.Rows[e.RowIndex];

                // Get values from the DataGridView row
                string readerName = row.Cells[0].Value?.ToString();
                int rating = 0;

                if (row.Cells[1].Value != null && int.TryParse(row.Cells[1].Value.ToString(), out int parsedRating))
                {
                    rating = parsedRating;
                }

                // Populate controls
                if (!string.IsNullOrEmpty(readerName))
                {
                    reader_NameComboBox.Text = readerName; // sets combobox text
                }

                ratingTrackBar.Value = Math.Min(Math.Max(rating, ratingTrackBar.Minimum), ratingTrackBar.Maximum);
                lblRating.Text = $"Rating: {ratingTrackBar.Value}";
            }
        }
    }
}
