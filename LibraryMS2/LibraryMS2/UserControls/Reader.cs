using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//SQL
using System.Data.SqlClient;
namespace LibraryMS2.UserControls
{
    public partial class Reader : UserControl
    {
        public Reader()
        {
            InitializeComponent();
        }
        //intial

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\31765432\Desktop\LibraryMS2\LibraryMS2\LibraryMS_Database.mdf;Integrated Security=True;Connect Timeout=30";

        private DataTable readersTable;

        //method

        //Method
        private DataTable ExecuteStoredProcedure(string procedureName, params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(procedureName, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        private void ExecuteNonQuery(string procedureName, params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(procedureName, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void LoadComboBox(ComboBox combo, string query, string column)
        {
            combo.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        combo.Items.Add(reader[column].ToString());
                }
            }
        }



        private void LoadReaders()
        {
            readersTable = ExecuteStoredProcedure("ALLREADERSNOIDS");
            aLLREADERSNOIDSDataGridView.DataSource = readersTable;

            // Hide columns used only internally
            if (aLLREADERSNOIDSDataGridView.Columns.Count >= 6)
            {
                aLLREADERSNOIDSDataGridView.Columns[0].Visible = false; // FName
                aLLREADERSNOIDSDataGridView.Columns[1].Visible = false; // LName
            }

        }

        private void ClearInputs()
        {
            fNameComboBox.Text = "";
            lNameComboBox.Text = "";
            emailTextBox.Clear();
            date_of_BirthDateTimePicker.Value = DateTime.Now;
            genderRadioButton.Checked = false;
            genderRadioButton2.Checked = false;
        }

        private void SelectReaderRow(DataGridViewRow row)
        {
            fNameComboBox.Text = row.Cells[0].Value?.ToString() ?? "";
            lNameComboBox.Text = row.Cells[1].Value?.ToString() ?? "";
            emailTextBox.Text = row.Cells[3].Value?.ToString() ?? "";

            var genderValue = row.Cells[4].Value?.ToString();
            genderRadioButton.Checked = genderValue == "Male";
            genderRadioButton2.Checked = genderValue == "Female";

            // Safe DateOfBirth assignment
            if (row.Cells[5].Value != DBNull.Value)
            {
                DateTime dob = Convert.ToDateTime(row.Cells[5].Value);
                if (dob < date_of_BirthDateTimePicker.MinDate)
                    dob = date_of_BirthDateTimePicker.MinDate;
                else if (dob > date_of_BirthDateTimePicker.MaxDate)
                    dob = date_of_BirthDateTimePicker.MaxDate;

                date_of_BirthDateTimePicker.Value = dob;
            }
            else
            {
                date_of_BirthDateTimePicker.Value = DateTime.Now;
            }

        }


        public void LoadReaderByName(string name)
        {
            if (string.IsNullOrEmpty(name)) return;

            var filteredRows = readersTable.AsEnumerable()
                .Where(r => r.Field<string>("FName").Equals(name, StringComparison.OrdinalIgnoreCase));

            if (!filteredRows.Any())
            {
                MessageBox.Show("No reader found with that name.");
                return;
            }

            DataTable dtFiltered = filteredRows.CopyToDataTable();
            aLLREADERSNOIDSDataGridView.DataSource = dtFiltered;

            SelectReaderRow(aLLREADERSNOIDSDataGridView.Rows[0]);
        }

        //event



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reader_Load(object sender, EventArgs e)
        {
            LoadComboBox(fNameComboBox, "SELECT FName FROM READER", "FName");
            LoadComboBox(lNameComboBox, "SELECT LName FROM READER", "LName");

            fNameComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            fNameComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            lNameComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            lNameComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            aLLREADERSNOIDSDataGridView.SelectionChanged += (s, ev) =>
            {
                if (aLLREADERSNOIDSDataGridView.CurrentRow != null)
                    SelectReaderRow(aLLREADERSNOIDSDataGridView.CurrentRow);
            };

            LoadReaders();
        }

        private void btnAddBooksForm_Click(object sender, EventArgs e)
        {
            ExecuteNonQuery("ALLREADERSNOIDSINSERT",
            new SqlParameter("@FName", fNameComboBox.Text),
            new SqlParameter("@LName", lNameComboBox.Text),
            new SqlParameter("@Email", emailTextBox.Text),
            new SqlParameter("@isGender", genderRadioButton.Checked),
            new SqlParameter("@BDate", date_of_BirthDateTimePicker.Value)
            );

            MessageBox.Show("Reader added successfully!");
            ClearInputs();
            LoadReaders();
        }

        private void btnDeleteBooksForm_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteNonQuery("ALLREADERSNOIDSDELETE",
                    new SqlParameter("@FName", fNameComboBox.Text),
                    new SqlParameter("@LName", lNameComboBox.Text)
                );

                MessageBox.Show("Reader deleted successfully!");
                LoadReaders();
            }
            catch (SqlException ex)
            {
                // Check for foreign key violation
                if (ex.Number == 547) // FK constraint violation
                {
                    MessageBox.Show(
                        "Cannot delete this reader because they are linked to one or more events. " +
                        "Please remove their event attendance records first.",
                        "Delete Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveBooksForm_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(fNameComboBox.Text) || string.IsNullOrEmpty(lNameComboBox.Text))
            {
                MessageBox.Show("Please select a reader to update.");
                return;
            }

            try
            {
                ExecuteNonQuery("ALLREADERSNOIDSUPDATE",
                    new SqlParameter("@FName", fNameComboBox.Text),
                    new SqlParameter("@LName", lNameComboBox.Text),
                    new SqlParameter("@Email", emailTextBox.Text),
                    new SqlParameter("@isGender", genderRadioButton.Checked), // true for Male, false for Female
                    new SqlParameter("@BDate", date_of_BirthDateTimePicker.Value)
                );

                MessageBox.Show("Reader updated successfully!");
                LoadReaders();  // Refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating reader: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the Dashboard form
            Dashboard dash = (Dashboard)this.FindForm();


            // Then load HomeDashboard (or whichever you want last visible)
            dash.addUserControl(new LibraryMS2.UserControls.HomeDashboard());
        }

        private void lNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void date_of_BirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void aLLREADERSNOIDSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HighlightReaderRow()
        {
            string fName = fNameComboBox.Text.Trim();
            string lName = lNameComboBox.Text.Trim();

            foreach (DataGridViewRow row in aLLREADERSNOIDSDataGridView.Rows)
            {
                // Compare FName and LName
                bool match = true;

                if (!string.IsNullOrEmpty(fName))
                    match &= row.Cells[0].Value?.ToString() == fName;

                if (!string.IsNullOrEmpty(lName))
                    match &= row.Cells[1].Value?.ToString() == lName;

                row.Selected = match;

                // Scroll to first match
                if (match)
                {
                    aLLREADERSNOIDSDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                    // Also populate the inputs
                    SelectReaderRow(row);
                    break; // stop after first match
                }
            }
        }

        private void aLLREADERSNOIDSDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void fNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lNameComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}
