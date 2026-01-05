using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryMS2
{
    public partial class LoginForm : Form
    {

        

        public LoginForm()
        {
            InitializeComponent();
        }

        // Define a simple password (you can change this later or store it securely)
        private const string correctPassword = "admin";
        private const string correctPassword2 = "user";

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            // Check if the entered password matches the correct password
            if (txtPassword.Text == correctPassword)
            {
                // If correct, close the login form and open the main form
                MessageBox.Show("Login Successful", "Access granted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Hide login form

                Dashboard mainForm = new Dashboard(false); // Pass false if not user
                mainForm.Show();
            }
            else if (txtPassword.Text == correctPassword2)
            {
                // If correct, close the login form and open the main form
                MessageBox.Show("Login Successful", "Access granted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Hide login form

                Dashboard mainForm = new Dashboard(true); // Pass true if user
                mainForm.Show();
            }
            else
            {
                txtPassword.Text = "";
                lblError.Text = "Incorrect password. Please try again.";
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }
    }
}
