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
            usernameTextBox.MouseHover += new EventHandler(usernameTextBox_MouseHover);
            usernameTextBox.MouseLeave += new EventHandler(usernameTextBox_MouseLeave);

            passwordTextBox.MouseHover += new EventHandler(passwordTextBox_MouseHover);
            passwordTextBox.MouseLeave += new EventHandler(passwordTextBox_MouseLeave);
        }

        ToolTip toolTip1 = new ToolTip();
        void usernameTextBox_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(usernameTextBox);
        }
        void usernameTextBox_MouseHover(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {

                toolTip1.ToolTipTitle = "Caps Lock Is On";
                toolTip1.ToolTipIcon = ToolTipIcon.Warning;
                toolTip1.IsBalloon = true;
                toolTip1.SetToolTip(usernameTextBox, "Ako je Caps Lock uključen, možete pogrešno unijeti korisničko ime.\n\nIsključite Caps Lock prije unošenja korisničkog imena.");
                toolTip1.Show("Ako je Caps Lock uključen, možete pogrešno unijeti korisničko ime.\n\nIsključite Caps Lock prije unošenja korisničkog imena.", usernameTextBox, 5, usernameTextBox.Height - 5);
            }
        }

        void passwordTextBox_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(passwordTextBox);
        } 
        void passwordTextBox_MouseHover(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {

                toolTip1.ToolTipTitle = "Caps Lock Is On";
                toolTip1.ToolTipIcon = ToolTipIcon.Warning;
                toolTip1.IsBalloon = true;
                toolTip1.SetToolTip(passwordTextBox, "Ako je Caps Lock uključen, možete pogrešno unijeti lozinku.\n\nIsključite Caps Lock prije unošenja lozinke.");
                toolTip1.Show("Ako je Caps Lock uključen, možete pogrešno unijeti lozinku.\n\nIsključite Caps Lock prije unošenja lozinke.", passwordTextBox, 5, passwordTextBox.Height - 5);
            }
        }

        private void loginFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(usernameTextBox.Text, passwordTextBox.Text);



                if (UserRepository.login(user) != null)
                {
                    if (user.Type == "admin")
                    {
                        administratorForm form = new administratorForm();
                        form.Show();
                        form.FormClosed += administratorForm_FormClosed;

                        Hide();
                    }
                    else
                    {
                        employeeForm form = new employeeForm();
                        form.Show();
                        form.FormClosed += employeeForm_FormClosed;

                        Hide();
                    }
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
        private void employeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }  
}
