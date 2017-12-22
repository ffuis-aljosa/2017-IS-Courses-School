using System;
using System.Windows.Forms;
using Courses_School.Database;
using Courses_School.Models;

namespace Courses_School
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(usernameTextBox.Text, passwordTextBox.Text);

                if (UserRepository.login(user))
                {
                    administratorForm form = new administratorForm();
                    form.Show();

                    form.FormClosed += administratorForm_FormClosed;

                    Hide();
                }
                else
                {
                    throw new Exception("Korisničko ime i/ili lozinka su pogrešni");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void administratorForm_FormClosed (object sender, FormClosedEventArgs e)
        {
            Show();
        }

    }  
}
