using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Courses_School.Models;
using Courses_School.Database;

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
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                EmployeeRepository.createEmployee(form.NewEmployee);
            }
        }
    }
}
