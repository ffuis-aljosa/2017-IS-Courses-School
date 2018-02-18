using Courses_School.Database;
using Courses_School.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses_School
{
    public partial class addNewSchoolSubjectForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public SchoolSubjects newSchoolSubject { get; set; }

        public addNewSchoolSubjectForm()
        {
            InitializeComponent();
            loadSchoolSubject();
        }

        private void schoolSubjectForm_Load(object sender, EventArgs e)
        {

        }
   
        /*
        private void SchoolSubjectButton_Click(object sender, EventArgs e)
        {
            addNewSchoolSubjectForm form = new addNewSchoolSubjectForm();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                SchoolSubjectRepository.createSchoolSubject(form.NewSchoolSubject);
            }
        */

        private void SchoolSubjectListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       private void SchoolSubjectListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlCeCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "SELECT id, school_subject, number_of_classes FROM schoolsubjects" +
                int.Parse(SchoolSubjectListView.SelectedItems[0].Text) + ";";
            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    subjectAddSchoolSubjectTextBox.Text = reader["school_subject"].ToString();
                    numberOfClassesAddSchoolSubjectTextBox.Text = reader["number_of_classes"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        
        private void addSchoolSubjectButton_Click(object sender, EventArgs e)
        {
            try
            {

                newSchoolSubject = new SchoolSubjects(subjectAddSchoolSubjectTextBox.Text, numberOfClassesAddSchoolSubjectTextBox.Text);

                SchoolSubjectRepository.createSchoolSubject(newSchoolSubject);

                DialogResult = DialogResult.OK;
                loadSchoolSubject();
                clearTextBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void loadSchoolSubject()
        {
            SchoolSubjectListView.Items.Clear();
            SqlCeCommand command = new SqlCeCommand("SELECT id, school_subject, number_of_classes FROM schoolsubjects", connection);

            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["school_subject"].ToString());
                    item.SubItems.Add(reader["number_of_classes"].ToString());

                    SchoolSubjectListView.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void clearTextBox()
        {
            subjectAddSchoolSubjectTextBox.Text = " ";
            numberOfClassesAddSchoolSubjectTextBox.Text = " ";
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
