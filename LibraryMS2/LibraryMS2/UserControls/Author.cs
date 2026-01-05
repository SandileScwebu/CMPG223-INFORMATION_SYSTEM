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
    public partial class Author : UserControl
    {
        public Author()
        {
            InitializeComponent();
        }

        //initial

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\31765432\Desktop\LibraryMS2\LibraryMS2\LibraryMS_Database.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter da;
        DataTable dt;
        private bool isUpdating = false;


        //method

        private void ClearInputs()
        {
            aNameComboBox.Text = " ";
            aLNameComboBox.Text = " ";
            emailTextBox.Clear();
            date_of_BirthDateTimePicker.Value = DateTime.Now;
            genderRadioButton.Checked = false;
        }

        private void LoadAuthors()
        {
            SqlConnection con = new SqlConnection(connectionString);
            da = new SqlDataAdapter("ALLAUTHORNOIDS", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            da.Fill(dt);

            aLLAUTHORNOIDSDataGridView.DataSource = dt;
        }

        public void LoadAuthorByName(string name)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("ALLAUTHORNOIDS", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Filter authors by name
            var rows = dt.AsEnumerable().Where(row => row.Field<string>("AName").Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();

            // Set DataGridView and auto-select the row
            aLLAUTHORNOIDSDataGridView.DataSource = rows.CopyToDataTable();

            if (rows.Count > 0)
            {
                var row = rows.First();
                aNameComboBox.Text = row["AName"].ToString();
                aLNameComboBox.Text = row["ALName"].ToString();
                emailTextBox.Text = row["Email"].ToString();
                genderRadioButton.Checked = row["Gender"].ToString() == "Male";  // assuming Male/Female as gender values
                date_of_BirthDateTimePicker.Value = Convert.ToDateTime(row["Date Of Birth"]);
            }


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM AUTHOR WHERE AName = @name", conn);
                cmd.Parameters.AddWithValue("@name", name);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    aNameComboBox.Text = reader["AName"].ToString();
                    aLNameComboBox.Text = reader["ALName"].ToString();
                    emailTextBox.Text = reader["Email"].ToString();
                }
            }

        }

        //event


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Author_Load(object sender, EventArgs e)
        {
            //Combobox Name Fill
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT AName FROM AUTHOR", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    aNameComboBox.Items.Add(reader["AName"].ToString());
                }
                reader.Close();
            }

            aNameComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            aNameComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            aNameComboBox.DropDownStyle = ComboBoxStyle.DropDown;


            //ComboBox Last Name
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ALName FROM AUTHOR", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    aLNameComboBox.Items.Add(reader["ALName"].ToString());
                }
                reader.Close();
            }

            aLNameComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            aLNameComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            aLNameComboBox.DropDownStyle = ComboBoxStyle.DropDown;


            ClearInputs();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ALLAUTHORNOIDS", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    aLLAUTHORNOIDSDataGridView.DataSource = dt;

                    // Hide first two columns (AName, ALName)
                    if (aLLAUTHORNOIDSDataGridView.Columns.Count > 2)
                    {
                        aLLAUTHORNOIDSDataGridView.Columns[0].Visible = false; // First Name
                        aLLAUTHORNOIDSDataGridView.Columns[1].Visible = false; // Last Name
                    }

                    // Optionally, rename the header for Author Name column
                    if (aLLAUTHORNOIDSDataGridView.Columns.Count > 2)
                        aLLAUTHORNOIDSDataGridView.Columns[2].HeaderText = "Author Name";
                }
            }
            ClearInputs();

        }

        private void aNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select datagridview

            string selectedValue = aLNameComboBox.Text;

            foreach (DataGridViewRow row in aLLAUTHORNOIDSDataGridView.Rows)
            {
                if (row.Cells["dataGridViewTextBoxColumn2"].Value != null && row.Cells["dataGridViewTextBoxColumn2"].Value.ToString() == selectedValue)
                {
                    row.Selected = true;
                    aLLAUTHORNOIDSDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                }
                else
                {
                    row.Selected = false;
                }
            }


            //populate controls when selected from combobox


            foreach (DataGridViewRow row in aLLAUTHORNOIDSDataGridView.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == selectedValue)
                {
                    row.Selected = true;
                    aLLAUTHORNOIDSDataGridView.FirstDisplayedScrollingRowIndex = row.Index;

                    // Fill controls
                    aNameComboBox.Text = row.Cells[0].Value.ToString();
                    emailTextBox.Text = row.Cells[3].Value.ToString();
                    genderRadioButton.Checked = row.Cells[4].Value.ToString() == "Male";
                    date_of_BirthDateTimePicker.Value = Convert.ToDateTime(row.Cells[5].Value);
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnAddBooksForm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            //add to db
            using (SqlCommand cmd = new SqlCommand("ALLAUTHORNOIDSINSERT", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AName", aNameComboBox.Text);
                cmd.Parameters.AddWithValue("@ALName", aLNameComboBox.Text);
                cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                //decimal price;
                //if (!decimal.TryParse(priceTextBox.Text, out price))
                //{
                //    MessageBox.Show("Please enter a valid price.");
                //    return;
                //}
                bool isGender = genderRadioButton.Checked; // true = male (1), false = female (0)

                cmd.Parameters.AddWithValue("@isGender", isGender);

                cmd.Parameters.Add(new SqlParameter("@BYear", SqlDbType.Date) { Value = date_of_BirthDateTimePicker.Value });

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Author added successfully!");
            }
            ClearInputs();
            LoadAuthors();
        }

        private void btnDeleteBooksForm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            using (SqlCommand cmd = new SqlCommand("ALLAUTHORNOIDSDELETE", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AName", aNameComboBox.Text);
                cmd.Parameters.AddWithValue("@ALName", aLNameComboBox.Text);
                cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show($"{rowsAffected} author deleted.");
            }

            LoadAuthors();
        }

        private void aLNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select datagridview

            string selectedValue = aNameComboBox.Text;

            foreach (DataGridViewRow row in aLLAUTHORNOIDSDataGridView.Rows)
            {
                if (row.Cells["dataGridViewTextBoxColumn1"].Value != null && row.Cells["dataGridViewTextBoxColumn1"].Value.ToString() == selectedValue)
                {
                    row.Selected = true;
                    aLLAUTHORNOIDSDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                }
                else
                {
                    row.Selected = false;
                }
            }


            //populate controls when selected from combobox


            foreach (DataGridViewRow row in aLLAUTHORNOIDSDataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == selectedValue)
                {
                    row.Selected = true;
                    aLLAUTHORNOIDSDataGridView.FirstDisplayedScrollingRowIndex = row.Index;

                    // Fill controls
                    aLNameComboBox.Text = row.Cells[1].Value.ToString();
                    emailTextBox.Text = row.Cells[3].Value.ToString();
                    genderRadioButton.Checked = row.Cells[4].Value.ToString() == "Male";
                    date_of_BirthDateTimePicker.Value = Convert.ToDateTime(row.Cells[5].Value);
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void aLLAUTHORNOIDSDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;
            isUpdating = true;

            if (aLLAUTHORNOIDSDataGridView.CurrentRow != null)
            {
                var row = aLLAUTHORNOIDSDataGridView.CurrentRow;

                aNameComboBox.Text = row.Cells[0].Value.ToString();
                aLNameComboBox.Text = row.Cells[1].Value.ToString();
                emailTextBox.Text = row.Cells[3].Value.ToString();
                genderRadioButton.Checked = row.Cells[4].Value.ToString() == "Male";
                date_of_BirthDateTimePicker.Value = (DateTime)row.Cells[5].Value;

            }

            isUpdating = false;
        }

        private void btnSaveBooksForm_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(aNameComboBox.Text) ||
                string.IsNullOrWhiteSpace(aLNameComboBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("ALLAUTHORNOIDSUPDATE", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Pass parameters for the author update
                cmd.Parameters.AddWithValue("@AName", aNameComboBox.Text);
                cmd.Parameters.AddWithValue("@ALName", aLNameComboBox.Text);
                cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                bool isGender = genderRadioButton.Checked; // true = Male, false = Female
                cmd.Parameters.AddWithValue("@isGender", isGender);
                cmd.Parameters.Add(new SqlParameter("@BYear", SqlDbType.Date) { Value = date_of_BirthDateTimePicker.Value });

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show($"{rowsAffected} author updated successfully!");
            }

            // Refresh DataGridView
            LoadAuthors();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the Dashboard form
            Dashboard dash = (Dashboard)this.FindForm();

            dash.addUserControl(new LibraryMS2.UserControls.HomeDashboard());
        }

        private void date_of_BirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}
