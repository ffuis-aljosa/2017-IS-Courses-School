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
    public partial class classroom1Form : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public SchoolTimetable1 newSchoolTimetable { get; set; }


        public classroom1Form()
        {
            InitializeComponent();
            loadSchoolTimetable1();
            clearTextBox();
        }
        private void loadSchoolTimetable1()
        {
            schoolTimetableListView1.Items.Clear();
            SqlCeCommand command = new SqlCeCommand("SELECT time1, monday1, tuesday1, wednesday1, thursday1, friday1 FROM SchoolTimetable1", connection);

            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["time1"].ToString());
                    item.SubItems.Add(reader["monday1"].ToString());
                    item.SubItems.Add(reader["tuesday1"].ToString());
                    item.SubItems.Add(reader["wednesday1"].ToString());
                    item.SubItems.Add(reader["thursday1"].ToString());
                    item.SubItems.Add(reader["friday1"].ToString());
                    schoolTimetableListView1.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void schoolTimetableListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "SELECT time1, monday1, tuesday1, wednesday1, thursday1, friday1 FROM SchoolTimetable1";

            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    timeTextBox1.Text = reader["time1"].ToString();
                    mondayTextBox1.Text = reader["monday1"].ToString();
                    tuesdayTextBox1.Text = reader["tuesday1"].ToString();
                    wednesdayTextBox1.Text = reader["wednesday1"].ToString();
                    thursdayTextBox1.Text = reader["thursday1"].ToString();
                    fridayTextBox1.Text = reader["friday1"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            clearTextBox();
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            try
            {

                newSchoolTimetable = new SchoolTimetable1(timeTextBox1.Text, mondayTextBox1.Text, tuesdayTextBox1.Text, wednesdayTextBox1.Text, thursdayTextBox1.Text, fridayTextBox1.Text);

                SchoolTimetable1Repository.addInSchoolTimetable1(newSchoolTimetable);

                DialogResult = DialogResult.OK;
                loadSchoolTimetable1();
                clearTextBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite da obrišete?", "", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                SqlCeCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM SchoolTimetable1 WHERE time1 = "
                     + "'" + schoolTimetableListView1.SelectedItems[0].Text + "'";

                command.ExecuteNonQuery();
                loadSchoolTimetable1();
                clearTextBox();
            }
            else
            {
                MessageBox.Show("Brisanje nije uspjelo!");

            }
        }

        private void clearTextBox()
        {
            timeTextBox1.Text = "";
            mondayTextBox1.Text = "";
            tuesdayTextBox1.Text = "";
            wednesdayTextBox1.Text = "";
            thursdayTextBox1.Text = "";
            fridayTextBox1.Text = "";
        }

        private void classroom1Form_Load(object sender, EventArgs e)
        {

        }
    }
}
