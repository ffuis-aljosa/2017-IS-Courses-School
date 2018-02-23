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

        private void loadExams()
        {
            examsListView.Items.Clear();
            SqlCeCommand command;

            if (searchTextBox.Text == "")
            {
                command = new SqlCeCommand("SELECT e.id, s.first_name1, s.last_name1, ss.school_subject, e.grade, e.date" +
               " FROM Students AS s JOIN schoolSubjects AS ss ON ss.id = s.school_subject_id JOIN Exams AS e ON " +
               "e.school_subject_id = ss.id ORDER BY e.date ", connection);
            }
            else
            {
                command = new SqlCeCommand("SELECT e.id, s.first_name1, s.last_name1, ss.school_subject, e.grade, e.date" +
              " FROM Students AS s JOIN schoolSubjects AS ss ON ss.id=s.school_subject_id JOIN Exams AS e ON e.school_subject_id = ss.id" +
              " WHERE s.First_name1 LIKE '%" + searchTextBox.Text + "%' OR s.Last_name1 LIKE '%"
                + searchTextBox.Text + "%' ORDER BY e.date ", connection);
            }


            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["first_name1"].ToString());
                    item.SubItems.Add(reader["last_name1"].ToString());
                    item.SubItems.Add(reader["school_subject"].ToString());
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

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                newExam = new Exams((Student)firstNameComboBox.SelectedItem, (SchoolSubjects)schoolSubjectComboBox.SelectedItem, 
                    gradeTextBox.Text, dateTimePicker.Value.ToString());

                ExamRepository.addExam(newExam);
                DialogResult = DialogResult.OK;
                loadExams();
                clearTextBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

   
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            examsListView.View = View.Details;
            examsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            examsListView.Items.Clear();
            loadExams();
        }

        private void clearTextBox()
        {
            firstNameComboBox.Text = "";
            schoolSubjectComboBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
            gradeTextBox.Text = "";
        }

        private void firstNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCeCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string full = firstNameComboBox.SelectedItem.ToString();
                cmd.CommandText = "select * from Students " +
                    "where first_name1='" + full.Substring(0, full.IndexOf(' ')) + "' " +
                    "AND last_name1='" + full.Substring(full.IndexOf(' ') + 1) + "' ;";

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    cmd.CommandText = "SELECT School_subject FROM schoolSubjects WHERE Id = " + dr["school_subject_id"] + ";";

                    SqlCeDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                        schoolSubjectComboBox.Text = reader.GetString(0);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

     
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite da obrišete?", "", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                SqlCeCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Exams WHERE id = "
                    + int.Parse(examsListView.SelectedItems[0].Text) + ";";

                command.ExecuteNonQuery();
                loadExams();
                clearTextBox();
            }
            else
            {
                MessageBox.Show("Brisanje nije uspjelo!");

            }
        }
    }
}
