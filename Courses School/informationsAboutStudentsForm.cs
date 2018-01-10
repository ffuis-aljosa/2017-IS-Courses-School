using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Courses_School.Models;
using Courses_School.Database;

namespace Courses_School
{
    public partial class informationsAboutStudentsForm : Form
    {
        public informationsAboutStudentsForm()
        {
            InitializeComponent();

        }

        private void addNewStudentButton_Click(object sender, EventArgs e)
        {
            addNewStudentForm addStudentForm = new addNewStudentForm();
            DialogResult result = addStudentForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                StudentRepository.createStudent(addStudentForm.newStudent);

            }
        }

    }
}
