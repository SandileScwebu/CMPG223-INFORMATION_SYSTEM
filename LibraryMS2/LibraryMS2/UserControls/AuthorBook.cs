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
namespace LibraryMS2.UserControls
{
    public partial class AuthorBook : UserControl
    {
        public AuthorBook()
        {
            InitializeComponent();
            aUTHORSBOOKSDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            aUTHORSBOOKSDataGridView.MultiSelect = false;
        }
        //initial

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\31765432\Desktop\LibraryMS2\LibraryMS2\LibraryMS_Database.mdf;Integrated Security=True;Connect Timeout=30";
        private DataTable allBooksTable;

        private void LoadAuthors()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Author_ID, AName + ' ' + ALName AS AuthorName FROM AUTHOR";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                author_NameComboBox.DataSource = dt;
                author_NameComboBox.DisplayMember = "AuthorName";
                author_NameComboBox.ValueMember = "Author_ID";
            }
        }

        //events
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //methods

        private void LoadBooks()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Book_ID, BTitle FROM BOOK";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                allBooksTable = new DataTable();
                da.Fill(allBooksTable);

                book_TitleComboBox.DataSource = allBooksTable.Copy(); // initial full copy
                book_TitleComboBox.DisplayMember = "BTitle";
                book_TitleComboBox.ValueMember = "Book_ID";
            }
        }

        private void AuthorBook_Load(object sender, EventArgs e)
        {
            LoadAuthors();
            LoadBooks();
            LoadAuthorBooks();

            
            author_NameComboBox.SelectedIndexChanged += author_NameComboBox_SelectedIndexChanged;
        }


        private void LoadAuthorBooks(int? authorId = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("EXEC AUTHORSBOOKS", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (authorId.HasValue)
                {
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = $"Author_ID = {authorId.Value}";
                    aUTHORSBOOKSDataGridView.DataSource = dv;
                }
                else
                {
                    aUTHORSBOOKSDataGridView.DataSource = dt;
                }

                // --- FORMAT PRICE COLUMNS ---
                if (aUTHORSBOOKSDataGridView.Columns.Contains("Price"))
                {
                    aUTHORSBOOKSDataGridView.Columns["Price"].DefaultCellStyle.Format = "N2"; // 2 decimals
                }

                if (aUTHORSBOOKSDataGridView.Columns.Contains("UnitPrice"))
                {
                    aUTHORSBOOKSDataGridView.Columns["UnitPrice"].DefaultCellStyle.Format = "N2"; // 2 decimals
                }
            }
        }


        

        private void btnAssign_Click(object sender, EventArgs e)
        {
            int authorId = (int)author_NameComboBox.SelectedValue;
            int bookId = (int)book_TitleComboBox.SelectedValue;
            int quantity = (int)number_Of_BooksNumericUpDown.Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Check if the record already exists
                string checkQuery = "SELECT COUNT(*) FROM AUTHORBOOK WHERE Author_ID = @Author_ID AND Book_ID = @Book_ID";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@Author_ID", authorId);
                checkCmd.Parameters.AddWithValue("@Book_ID", bookId);

                con.Open();
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    // Record already exists, show message
                    MessageBox.Show("This book is already assigned to the selected author.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Record doesn't exist, proceed with insertion
                    SqlCommand cmd = new SqlCommand("ASSIGN_BOOK_TO_AUTHOR", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Author_ID", authorId);
                    cmd.Parameters.AddWithValue("@Book_ID", bookId);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.ExecuteNonQuery();

                    // Reload the list of author-books
                    LoadAuthorBooks();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            int authorId = (int)author_NameComboBox.SelectedValue;
            int bookId = (int)book_TitleComboBox.SelectedValue;
            int quantity = (int)number_Of_BooksNumericUpDown.Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UPDATE_AUTHORBOOK", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Author_ID", authorId);
                cmd.Parameters.AddWithValue("@Book_ID", bookId);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            LoadAuthorBooks();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int authorId = (int)author_NameComboBox.SelectedValue;
            int bookId = (int)book_TitleComboBox.SelectedValue;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("REMOVE_AUTHORBOOK", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Author_ID", authorId);
                cmd.Parameters.AddWithValue("@Book_ID", bookId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            LoadAuthorBooks();
        }

        private void author_NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (author_NameComboBox.SelectedValue == null)
                return; // nothing selected, skip

            int authorId = Convert.ToInt32(author_NameComboBox.SelectedValue);

            // Filter DataGridView
            LoadAuthorBooks(authorId);

            // Reduce Book ComboBox
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT b.Book_ID, b.BTitle 
                         FROM AUTHORBOOK ab
                         JOIN BOOK b ON ab.Book_ID = b.Book_ID
                         WHERE ab.Author_ID = @Author_ID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@Author_ID", authorId);
                DataTable dtAuthorBooks = new DataTable();
                da.Fill(dtAuthorBooks);

                // Merge filtered with all books
                DataTable combined = allBooksTable.Copy();
                foreach (DataRow row in dtAuthorBooks.Rows)
                {
                    if (!combined.AsEnumerable().Any(r => r.Field<int>("Book_ID") == (int)row["Book_ID"]))
                    {
                        combined.ImportRow(row);
                    }
                }

                book_TitleComboBox.DataSource = combined;
                book_TitleComboBox.DisplayMember = "BTitle";
                book_TitleComboBox.ValueMember = "Book_ID";
            }

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

        private void aUTHORSBOOKSDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (aUTHORSBOOKSDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = aUTHORSBOOKSDataGridView.SelectedRows[0];

                // Access columns by name, not index
                if (row.Cells[0].Value != DBNull.Value)
                {
                    int authorId = Convert.ToInt32(row.Cells[0].Value);
                    author_NameComboBox.SelectedValue = authorId;
                }

                if (row.Cells[2].Value != DBNull.Value)
                {
                    string bookTitle = Convert.ToString(row.Cells[2].Value);
                    DataTable dt = (DataTable)book_TitleComboBox.DataSource;
                    DataRow[] foundRows = dt.Select($"BTitle = '{bookTitle.Replace("'", "''")}'");
                    if (foundRows.Length > 0)
                    {
                        int bookId = Convert.ToInt32(foundRows[0]["Book_ID"]);
                        book_TitleComboBox.SelectedValue = bookId;
                    }
                }

                if (row.Cells[3].Value != DBNull.Value)
                {
                    number_Of_BooksNumericUpDown.Value = Convert.ToInt32(row.Cells[3].Value);
                }
            }
        }

        private void aUTHORSBOOKSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
