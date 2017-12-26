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
    public partial class informationsAboutEmployeesForm : Form
    {
        public informationsAboutEmployeesForm()
        {
            InitializeComponent();
        }

        private void addNewEmployeeButton_Click(object sender, EventArgs e)
        {
            addNewEmployeeForm form = new addNewEmployeeForm();
            form.Show();

        }
    }
}
