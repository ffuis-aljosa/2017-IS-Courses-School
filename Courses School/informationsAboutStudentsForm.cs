using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Courses_School.Models;
using Courses_School.Database;
using System.Data.SqlServerCe;

namespace Courses_School
{
    public partial class informationsAboutStudentsForm : Form
    {
        //private static SqlCeConnection connection = DbConnection.Instance.Connection;
        public informationsAboutStudentsForm()
        {
            InitializeComponent();
            //loadStudent();
        }

        private void addNewStudentButton_Click(object sender, EventArgs e)
        {
            addNewStudentForm addStudentForm = new addNewStudentForm();
            DialogResult result = addStudentForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                StudentRepository.createStudent(addStudentForm.newStudent);
                //loadStudent();
            }

        }
        //private void loadStudent()
        //{
        //    informationsAboutStudentsListView.Items.Clear();
        //    SqlCeCommand command = new SqlCeCommand("SELECT s.First_name, s.Last_name, s.Jmbg, s.Date_of_birth, s.Address," +
        //        "s.Phone_number, s.Membership_cost, ss.school_subject, " +
        //        "ss.number_of_classes FROM Students AS s JOIN schoolsubjects" +
        //        " AS ss ON s.school_subject_id = ss.id", connection);
        //    try
        //    {
        //        SqlCeDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            ListViewItem item = new ListViewItem(reader["first_name"].ToString());
        //            item.SubItems.Add(reader["last_name"].ToString());
        //            item.SubItems.Add(reader["jmbg"].ToString());
        //            item.SubItems.Add(reader["date_of_birth"].ToString());
        //            item.SubItems.Add(reader["address"].ToString());
        //            item.SubItems.Add(reader["phone_number"].ToString());
        //            item.SubItems.Add(reader["membership_cost"].ToString());
        //            item.SubItems.Add(reader["school_subject"].ToString());
        //            item.SubItems.Add(reader["number_of_classes"].ToString());


        //            informationsAboutStudentsListView.Items.Add(item);

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    }
        //}
    }
}
