using System;
using System.Windows.Forms;
using Courses_School.Models;

namespace Courses_School
{
    public partial class addNewStudentForm : Form
    {
        public Student newStudent { get; set; }

        public addNewStudentForm()
        {
            InitializeComponent();
        }
        private void addNewStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                newStudent = new Student(firstNameTextBox.Text, lastNameTextBox.Text, jmbgTextBox.Text, dateOfBirthTextBox.Text,
                    addressTextBox.Text, phoneNumberTextBox.Text, membershipCostTextBox.Text);
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
