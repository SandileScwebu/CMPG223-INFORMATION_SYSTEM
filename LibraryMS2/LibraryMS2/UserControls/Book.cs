using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//datagridview stored procedure 
using System.Data.SqlClient;
//print
using System.Drawing.Printing;






namespace LibraryMS2.UserControls
{
    public partial class Book : UserControl
    {
       
        public Book()
        {
            InitializeComponent();
            // Assign event
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        //initialize

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\31765432\Desktop\LibraryMS2\LibraryMS2\LibraryMS_Database.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter da;
        DataTable dt;


        //print
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreview = new PrintPreviewDialog();
        private int totalPages = 0;
        private int currentPage = 1;
        private int totalRecords = 0;

        int currentRow = 0;


        //method

        private void ClearInputs()
        {
            book_TitleComboBox.Text = " ";
            iSBNComboBox.Text = " ";
            priceTextBox.Clear();
            book_YearDateTimePicker.Value = DateTime.Now;
        }

        public void LoadBookByTitle(string title)
        {
            // Ensure that the DataGridView or other controls are being populated correctly.
            MessageBox.Show($"Loading books with title: {title}");

            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BOOK WHERE BTitle LIKE @Title", con);
            da.SelectCommand.Parameters.AddWithValue("@Title", "%" + title + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Assuming there's a DataGridView in Book UserControl
            aLLBOOKSNOIDSDataGridView.DataSource = dt;


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK WHERE BTitle = @title", conn);
                cmd.Parameters.AddWithValue("@title", title);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Assuming you have these controls in Book UC

                    book_TitleComboBox.Text = reader["BTitle"].ToString();
                    iSBNComboBox.Text = reader["ISBN"].ToString();
                    //book_YearDateTimePicker.Value = Convert.ToDateTime(reader["Year"]);
                    priceTextBox.Text = reader["Price"].ToString();

                    // If you use a DataGridView, you can also bind:
                    // dataGridView1.DataSource = ...
                }
            }


        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Brush brush = Brushes.Black;
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int pageWidth = e.MarginBounds.Width;
            int y = topMargin;

            // === Header ===
            string today = DateTime.Now.ToString("yyyy/MM/dd");
            e.Graphics.DrawString(today, font, brush, leftMargin, y);
            e.Graphics.DrawString($"Page {currentPage}", font, brush, leftMargin + pageWidth - 100, y);

            string title = "Books Information";
            SizeF titleSize = e.Graphics.MeasureString(title, headerFont);
            e.Graphics.DrawString(title, headerFont, brush, leftMargin + (pageWidth - titleSize.Width) / 2, y);

            y += 50; // space after header

            // === Column widths based on header/content ===
            List<int> colWidths = new List<int>();
            foreach (DataGridViewColumn col in aLLBOOKSNOIDSDataGridView.Columns)
            {
                int maxWidth = (int)e.Graphics.MeasureString(col.HeaderText, font).Width + 20; // header padding
                foreach (DataGridViewRow row in aLLBOOKSNOIDSDataGridView.Rows)
                {
                    if (row.Cells[col.Index].Value != null)
                    {
                        int cellWidth = (int)e.Graphics.MeasureString(row.Cells[col.Index].Value.ToString(), font).Width + 20;
                        if (cellWidth > maxWidth)
                            maxWidth = cellWidth;
                    }
                }
                colWidths.Add(maxWidth);
            }

            // === Column Headers ===
            int colX = leftMargin;
            for (int i = 0; i < aLLBOOKSNOIDSDataGridView.Columns.Count; i++)
            {
                e.Graphics.DrawString(aLLBOOKSNOIDSDataGridView.Columns[i].HeaderText, font, brush,
                    new RectangleF(colX, y, colWidths[i], font.Height + 5));
                colX += colWidths[i];
            }
            y += font.Height + 10;

            // === Rows ===
            while (currentRow < aLLBOOKSNOIDSDataGridView.Rows.Count)
            {
                DataGridViewRow row = aLLBOOKSNOIDSDataGridView.Rows[currentRow];
                colX = leftMargin;

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    string text = "";
                    if (row.Cells[i].Value != null)
                    {
                        if (row.Cells[i].Value is DateTime dtValue)
                            text = dtValue.ToString("yyyy/MM/dd"); // date only
                        else
                            text = row.Cells[i].Value.ToString();
                    }

                    e.Graphics.DrawString(text, font, brush,
                        new RectangleF(colX, y, colWidths[i], font.Height + 5));

                    colX += colWidths[i];
                }

                y += font.Height + 10;
                currentRow++;

                // Check if next row fits on page
                if (y + font.Height + 10 > e.MarginBounds.Bottom - 60)
                {
                    currentPage++;
                    e.HasMorePages = true;
                    return;
                }
            }

