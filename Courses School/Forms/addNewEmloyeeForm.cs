using System;
using System.Windows.Forms;
using Courses_School.Models;
using Courses_School.Database;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Data;

namespace Courses_School
{
    public partial class addNewEmployeeForm : Form

    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public Employees NewEmployee { get; private set; }

        public addNewEmployeeForm()
    {
        InitializeComponent();
        loadSchooSubject();
        loadEmployee();
        clearTextBox();
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
                EmployeeRepository.createEmployee(NewEmployee);

                DialogResult = DialogResult.OK;
            loadEmployee();
            clearTextBox();
 
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

        private void loadEmployee()
        {
            employeesListView.Items.Clear();
            SqlCeCommand command;

            if (searchTextBox.Text == "")

                command = new SqlCeCommand("SELECT e.id, e.First_name, e.Last_name, e.Address, e.Date_of_birth, " +
                "e.Phone_number, e.Email, e.Qualification, ss.school_subject, " +
                "ss.number_of_classes, e.Salary FROM Employees AS e JOIN schoolSubjects" +
                " AS ss ON e.schoolSubject_id = ss.id ORDER BY e.First_name", connection);

            else

                command = new SqlCeCommand("SELECT e.id, e.First_name, e.Last_name, e.Address, e.Date_of_birth, " +
                "e.Phone_number, e.Email, e.Qualification, ss.school_subject, " +
                "ss.number_of_classes, e.Salary FROM Employees AS e JOIN schoolSubjects" +
                " AS ss ON e.schoolSubject_id = ss.id " +
               "WHERE e.First_name LIKE '%" + searchTextBox.Text + "%' OR e.Last_name LIKE '%" + searchTextBox.Text + "%'" +
               "OR ss.school_subject LIKE '%" + searchTextBox.Text + "%'", connection);
            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["first_name"].ToString());
                    item.SubItems.Add(reader["last_name"].ToString());
                    item.SubItems.Add(reader["address"].ToString());
                    item.SubItems.Add(reader["date_of_birth"].ToString());
                    item.SubItems.Add(reader["phone_number"].ToString());
                    item.SubItems.Add(reader["email"].ToString());
                    item.SubItems.Add(reader["qualification"].ToString());
                    item.SubItems.Add(reader["school_subject"].ToString());
                    item.SubItems.Add(reader["number_of_classes"].ToString());
                    item.SubItems.Add(reader["salary"].ToString());


                    employeesListView.Items.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearTextBox()
        {
            firstNameTextBox.Text = " ";
            lastNameTextBox.Text = " ";
            addressTextBox.Text = " ";
            dateOfBirthTextBox.Text = " ";
            phoneNumberTextBox.Text = " ";
            emailTextBox.Text = " ";
            qualificationTextBox.Text = " ";
            schoolSubjectAndNumberOfClassesComboBox.Text = " ";
            salaryTextBox.Text = " ";
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite da obrišete?", "", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                SqlCeCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Employees WHERE id = "
                    + int.Parse(employeesListView.SelectedItems[0].Text) + ";";

                command.ExecuteNonQuery();
                loadEmployee();
                clearTextBox();
            }
            else
            {
                MessageBox.Show("Brisanje nije uspjelo!");

            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            employeesListView.View = View.Details;
            employeesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            employeesListView.Items.Clear();
            loadEmployee();
        }

        private void addNewEmployeeForm_Load(object sender, EventArgs e)
        {
            employeesListView.View = View.Details;
            employeesListView.FullRowSelect = true;
        }

        private void employeesListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (employeesListView.SelectedItems.Count == 0)
                    return;

                SqlCeCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;

                command.CommandText = "SELECT e.id, e.First_name, e.Last_name, e.Address, e.Date_of_birth, e.email," +
                    "e.Phone_number, e.Qualification,e.salary, ss.school_subject, " +
                   "ss.number_of_classes FROM Employees AS e JOIN schoolSubjects" +
                    " AS ss ON e.schoolSubject_id = ss.id WHERE e.id="
                    + int.Parse(employeesListView.SelectedItems[0].Text) + ";";
                try
                {
                    SqlCeDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        firstNameTextBox.Text = reader["First_name"].ToString();
                        lastNameTextBox.Text = reader["Last_name"].ToString();
                        addressTextBox.Text = reader["address"].ToString();
                        dateOfBirthTextBox.Text = reader["Date_of_birth"].ToString();
                        emailTextBox.Text = reader["Email"].ToString();
                        phoneNumberTextBox.Text = reader["Phone_number"].ToString();
                        qualificationTextBox.Text = reader["Qualification"].ToString();
                        salaryTextBox.Text = reader["Salary"].ToString();
                        schoolSubjectAndNumberOfClassesComboBox.Text = reader["school_subject"].ToString();

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

        private void changeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite da izmjenite podatke?", "", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                try
                {
                    if (employeesListView.SelectedItems.Count == 0)
                        return;

                    SqlCeCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;

                    command.CommandText = "select Id from schoolSubjects where school_subject ='" + schoolSubjectAndNumberOfClassesComboBox.SelectedItem.ToString() + "';";
                    SqlCeDataReader reader = command.ExecuteReader();
                    reader.Read();

                    command.CommandText = "UPDATE Employees SET " +
                    "first_name='" + firstNameTextBox.Text + "', " +
                    "last_name='" + lastNameTextBox.Text + "'," +
                    "address='" + addressTextBox.Text + "'," +
                    "date_of_birth='" + dateOfBirthTextBox.Text + "', " +
                    "qualification='" + qualificationTextBox.Text + "'," +
                    "schoolSubject_id=" + reader.GetInt32(0) + ", " +
                    "salary='" + salaryTextBox.Text + "', " +
                    "phone_number='" + phoneNumberTextBox.Text + "', " +
                    "email='" + emailTextBox.Text + "' " +

                   "WHERE id=" + int.Parse(employeesListView.SelectedItems[0].Text) + ";";
                    command.ExecuteNonQuery();
                    loadEmployee();
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
    }
}
