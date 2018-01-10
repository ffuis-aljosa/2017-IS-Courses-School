using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Courses_School.Models;
using Courses_School.Database;


namespace Courses_School
{
    public partial class addNewEmployeeForm : Form

    {
        internal Employees NewEmployee { get; private set; }

        public addNewEmployeeForm()
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

    private void addEmployeeButton_Click(object sender, EventArgs e)
    {
        try
        {
            NewEmployee = new Employees(
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                addressTextBox.Text,
                dateOfBirthTextBox.Text,
                phoneNumberTextBox.Text,
                emailTextBox.Text,
                qualificationTextBox.Text,               
                (SchoolSubjects)schoolSubjectAndNumberOfClassesComboBox.SelectedItem,
                salaryTextBox.Text
                );

            DialogResult = DialogResult.OK;

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
}
