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

        private void loadSchoolSubject()
        {
            schoolSubjectListView.Items.Clear();
            SqlCeCommand command;

            if (searchTextBox.Text == "")

                command = new SqlCeCommand("SELECT id, school_subject, number_of_classes FROM schoolSubjects ORDER BY id", connection);

            else

                command = new SqlCeCommand("SELECT id, school_subject, number_of_classes FROM schoolSubjects" +
                          "WHERE school_subject LIKE '%" + searchTextBox.Text + "%'", connection);

            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["school_subject"].ToString());
                    item.SubItems.Add(reader["number_of_classes"].ToString());

                    schoolSubjectListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void clearTextBox()
        {
            schoolSubjectTextBox.Text = " ";
            numberOfClassesTextBox.Text = " ";

        }  

        private void addSchoolSubjectButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                newSchoolSubject = new SchoolSubjects(schoolSubjectTextBox.Text, numberOfClassesTextBox.Text);

                SchoolSubjectRepository.createSchoolSubject(newSchoolSubject);

                DialogResult = DialogResult.OK;
                loadSchoolSubject();
                clearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteSchoolSubjectButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite da obrišete?", "", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                SqlCeCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM schoolSubjects WHERE id = "
                    + int.Parse(schoolSubjectListView.SelectedItems[0].Text) + ";";

                command.ExecuteNonQuery();
                loadSchoolSubject();
                clearTextBox();
            }
            else
            {
                MessageBox.Show("Brisanje nije uspjelo!");

            }
        }

        private void changeSchoolSubjectButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite da izmjenite podatke?", "", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                try
                {
                    SqlCeCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select Id from schoolSubjects where id =" + int.Parse(schoolSubjectListView.SelectedItems[0].Text) + ";";
                    SqlCeDataReader reader = command.ExecuteReader();
                    reader.Read();
                    command.CommandText = "UPDATE schoolSubjects SET school_subject'" + schoolSubjectTextBox.Text + "', " +
                        "number_of_classes = " + numberOfClassesTextBox.Text + "," +
                        "WHERE id=" + int.Parse(schoolSubjectListView.SelectedItems[0].Text) + ";";

                    command.ExecuteNonQuery();
                    loadSchoolSubject();
                    clearTextBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Izmjena nije uspjela!");

            }
        }

        private void schoolSubjectListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                SqlCeCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;

                command.CommandText = "SELECT id, school_subject, number_of_classes FROM schoolSubjects";

                try
                {

                    SqlCeDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        schoolSubjectTextBox.Text = reader["school_subject"].ToString();
                        numberOfClassesTextBox.Text = reader["number_of_classes"].ToString();

                    }
                    clearTextBox();
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

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            schoolSubjectListView.View = View.Details;
            schoolSubjectListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            schoolSubjectListView.Items.Clear();
            loadSchoolSubject();
        }
    }
}
