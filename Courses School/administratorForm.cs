using System;
using System.Windows.Forms;
using Courses_School.Database;

namespace Courses_School
{
    public partial class administratorForm : Form
    {
        public administratorForm()
        {
            InitializeComponent();
        } 

        private void schoolSubjectbutton_Click(object sender, EventArgs e)
        {
            addNewSchoolSubjectForm form = new addNewSchoolSubjectForm();
            form.Show();
        }

        private void informationsAboutEmployeesButton_Click(object sender, EventArgs e)
        {
            addNewEmployeeForm form = new addNewEmployeeForm();
            form.Show();
        }

        private void informationsAboutStudentsButton_Click(object sender, EventArgs e)
        {
            
            addNewStudentForm addStudentForm = new addNewStudentForm();
            addStudentForm.Show();
        }

        private void schoolTimetableButton_Click(object sender, EventArgs e)
        {
            schoolTimetableForm form = new schoolTimetableForm();
            form.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            newUserForm form = new newUserForm();
            form.Show();
        }

    }
}
