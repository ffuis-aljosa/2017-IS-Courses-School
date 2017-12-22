using System;
using System.Windows.Forms;
using Courses_School.Database;
using Courses_School.Models;

namespace Courses_School
{
    public partial class newUserForm : Form
    {
        public newUserForm()
        {
            InitializeComponent();
        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordTextBox.Text != repeatPasswordTextBox.Text)
                    throw new Exception("Lozinka i ponovljena lozinka nisu iste");

                User user = new User(usernameTextBox.Text, passwordTextBox.Text);

                UserRepository.createUser(user);

                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
                repeatPasswordTextBox.Text = "";

                MessageBox.Show("Korisnik uspješno kreiran");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
