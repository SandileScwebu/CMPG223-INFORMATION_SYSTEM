using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Search using combobox
using System.Data.SqlClient;
namespace LibraryMS2
{
    public partial class Dashboard : Form
    {
        private bool isUser = false;

        public Dashboard(bool isUser)
        {
            try
            {
                InitializeComponent();
                this.isUser = isUser;  // Set the flag based on the login type
                pnlMenu2.Width = 0;
                LibraryMS2.UserControls.HomeSearch hs = new LibraryMS2.UserControls.HomeSearch();
                addUserControl(hs);
                lblTopSearchBarPanel.Text = "Browser";

                // Disable the button if logged in as "user"
                if (isUser)
                {
                    btnAuthorBook2.Enabled = false;
                    btnRReviews.Enabled = false;
                    btnAuthorMenu2.Enabled = false;
                    btnEventMenu2.Enabled = false;
                    btnBookMenu2.Enabled = false;
                    btnEventReportsMenu2.Enabled = false;
                    btnAuthorReportsMenu2.Enabled = false;
                    btnBooksReportMenu2.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }

        //Initialize
        ToolTip toolTip = new ToolTip();
        //connectionstring
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\31765432\Desktop\LibraryMS2\LibraryMS2\LibraryMS_Database.mdf;Integrated Security=True;Connect Timeout=30";


        private void HighlightSelectedButton(Panel panel, Button selectedButton)
        {
            // Reset all buttons in the panel recursively
            ResetButtons(panel);

            // Highlight the clicked button
            selectedButton.BackColor = Color.LightGray;
            selectedButton.ForeColor = Color.Black;
        }

        // Recursive helper method
        private void ResetButtons(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = SystemColors.Control;
                    btn.ForeColor = Color.Black;
                }
                else if (ctrl.HasChildren)
                {
                    ResetButtons(ctrl); // handle nested panels
                }
            }
        }



        //Methods

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMainDashboard.Controls.Clear();
            pnlMainDashboard.Controls.Add(userControl);
            userControl.BringToFront();


        }


        private void openMenu()
        {
            if (pnlMenu2.Size.Width == 153)
            {
                pnlMenu2.Width = 0;
            }
            else
            {
                pnlMenu2.Width = 153;
            }
        }

        //For SearchBar
        private string DetectSearchCategory(string searchTerm)
        {
            List<string> books = new List<string>();
            List<string> authors = new List<string>();
            List<string> readers = new List<string>();
            List<string> events = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmdBooks = new SqlCommand("SELECT b.BTitle FROM BOOK b", conn);
                SqlDataReader readerBooks = cmdBooks.ExecuteReader();
                while (readerBooks.Read()) books.Add(readerBooks["BTitle"].ToString());
                readerBooks.Close();

                SqlCommand cmdAuthors = new SqlCommand("SELECT a.AName FROM AUTHOR a", conn);
                SqlDataReader readerAuthors = cmdAuthors.ExecuteReader();
                while (readerAuthors.Read()) authors.Add(readerAuthors["AName"].ToString());
                readerAuthors.Close();

                SqlCommand cmdReaders = new SqlCommand("SELECT r.FName FROM READER r", conn);
                SqlDataReader readerReaders = cmdReaders.ExecuteReader();
                while (readerReaders.Read()) readers.Add(readerReaders["FName"].ToString());
                readerReaders.Close();

                SqlCommand cmdEvents = new SqlCommand("SELECT e.ETitle FROM EVENTS e", conn);
                SqlDataReader readerEvents = cmdEvents.ExecuteReader();
                while (readerEvents.Read()) events.Add(readerEvents["ETitle"].ToString());
                readerEvents.Close();
            }

            if (books.Any(b => b.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)) return "Books";
            if (authors.Any(a => a.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)) return "Authors";
            if (readers.Any(r => r.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)) return "Readers";
            if (events.Any(e => e.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)) return "Events";

