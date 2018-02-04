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

        public Exams newExam { get;  set; }

        public examsForm()
        {
            InitializeComponent();
            loadSchooSubjects();
            loadStudents();
        }
      
        private void loadSchooSubjects()
        {
            /*SqlCeCommand cm = new SqlCeCommand("SELECT school_subject FROM schoolSubjects ", connection);
            try
            {
                SqlCeDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    schoolSubjectComboBox.Items.Add(dr["school_subject"]);
                }
                dr.Close();
                dr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            List<SchoolSubjects> schoolSubject = SchoolSubjectRepository.fetchAllSchoolSubjects();

            foreach (SchoolSubjects schoolSubjects in schoolSubject)
                schoolSubjectComboBox.Items.Add(schoolSubjects);
        }

        private void loadStudents()
         {
             /*SqlCeCommand cm = new SqlCeCommand("SELECT first_name1 FROM Students ", connection);
             try
             {
                 SqlCeDataReader dr = cm.ExecuteReader();
                 while (dr.Read())
                 {
                     firstNameComboBox.Items.Add(dr["first_name1"]);
                   
                }
                 dr.Close();
                 dr.Dispose();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/

            List<Student> student = StudentRepository.fetchAllStudents();

            foreach (Student students in student)
                firstNameComboBox.Items.Add(students);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
           // try
            //{
                newExam = new Exams((SchoolSubjects)schoolSubjectComboBox.SelectedItem, (Student)firstNameComboBox.SelectedItem, 
                    gradeTextBox.Text,dateTextBox.Text);
                ExamRepository.addExam(newExam);
                DialogResult = DialogResult.OK;

           /* }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }        
    }
}
