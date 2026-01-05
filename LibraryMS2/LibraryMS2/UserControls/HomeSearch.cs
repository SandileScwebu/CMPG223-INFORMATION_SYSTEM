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
    public partial class HomeSearch : UserControl
    {
        public HomeSearch()
        {
            InitializeComponent();
        }

        //initialize

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\31765432\Desktop\LibraryMS2\LibraryMS2\LibraryMS_Database.mdf;Integrated Security=True;Connect Timeout=30";

        public Panel pnlMainDashboard;

        //METHODS

        private void addUserControl(UserControl userControl)
        {
            // Use FindForm() to get the parent form (Dashboard)
            Dashboard parentForm = (Dashboard)this.FindForm();

            // Ensure parentForm is not null
            if (parentForm == null)
            {
                MessageBox.Show("Parent form is null.");
                return;
            }

            // Access the pnlMainDashboard from the parent form
            Panel mainPanel = parentForm.pnlMainDashboard;

            // Ensure mainPanel is not null
            if (mainPanel == null)
            {
                MessageBox.Show("Main panel is null.");
                return;
            }

            // Ensure userControl is not null before trying to access it
            if (userControl == null)
            {
                MessageBox.Show("UserControl is null.");
                return;
            }

            // Add the new control to the main panel

            try
            {
                mainPanel.Controls.Clear();
                userControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(userControl);
               // new LibraryMS2.UserControls.HomeDashboard()
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while adding control: {ex.Message}");
            }

        }

        private string DetectSearchCategory(string searchTerm)
        {
            // Define arrays for each category
            List<string> books = new List<string>();
            List<string> authors = new List<string>();
            List<string> readers = new List<string>();
            List<string> events = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Fetch Books
                SqlCommand cmdBooks = new SqlCommand("SELECT b.BTitle FROM BOOK b", conn);
                SqlDataReader readerBooks = cmdBooks.ExecuteReader();
                while (readerBooks.Read())
                {
                    books.Add(readerBooks["BTitle"].ToString());
                }
                readerBooks.Close();

                // Fetch Authors
                SqlCommand cmdAuthors = new SqlCommand("SELECT a.AName FROM AUTHOR a", conn);
                SqlDataReader readerAuthors = cmdAuthors.ExecuteReader();
                while (readerAuthors.Read())
                {
                    authors.Add(readerAuthors["AName"].ToString());
                }
                readerAuthors.Close();

                // Fetch Readers
                SqlCommand cmdReaders = new SqlCommand("SELECT r.FName FROM READER r", conn);
                SqlDataReader readerReaders = cmdReaders.ExecuteReader();
                while (readerReaders.Read())
                {
                    readers.Add(readerReaders["FName"].ToString());
                }
                readerReaders.Close();

                // Fetch Events
                SqlCommand cmdEvents = new SqlCommand("SELECT e.ETitle FROM EVENTS e", conn);
                SqlDataReader readerEvents = cmdEvents.ExecuteReader();
                while (readerEvents.Read())
                {
                    events.Add(readerEvents["ETitle"].ToString());
                }
                readerEvents.Close();
            }


            // Check if the search term matches any category in the lists
            if (books.Any(book => book.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0))
            {
                return "Books";
            }
            else if (authors.Any(author => author.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0))
            {
                return "Authors";
            }
            else if (readers.Any(reader => reader.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0))
            {
                return "Readers";
            }
            else if (events.Any(eventItem => eventItem.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0))
            {
                return "Events";
            }

            return null;  // Return null 
        }

        

        //Events

        private void HomeSearch_Load(object sender, EventArgs e)
        {


            


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT b.BTitle FROM BOOK b", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbDashboardSearch.Items.Add(reader["BTitle"].ToString());
                }
                reader.Close();

                SqlCommand cmd1 = new SqlCommand("SELECT a.AName FROM  AUTHOR a", conn);
                SqlDataReader reader1 = cmd1.ExecuteReader();

                while (reader1.Read())
                {
                    cmbDashboardSearch.Items.Add(reader1["AName"].ToString());
                }
                reader1.Close();

                SqlCommand cmd2 = new SqlCommand("SELECT r.FName FROM READER r", conn);
                SqlDataReader reader2 = cmd2.ExecuteReader();

                while (reader2.Read())
                {

                    cmbDashboardSearch.Items.Add(reader2["FName"].ToString());
                }
                reader2.Close();

                SqlCommand cmd3 = new SqlCommand("SELECT e.ETitle FROM EVENTS e", conn);
                SqlDataReader reader3 = cmd3.ExecuteReader();

                while (reader3.Read())
                {
                    cmbDashboardSearch.Items.Add(reader3["ETitle"].ToString());
                }
                reader3.Close();
            }
            cmbDashboardSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbDashboardSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbDashboardSearch.DropDownStyle = ComboBoxStyle.DropDown;


        }

        private void btnSearchHD_Click(object sender, EventArgs e)
        {
            string searchTerm = cmbDashboardSearch.Text.Trim();

            // Check if search term is empty
            if (string.IsNullOrEmpty(searchTerm) || searchTerm == "SEARCH AUTHOR, READER, EVENT OR BOOK")
            {
                MessageBox.Show("Please enter a valid search term.");
                return;
            }

            // Try to detect the category based on the search term
            string searchCategory = DetectSearchCategory(searchTerm);

            if (string.IsNullOrEmpty(searchCategory))
            {
                MessageBox.Show("Search term does not match any known category.");
                return;
            }

            MessageBox.Show($"Search term: {searchTerm}, Detected Category: {searchCategory}");

            UserControl newControl = null;

            // Based on the detected category, perform the appropriate search
            if (searchCategory == "Books")
            {
                newControl = new LibraryMS2.UserControls.Book();
                //(newControl as LibraryMS2.UserControls.Book).LoadBookByTitle(searchTerm);
                MessageBox.Show("Loading books...");
            }
            else if (searchCategory == "Authors")
            {
                newControl = new LibraryMS2.UserControls.Author();
                //(newControl as LibraryMS2.UserControls.Author).LoadAuthorByName(searchTerm);
                MessageBox.Show("Loading authors...");
            }
            else if (searchCategory == "Readers")
            {
                newControl = new LibraryMS2.UserControls.Reader();
                //(newControl as LibraryMS2.UserControls.Reader).LoadReaderByName(searchTerm);
                MessageBox.Show("Loading readers...");
            }
            else if (searchCategory == "Events")
            {
                newControl = new LibraryMS2.UserControls.Event();
                //(newControl as LibraryMS2.UserControls.Event).LoadEventByTitle(searchTerm);
                MessageBox.Show("Loading events...");
            }

            // Add the new control to the panel if it's not null
            if (newControl != null)
            {
                addUserControl(newControl);
            }
        }

        private void cmbDashboardSearch_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbDashboardSearch.Text))
            {
                cmbDashboardSearch.Text = "SEARCH AUTHOR, READER, EVENT OR BOOK";
            }
        }

        private void cmbDashboardSearch_MouseHover(object sender, EventArgs e)
        {

        }

        private void cmbDashboardSearch_MouseEnter(object sender, EventArgs e)
        {
            if (cmbDashboardSearch.Text == "SEARCH AUTHOR, READER, EVENT OR BOOK")
            {
                cmbDashboardSearch.Text = "";
            }
        }
    }
}