            return null;
        }






        //Events
        private void Dashboard_Load(object sender, EventArgs e)
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
        
        private void button9_Click(object sender, EventArgs e)
        {
             string searchTerm = cmbDashboardSearch.Text.Trim();

            // Check if search term is empty
            if (string.IsNullOrEmpty(searchTerm) || searchTerm == "SEARCH AUTHOR, READER, EVENT OR BOOK")
            {
                MessageBox.Show("Please enter a valid search term.");
                return;
            }

            // Detect category using same method logic as HomeSearch
            string searchCategory = DetectSearchCategory(searchTerm);

            if (string.IsNullOrEmpty(searchCategory))
            {
                MessageBox.Show("Search term does not match any known category.");
                return;
            }

            UserControl newControl = null;

            // Load the appropriate UserControl and call the search/filter method
            if (searchCategory == "Books")
            {
                newControl = new LibraryMS2.UserControls.Book();
                //(newControl as LibraryMS2.UserControls.Book).LoadBookByTitle(searchTerm);
            }
            else if (searchCategory == "Authors")
            {
                newControl = new LibraryMS2.UserControls.Author();
                //(newControl as LibraryMS2.UserControls.Author).LoadAuthorByName(searchTerm);
            }
            else if (searchCategory == "Readers")
            {
                newControl = new LibraryMS2.UserControls.Reader();
                //(newControl as LibraryMS2.UserControls.Reader).LoadReaderByName(searchTerm);
            }
            else if (searchCategory == "Events")
            {
                newControl = new LibraryMS2.UserControls.Event();
                //(newControl as LibraryMS2.UserControls.Event).LoadEventByTitle(searchTerm);
            }


            // Add the new control to the panel if it's not null
            if (newControl != null)
            {
                addUserControl(newControl);
            }
       
        }
        
        private void btnOpenCloseMenu_Click(object sender, EventArgs e)
        {
            openMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openMenu();
        }

        private void btnHomeMenu1_Click(object sender, EventArgs e)
        {
            openMenu();
            addUserControl(new LibraryMS2.UserControls.HomeDashboard());
            lblTopSearchBarPanel.Text = "Home";
        }

        private void btnBookMenu1_Click(object sender, EventArgs e)
        {
            openMenu();
            addUserControl(new LibraryMS2.UserControls.Book());
            lblTopSearchBarPanel.Text = "Books";
        }

        private void btnEventMenu1_Click(object sender, EventArgs e)
        {
            openMenu();
            addUserControl(new LibraryMS2.UserControls.Event());
            lblTopSearchBarPanel.Text = "Events";
        }

        private void btnAuthorMenu1_Click(object sender, EventArgs e)
        {
            addUserControl(new LibraryMS2.UserControls.Author());
            lblTopSearchBarPanel.Text = "Author";
            openMenu();
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            openMenu();
            addUserControl(new LibraryMS2.UserControls.Review_Requests());
            lblTopSearchBarPanel.Text = "Review Requests";
        }

        private void btnAuthorBook_Click(object sender, EventArgs e)
        {
            openMenu();
            addUserControl(new LibraryMS2.UserControls.AuthorBook());
            lblTopSearchBarPanel.Text = "Author-Book";
        }

        private void btnAttendEventMenu1_Click(object sender, EventArgs e)
        {
            openMenu();
            addUserControl(new LibraryMS2.UserControls.AttendEvent());
            lblTopSearchBarPanel.Text = "Attend Event";
        }

        private void btnReport2Menu1_Click(object sender, EventArgs e)
        {
            openMenu();
            lblTopSearchBarPanel.Text = "Reports";
        }

        private void btnHelpMenu1_Click(object sender, EventArgs e)
        {
            addUserControl(new LibraryMS2.UserControls.Help());
            lblTopSearchBarPanel.Text = "Help";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openMenu();
            lblTopSearchBarPanel.Text = "Exit";
        }

        private void btnExitMenu2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            HighlightSelectedButton(pnlMenu2, clickedButton);
            Application.Exit();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }

        private void btnSettingsMenu2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            HighlightSelectedButton(pnlMenu2, clickedButton);
            addUserControl(new LibraryMS2.UserControls.Settings());
            lblTopSearchBarPanel.Text = "Settings";
        }

        private void btnHelpMenu2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            HighlightSelectedButton(pnlMenu2, clickedButton);
            addUserControl(new LibraryMS2.UserControls.Help());
            lblTopSearchBarPanel.Text = "Help";
        }

        private void btnBooksReportMenu2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            HighlightSelectedButton(pnlMenu2, clickedButton);
            addUserControl(new LibraryMS2.UserControls.BooksReports());
            lblTopSearchBarPanel.Text = "Top 10 Books";
        }

        private void btnAuthorReportsMenu2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            HighlightSelectedButton(pnlMenu2, clickedButton);
            addUserControl(new LibraryMS2.UserControls.AuthorReports());
            lblTopSearchBarPanel.Text = "Top 10 Authors";
        }

        private void btnEventReportsMenu2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            HighlightSelectedButton(pnlMenu2, clickedButton);
            addUserControl(new LibraryMS2.UserControls.EventReports());
            lblTopSearchBarPanel.Text = "Top 10 Events";
        }

        private void btnRateEvent_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            HighlightSelectedButton(pnlMenu2, clickedButton);
            addUserControl(new LibraryMS2.UserControls.RateEvent());
            lblTopSearchBarPanel.Text = "Rate Event";
        }

        private void btnAttendEventMenu2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            HighlightSelectedButton(pnlMenu2, clickedButton);
            addUserControl(new LibraryMS2.UserControls.AttendEvent());
            lblTopSearchBarPanel.Text = "Attend Event";
        }

        private void btnAuthorBook2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            HighlightSelectedButton(pnlMenu2, clickedButton);
            addUserControl(new LibraryMS2.UserControls.AuthorBook());
            lblTopSearchBarPanel.Text = "Author-Book";
        }

        private void btnRReviews_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            HighlightSelectedButton(pnlMenu2, clickedButton);
            addUserControl(new LibraryMS2.UserControls.Review_Requests());
            lblTopSearchBarPanel.Text = "Review Requests";
        }

        private void btnReaderMenu2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            HighlightSelectedButton(pnlMenu2, clickedButton);
            addUserControl(new LibraryMS2.UserControls.Reader());
            lblTopSearchBarPanel.Text = "Reader";
        }

        private void btnAuthorMenu2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            HighlightSelectedButton(pnlMenu2, clickedButton);
            addUserControl(new LibraryMS2.UserControls.Author());
            lblTopSearchBarPanel.Text = "Author";
        }

        private void btnEventMenu2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            HighlightSelectedButton(pnlMenu2, clickedButton);
            addUserControl(new LibraryMS2.UserControls.Event());
            lblTopSearchBarPanel.Text = "Events";
        }

        private void btnBookMenu2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            HighlightSelectedButton(pnlMenu2, clickedButton);

            addUserControl(new LibraryMS2.UserControls.Book());
            lblTopSearchBarPanel.Text = "Books";
        }

        private void btnHomeMenu2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            HighlightSelectedButton(pnlMenu2, clickedButton);
            addUserControl(new LibraryMS2.UserControls.HomeDashboard());
            lblTopSearchBarPanel.Text = "Home";
        }

        private void btnFunctionsMenu1_Click(object sender, EventArgs e)
        {
            openMenu();
        }

        private void btnReportsMenu1_Click(object sender, EventArgs e)
        {
            openMenu();
        }

        private void btnSearchPage_Click(object sender, EventArgs e)
        {
            addUserControl(new LibraryMS2.UserControls.HomeSearch());
            lblTopSearchBarPanel.Text = "Browser";
        }

        private void pnlMainDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMenu2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
