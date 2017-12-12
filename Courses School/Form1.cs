using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses_School
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void administratorButton_Click(object sender, EventArgs e)
        {
            administratorLoginForm login = new administratorLoginForm();
            login.Show();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            userLoginForm login = new userLoginForm();
            login.Show();
        }
    }
}
