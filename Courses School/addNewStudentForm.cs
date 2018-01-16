using System;
using System.Windows.Forms;
using Courses_School.Models;
using Courses_School.Database;
using System.Collections.Generic;
using System.Data.SqlServerCe;

namespace Courses_School
{
    public partial class addNewStudentForm : Form
    {

        public Student newStudent { get; set; }

        public addNewStudentForm()
        {
            InitializeComponent();
            loadSchooSubject();
          
        }
        private void loadSchooSubject()
        {
            List<SchoolSubjects> schoolsubject = SchoolSubjectRepository.fetchAllSchoolSubjects();

            foreach (SchoolSubjects schoolsubjects in schoolsubject)
                schoolSubjectAndNumberOfClassesComboBox.Items.Add(schoolsubjects);
        }
        private void addNewStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                newStudent = new Student(firstNameTextBox.Text, lastNameTextBox.Text, jmbgTextBox.Text, dateOfBirthTextBox.Text,
                    addressTextBox.Text, phoneNumberTextBox.Text, membershipCostTextBox.Text,
                    (SchoolSubjects)schoolSubjectAndNumberOfClassesComboBox.SelectedItem);
               DialogResult = DialogResult.OK;
           
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
    }
}
