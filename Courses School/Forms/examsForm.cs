using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Courses_School.Models;
using Courses_School.Database;
using System.Data.SqlServerCe;
using System.Data;

namespace Courses_School
{
    public partial class examsForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public Exams newExam { get; set; }

        public examsForm()
        {
            InitializeComponent();
            loadSchooSubjects();
            loadStudents();
            loadExams();
        }
      
        private void loadSchooSubjects()
        {
            List<SchoolSubjects> schoolSubject = SchoolSubjectRepository.fetchAllSchoolSubjects();

            foreach (SchoolSubjects schoolSubjects in schoolSubject)
                schoolSubjectComboBox.Items.Add(schoolSubjects);
        }

        private void loadStudents()
         {
            List<Student> student = StudentRepository.fetchAllStudents();

            foreach (Student students in student)
                firstNameComboBox.Items.Add(students);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                newExam = new Exams((SchoolSubjects)schoolSubjectComboBox.SelectedItem, (Student)firstNameComboBox.SelectedItem,
                    gradeTextBox.Text, dateTextBox.Text);
                ExamRepository.addExam(newExam);
                DialogResult = DialogResult.OK;
                loadExams();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadExams()
        {
            examsListView.Items.Clear();
            SqlCeCommand command;

            if (searchTextBox.Text == "")

                command = new SqlCeCommand("SELECT e.id, ss.school_subject, s.First_name1, e.Grade, e.Date " +
                " FROM Students AS s JOIN schoolSubjects" +
                " AS ss ON s.school_subject_id = ss.id JOIN Exams AS e ON e.school_subject_id=ss.id ORDER BY s.First_name1", connection);

            else

                command = new SqlCeCommand("SELECT e.id, ss.school_subject, s.First_name1, e.Grade, e.Date " +
               " FROM Students AS s JOIN schoolSubjects" +
               " AS ss ON s.school_subject_id = ss.id JOIN Exams AS e ON e.school_subject_id=ss.id" +
            "WHERE s.First_name1 LIKE '%" + searchTextBox.Text + "%';", connection);


            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["school_subject"].ToString());
                    item.SubItems.Add(reader["first_name1"].ToString());
                    item.SubItems.Add(reader["grade"].ToString());
                    item.SubItems.Add(reader["date"].ToString());


                    examsListView.Items.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            examsListView.View = View.Details;
            examsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            examsListView.Items.Clear();
            loadExams();
        }

        private void examsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCeCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;

                command.CommandText = "SELECT e.id, ss.school_subject, s.First_name1, e.Grade, e.Date " +
                   " FROM Students AS s JOIN schoolsubjects" +
                    " AS ss ON s.school_subject_id = ss.id JOIN Exams AS e ON e.school_subject_id=ss.id WHERE e.id="
                    + int.Parse(examsListView.SelectedItems[0].Text) + ";";
                try
                {
                    SqlCeDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        schoolSubjectComboBox.Text = reader["school_subject"].ToString();
                        firstNameComboBox.Text = reader["first_name1"].ToString();
                        gradeTextBox.Text = reader["grade"].ToString();
                        dateTextBox.Text = reader["date"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
