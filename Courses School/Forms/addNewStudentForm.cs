using System;
using System.Windows.Forms;
using Courses_School.Models;
using Courses_School.Database;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Data;

namespace Courses_School
{
    public partial class addNewStudentForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public Student newStudent { get; set; }

        public addNewStudentForm()
        {
            InitializeComponent();
            loadSchooSubject();
            loadStudent();
            clearTextBox();


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

                newStudent = new Student(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    jmbgTextBox.Text,
                    dateOfBirthTextBox.Text,
                    addressTextBox.Text,
                    phoneNumberTextBox.Text,
                    membershipCostTextBox.Text,
                    (SchoolSubjects)schoolSubjectAndNumberOfClassesComboBox.SelectedItem
                    );
                StudentRepository.createStudent(newStudent);

                DialogResult = DialogResult.OK;
                loadStudent();
                clearTextBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadStudent()
        {
            informationsAboutStudentsListView.Items.Clear();
            SqlCeCommand command;

            if (searchTextBox.Text == "")

                command = new SqlCeCommand("SELECT s.id, s.First_name1, s.Last_name1, s.Jmbg, s.Date_of_birth, s.Address," +
                "s.Phone_number, s.Membership_cost, ss.school_subject, " +
                "ss.number_of_classes, e.first_name, e.last_name FROM Students AS s JOIN schoolsubjects" +
                " AS ss ON s.school_subject_id = ss.id JOIN Employees AS e ON e.schoolSubject_id=ss.id ORDER BY s.First_name1", connection);

            else

                command = new SqlCeCommand("SELECT s.id, s.First_name1, s.Last_name1, s.Jmbg, s.Date_of_birth, s.Address," +
            "s.Phone_number, s.Membership_cost, ss.school_subject, " +
           "ss.number_of_classes, e.first_name, e.last_name FROM Students AS s JOIN schoolsubjects" +
            " AS ss ON s.school_subject_id = ss.id JOIN Employees AS e ON e.schoolSubject_id=ss.id " +
            "WHERE s.First_name1 LIKE '%" + searchTextBox.Text + "%' OR s.Last_name1 LIKE '%" + searchTextBox.Text + "%'" +
            "OR ss.school_subject LIKE '%" + searchTextBox.Text + "%'", connection);


            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["first_name1"].ToString());
                    item.SubItems.Add(reader["last_name1"].ToString());
                    item.SubItems.Add(reader["jmbg"].ToString());
                    item.SubItems.Add(reader["date_of_birth"].ToString());
                    item.SubItems.Add(reader["address"].ToString());
                    item.SubItems.Add(reader["phone_number"].ToString());
                    item.SubItems.Add(reader["membership_cost"].ToString());
                    item.SubItems.Add(reader["school_subject"].ToString());
                    item.SubItems.Add(reader["number_of_classes"].ToString());
                    item.SubItems.Add(reader["first_name"].ToString());
                    item.SubItems.Add(reader["last_name"].ToString());

                    informationsAboutStudentsListView.Items.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite da obrišete?", "", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                SqlCeCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Students WHERE id = "
                    + int.Parse(informationsAboutStudentsListView.SelectedItems[0].Text) + ";";

                command.ExecuteNonQuery();
                loadStudent();
                clearTextBox();
            }
            else
            {
                MessageBox.Show("Brisanje nije uspjelo!");

            }
        }
        private void clearTextBox()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            jmbgTextBox.Text = "";
            dateOfBirthTextBox.Text = "";
            addressTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            membershipCostTextBox.Text = "";
            schoolSubjectAndNumberOfClassesComboBox.Text = "";

        }
       
        
        private void changeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite da izmjenite podatke?", "", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                if (informationsAboutStudentsListView.SelectedItems.Count == 0)
                    return;

                SqlCeCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select Id from schoolSubjects where school_subject ='" + schoolSubjectAndNumberOfClassesComboBox.SelectedItem.ToString() + "';";
                SqlCeDataReader reader = command.ExecuteReader();
                reader.Read();
                command.CommandText = "UPDATE Students SET first_name1='" + firstNameTextBox.Text + "', " +
                    "last_name1='" + lastNameTextBox.Text + "'," +
                    "jmbg='" + jmbgTextBox.Text + "', " +
                    "date_of_birth='" + dateOfBirthTextBox.Text + "', " +
                    "address='" + addressTextBox.Text + "'," +
                    "phone_number='" + phoneNumberTextBox.Text + "', " +
                    "membership_cost=" + membershipCostTextBox.Text + ", " +
                    "school_subject_id=" + reader.GetInt32(0) + " " +


                    "WHERE id=" + int.Parse(informationsAboutStudentsListView.SelectedItems[0].Text) + ";";

                command.ExecuteNonQuery();
                loadStudent();
                clearTextBox();
            }
            else
            {
                MessageBox.Show("Izmjena nije uspjela!");

            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            informationsAboutStudentsListView.View = View.Details;
            informationsAboutStudentsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            informationsAboutStudentsListView.Items.Clear();
            loadStudent();
        }

        private void addNewStudentForm_Load(object sender, EventArgs e)
        {
            informationsAboutStudentsListView.View = View.Details;
            informationsAboutStudentsListView.FullRowSelect = true;
        }


        private void informationsAboutStudentsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (informationsAboutStudentsListView.SelectedItems.Count == 0)
                    return;

                SqlCeCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                comboBox1.Items.Clear();

                command.CommandText = "SELECT s.id, s.First_name1, s.Last_name1, s.Jmbg, s.Date_of_birth, s.Address," +
                    "s.Phone_number, s.Membership_cost, ss.school_subject, " +
                   "ss.number_of_classes  FROM Students AS s JOIN schoolsubjects" +
                    " AS ss ON s.school_subject_id = ss.id WHERE s.id="
                    + int.Parse(informationsAboutStudentsListView.SelectedItems[0].Text) + ";";


                try
                {
                    SqlCeDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        firstNameTextBox.Text = reader["first_name1"].ToString();
                        lastNameTextBox.Text = reader["last_name1"].ToString();
                        jmbgTextBox.Text = reader["jmbg"].ToString();
                        dateOfBirthTextBox.Text = reader["date_of_birth"].ToString();
                        addressTextBox.Text = reader["address"].ToString();
                        phoneNumberTextBox.Text = reader["phone_number"].ToString();
                        membershipCostTextBox.Text = reader["membership_cost"].ToString();
                        schoolSubjectAndNumberOfClassesComboBox.Text = reader["school_subject"].ToString();
                        command.CommandText = "SELECT ss.school_subject, e.date FROM schoolSubjects AS ss JOIN Exams AS e ON e.school_subject_id=ss.id WHERE e.student_id = " + int.Parse(informationsAboutStudentsListView.SelectedItems[0].Text) /*reader["id"].ToString()*/ + ";";
                        SqlCeDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                            comboBox1.Items.Add(dr["school_subject"].ToString() + " " + dr["date"].ToString());

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch 
            {
                MessageBox.Show("Nema izmjene.");
            }
        }
    }
}
