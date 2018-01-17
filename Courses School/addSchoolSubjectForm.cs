using Courses_School.Models;
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
    public partial class addSchoolSubjectForm : Form
    {

        public SchoolSubjects NewSchoolSubject { get; set; }

        public addSchoolSubjectForm()
        {
            InitializeComponent();
        }

        private void addSchoolSubjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewSchoolSubject = new SchoolSubjects(
                    subjectAddSchoolSubjectTextBox.Text,
                    numberOfClassesAddSchoolSubjectTextBox.Text);

                DialogResult = DialogResult.OK;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