            // === Footer ===
            totalRecords = aLLBOOKSNOIDSDataGridView.Rows.Count;
            y += 20;
            e.Graphics.DrawString($"Total Books: {totalRecords}", font, brush, leftMargin, y);

            string footer = $"Page {currentPage} of {totalPages}";
            SizeF footerSize = e.Graphics.MeasureString(footer, font);
            e.Graphics.DrawString(footer, font, brush, leftMargin + (pageWidth - footerSize.Width) / 2, e.MarginBounds.Bottom + 20);

            e.HasMorePages = false;
        }


        private void LoadBooks()
        {
            SqlConnection con = new SqlConnection(connectionString);
            da = new SqlDataAdapter("ALLBOOKSNOIDS", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            da.Fill(dt);

            aLLBOOKSNOIDSDataGridView.DataSource = dt;
        }

        private void FilterAndPopulateControlsByColumn()
        {
            if (dt == null) return; // dt = DataTable bound to DataGridView

            string selectedTitle = book_TitleComboBox.Text.Trim();
            string selectedISBN = iSBNComboBox.Text.Trim();

            string filter = "";

            if (!string.IsNullOrEmpty(selectedTitle))
                filter += $"[Book Title] = '{selectedTitle.Replace("'", "''")}'";

            if (!string.IsNullOrEmpty(selectedISBN))
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"[ISBN] = '{selectedISBN.Replace("'", "''")}'";
            }

            DataView dv = new DataView(dt);
            dv.RowFilter = filter;

            aLLBOOKSNOIDSDataGridView.DataSource = dv;

            // Auto-populate controls for the first matching row
            if (dv.Count > 0)
            {
                DataRowView row = dv[0];
                book_TitleComboBox.Text = row["Book Title"].ToString();
                iSBNComboBox.Text = row["ISBN"].ToString();
                priceTextBox.Text = row["Price"].ToString();

                if (DateTime.TryParse(row["Book Year"].ToString(), out DateTime year))
                    book_YearDateTimePicker.Value = year;
            }
        }
        private void bOOKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bOOKBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryMS_DatabaseDataSet);

        }


        //event


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboboxTitle()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT b.BTitle FROM BOOK b", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    book_TitleComboBox.Items.Add(reader["BTitle"].ToString());
                }
                reader.Close();
            }

            book_TitleComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            book_TitleComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            book_TitleComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void comboboxISBN()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT b.ISBN FROM BOOK b", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    iSBNComboBox.Items.Add(reader["ISBN"].ToString());
                }
                reader.Close();
            }
        }

        private void Book_Load(object sender, EventArgs e)
        {
            rbHideISBN.CheckedChanged += radioButton1_CheckedChanged;
            rbShowISBN.CheckedChanged += rbShowISBN_CheckedChanged;

            rbBookTitle.CheckedChanged += radioButton3_CheckedChanged;
            rbPrice.CheckedChanged += radioButton4_CheckedChanged;

            this.aLLBOOKSNOIDSTableAdapter.Fill(this.libraryMS_DatabaseDataSet.ALLBOOKSNOIDS);

            //ComboBox Title Books
            comboboxTitle();

            //ComboBox ISBN
            comboboxISBN();
            

            iSBNComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            iSBNComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            iSBNComboBox.DropDownStyle = ComboBoxStyle.DropDown;

            ////Add to datagridview from stored procedure

            SqlConnection con = new SqlConnection(connectionString);
            da = new SqlDataAdapter("ALLBOOKSNOIDS", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            da.Fill(dt);

            aLLBOOKSNOIDSDataGridView.DataSource = dt;

            ClearInputs();
        }

        private void aLLBOOKSNOIDSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            using (conn)
            {

                SqlCommand cmd = new SqlCommand("ALLBOOKSNOIDS", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                aLLBOOKSNOIDSDataGridView.DataSource = dt;
            }
        }

        private int selectedBookID = -1;

        private void btnSaveBooksForm_Click(object sender, EventArgs e)
        {
            if (selectedBookID == -1)
            {
                MessageBox.Show("Please select a book to update.");
                return;
            }

            SqlConnection con = new SqlConnection(connectionString);
            using (SqlCommand cmd = new SqlCommand("ALLBOOKSNOIDSUPDATE", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Book_ID", SqlDbType.Int) { Value = selectedBookID });
                cmd.Parameters.Add(new SqlParameter("@BTitle", SqlDbType.VarChar, 55) { Value = book_TitleComboBox.Text });
                cmd.Parameters.Add(new SqlParameter("@ISBN", SqlDbType.Char, 13) { Value = iSBNComboBox.Text });

                if (!decimal.TryParse(priceTextBox.Text, out decimal price))
                {
                    MessageBox.Show("Please enter a valid price (e.g., 12.50).");
                    return;
                }
                cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.SmallMoney) { Value = price });

                cmd.Parameters.Add(new SqlParameter("@BYear", SqlDbType.Date) { Value = book_YearDateTimePicker.Value });

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show($"{rowsAffected} book(s) updated.");
            }

            LoadBooks();
            book_TitleComboBox.Items.Clear();
            comboboxTitle();
            iSBNComboBox.Items.Clear();
            comboboxISBN();
        }

        private void book_TitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select datagridview

            string selectedValue = book_TitleComboBox.Text;

            foreach (DataGridViewRow row in aLLBOOKSNOIDSDataGridView.Rows)
            {
                if (row.Cells["dataGridViewTextBoxColumn6"].Value != null && row.Cells["dataGridViewTextBoxColumn6"].Value.ToString() == selectedValue)
                {
                    row.Selected = true;
                    aLLBOOKSNOIDSDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                }
                else
                {
                    row.Selected = false;
                }
            }

            //populate controls when selected from combobox
            foreach (DataGridViewRow row in aLLBOOKSNOIDSDataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == selectedValue) // Column 0 = Book Title
                {
                    row.Selected = true;
                    aLLBOOKSNOIDSDataGridView.FirstDisplayedScrollingRowIndex = row.Index;

                    // Fill controls from selected row
                    iSBNComboBox.Text = row.Cells[1].Value.ToString();         // ISBN
                    priceTextBox.Text = row.Cells[2].Value.ToString();         // Price
                    book_YearDateTimePicker.Value = Convert.ToDateTime(row.Cells[3].Value); // Year
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void iSBNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = iSBNComboBox.Text;

            foreach (DataGridViewRow row in aLLBOOKSNOIDSDataGridView.Rows)
            {
                if (row.Cells["dataGridViewTextBoxColumn7"].Value != null && row.Cells["dataGridViewTextBoxColumn7"].Value.ToString() == selectedValue)
                {
                    row.Selected = true;
                    aLLBOOKSNOIDSDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                }
                else
                {
                    row.Selected = false;
                }
            }

            //

            foreach (DataGridViewRow row in aLLBOOKSNOIDSDataGridView.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == selectedValue) // Column 1 = ISBN
                {
                    row.Selected = true;
                    aLLBOOKSNOIDSDataGridView.FirstDisplayedScrollingRowIndex = row.Index;

                    // Fill controls from selected row
                    if (row.Cells[0].Value != DBNull.Value && row.Cells[0].Value != null)
                    {
                        book_TitleComboBox.Text = row.Cells[0].Value.ToString();
                    }
                    else
                    {
                        // Handle the case when the value is null or DBNull
                        book_TitleComboBox.Text = "No title available"; // or any default value you prefer
                    }
                    priceTextBox.Text = row.Cells[2].Value.ToString();       // Price
                    if (row.Cells[3].Value != DBNull.Value && row.Cells[3].Value != null)
                    {
                        DateTime dateValue;
                        if (DateTime.TryParse(row.Cells[3].Value.ToString(), out dateValue))
                        {
                            // Check if the date is within the valid range
                            if (dateValue >= DateTime.MinValue.Date && dateValue <= DateTime.MaxValue.Date)
                            {
                                // Set only the date part

                            }
                        }
                    }
                }
            }
        }

        private void btnAddBooksForm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            //add to db
            using (SqlCommand cmd = new SqlCommand("ALLBOOKSNOIDSINSERT", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BTitle", book_TitleComboBox.Text);
                cmd.Parameters.AddWithValue("@ISBN", iSBNComboBox.Text);
                decimal price;
                if (!decimal.TryParse(priceTextBox.Text, out price))
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }

                cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.SmallMoney) { Value = price });
                cmd.Parameters.AddWithValue("@BYear", book_YearDateTimePicker.Value);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Book added successfully!");
                
            }
            ClearInputs();
            LoadBooks();
            book_TitleComboBox.Items.Clear();
            comboboxTitle();
            iSBNComboBox.Items.Clear();
            comboboxISBN();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadBooks();
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteBooksForm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                using (SqlCommand cmd = new SqlCommand("ALLBOOKSNOIDSDELETE", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@BTitle", SqlDbType.VarChar, 55) { Value = book_TitleComboBox.Text });
                    cmd.Parameters.Add(new SqlParameter("@ISBN", SqlDbType.Char, 13) { Value = iSBNComboBox.Text });

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show($"{rowsAffected} book(s) deleted.");
                }

                LoadBooks(); // Refresh DataGridView
                book_TitleComboBox.Items.Clear();
                comboboxTitle();
                iSBNComboBox.Items.Clear();
                comboboxISBN();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Foreign key violation
                {
                    MessageBox.Show("Cannot delete this book because it is linked to existing events.",
                                    "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("An error occurred: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            currentRow = 0;
            currentPage = 1;

            // Estimate total pages
            int rowsPerPage = (printDocument.DefaultPageSettings.Bounds.Height - 200) / 25;
            totalRecords = aLLBOOKSNOIDSDataGridView.Rows.Count;
            totalPages = (int)Math.Ceiling((double)totalRecords / rowsPerPage);

            printPreview.Document = printDocument;
            printPreview.ShowDialog();
        }

        private void btnRefreshTable_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.btnRefreshTable, "Update books table");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the Dashboard form
            Dashboard dash = (Dashboard)this.FindForm();
            // Then load HomeDashboard (or whichever you want last visible)
            dash.addUserControl(new LibraryMS2.UserControls.HomeDashboard());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Get the Dashboard form
            Dashboard dash = (Dashboard)this.FindForm();
            // Then load HomeDashboard (or whichever you want last visible)
            dash.addUserControl(new LibraryMS2.UserControls.HelpBooks());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void ToggleISBNColumn()
        {
            if (aLLBOOKSNOIDSDataGridView.Columns.Count > 0)
            {
                string isbnColumnName = "ISBN"; // Replace with actual column name or use index
                if (rbHideISBN.Checked)
                {
                    aLLBOOKSNOIDSDataGridView.Columns[1].Visible = false;
                }
                else if (rbShowISBN.Checked)
                {
                    aLLBOOKSNOIDSDataGridView.Columns[1].Visible = true;
                }
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ToggleISBNColumn();
        }

        private void ToggleSort()
        {
            if (aLLBOOKSNOIDSDataGridView.DataSource == null) return;

            if (rbBookTitle.Checked)
            {
                // Sort by Title ascending
                aLLBOOKSNOIDSDataGridView.Sort(aLLBOOKSNOIDSDataGridView.Columns[0], ListSortDirection.Ascending);
            }
            else if (rbPrice.Checked)
            {
                // Sort by Price ascending
                aLLBOOKSNOIDSDataGridView.Sort(aLLBOOKSNOIDSDataGridView.Columns[2], ListSortDirection.Ascending);
            }
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSort();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSort();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbShowISBN_CheckedChanged(object sender, EventArgs e)
        {
            ToggleISBNColumn();
        }

        private void book_TitleComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string selectedValue = book_TitleComboBox.Text;

            foreach (DataGridViewRow row in aLLBOOKSNOIDSDataGridView.Rows)
            {
                if (row.Cells[0].Value != null &&
                    row.Cells[0].Value.ToString() == selectedValue)
                {
                    row.Selected = true;
                    aLLBOOKSNOIDSDataGridView.FirstDisplayedScrollingRowIndex = row.Index;

                    // Capture Book_ID safely
                    if (row.Cells[4].Value != null && int.TryParse(row.Cells[4].Value.ToString(), out int bookID))
                    {
                        selectedBookID = bookID;
                    }

                    // Populate ISBN
                    if (row.Cells[1].Value != null)
                        iSBNComboBox.Text = row.Cells[1].Value.ToString();
                    else
                        iSBNComboBox.Text = "";

                    // Populate Price
                    if (row.Cells[2].Value != null)
                        priceTextBox.Text = Convert.ToDecimal(row.Cells[2].Value).ToString("F2");

                    // Populate Date safely
                    if (row.Cells[3].Value != null && DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime dateValue))
                    {
                        if (dateValue >= book_YearDateTimePicker.MinDate && dateValue <= book_YearDateTimePicker.MaxDate)
                            book_YearDateTimePicker.Value = dateValue;
                        else
                            book_YearDateTimePicker.Value = DateTime.Now;
                    }
                    else
                    {
                        book_YearDateTimePicker.Value = DateTime.Now;
                    }

                    break; // Stop after finding the first match
                }
            }

        }
    }
}
