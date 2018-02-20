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
    public partial class classroom3Form : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public SchoolTimetable3 newSchoolTimetable { get; set; }

        public classroom3Form()
        {
            InitializeComponent();
            loadSchoolTimetable3();
            clearTextBox3();
        }
        private void loadSchoolTimetable3()
        {
            schoolTimetableListView3.Items.Clear();
            SqlCeCommand command = new SqlCeCommand("SELECT time3, monday3, tuesday3, wednesday3, thursday3, friday3 FROM SchoolTimetable3", connection);

            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["time3"].ToString());
                    item.SubItems.Add(reader["monday3"].ToString());
                    item.SubItems.Add(reader["tuesday3"].ToString());
                    item.SubItems.Add(reader["wednesday3"].ToString());
                    item.SubItems.Add(reader["thursday3"].ToString());
                    item.SubItems.Add(reader["friday3"].ToString());
                    schoolTimetableListView3.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void schoolTimetableListView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "SELECT time3, monday3, tuesday3, wednesday3, thursday3, friday3 FROM SchoolTimetable3";

            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    timeTextBox3.Text = reader["time3"].ToString();
                    mondayTextBox3.Text = reader["monday3"].ToString();
                    tuesdayTextBox3.Text = reader["tuesday3"].ToString();
                    wednesdayTextBox3.Text = reader["wednesday3"].ToString();
                    thursdayTextBox3.Text = reader["thursday3"].ToString();
                    fridayTextBox3.Text = reader["friday3"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            clearTextBox3();

        }

        private void classroom3Form_Load(object sender, EventArgs e)
        {

        }

        private void addButton3_Click(object sender, EventArgs e)
        {
            try
            {

                newSchoolTimetable = new SchoolTimetable3(timeTextBox3.Text, mondayTextBox3.Text, tuesdayTextBox3.Text, wednesdayTextBox3.Text, thursdayTextBox3.Text, fridayTextBox3.Text);

                SchoolTimetable3Repository.addInSchoolTimetable3(newSchoolTimetable);

                DialogResult = DialogResult.OK;
                loadSchoolTimetable3();
                clearTextBox3();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearTextBox3()
        {
            timeTextBox3.Text = "";
            mondayTextBox3.Text = "";
            tuesdayTextBox3.Text = "";
            wednesdayTextBox3.Text = "";
            thursdayTextBox3.Text = "";
            fridayTextBox3.Text = "";
        }

        private void deleteButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite da obrišete?", "", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                SqlCeCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM SchoolTimetable3 WHERE time3 = "
                     + "'" + schoolTimetableListView3.SelectedItems[0].Text + "'";

                command.ExecuteNonQuery();
                loadSchoolTimetable3();
                clearTextBox3();
            }
            else
            {
                MessageBox.Show("Brisanje nije uspjelo!");

            }
        }
    }
}
