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
    public partial class classroom2Form : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public SchoolTimetable2 newSchoolTimetable { get; set; }

        public classroom2Form()
        {
            InitializeComponent();
            loadSchoolTimetable();
            clearTextBox();
        }

        private void loadSchoolTimetable()
        {
            schoolTimetableListView.Items.Clear();
            SqlCeCommand command = new SqlCeCommand("SELECT  time, monday, tuesday,  wednesday, thursday, friday FROM SchoolTimetable2", connection);

            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["time"].ToString());
                  //  item.SubItems.Add(reader["time"].ToString());
                    item.SubItems.Add(reader["monday"].ToString());
                    item.SubItems.Add(reader["tuesday"].ToString());
                    item.SubItems.Add(reader["wednesday"].ToString());
                    item.SubItems.Add(reader["thursday"].ToString());
                    item.SubItems.Add(reader["friday"].ToString());
                    schoolTimetableListView.Items.Add(item);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void classroom2Form_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {

                newSchoolTimetable = new SchoolTimetable2(timeTextBox.Text, mondayTextBox.Text, tuesdayTextBox.Text, wednesdayTextBox.Text, thursdayTextBox.Text, fridayTextBox.Text);

                SchoolTimetableRepository2.addInSchoolTimetable(newSchoolTimetable);

                DialogResult = DialogResult.OK;
                loadSchoolTimetable();
                clearTextBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void schoolTimetableListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "SELECT time, monday, tuesday,  wednesday, thursday, friday FROM SchoolTimetable2";
              
            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    timeTextBox.Text = reader["time"].ToString();
                    mondayTextBox.Text = reader["monday"].ToString();
                    tuesdayTextBox.Text = reader["tuesday"].ToString();
                    wednesdayTextBox.Text = reader["wednesday"].ToString();
                    thursdayTextBox.Text = reader["thursday"].ToString();
                    fridayTextBox.Text = reader["friday"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            clearTextBox();
        }

        private void clearTextBox()
        {
            timeTextBox.Text = "";
            mondayTextBox.Text = "";
            tuesdayTextBox.Text = "";
            wednesdayTextBox.Text = "";
            thursdayTextBox.Text = "";
            fridayTextBox.Text = "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite da obrišete?", "", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                SqlCeCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM SchoolTimetable2 WHERE time = "
                     +"'" +schoolTimetableListView.SelectedItems[0].Text + "'";

                command.ExecuteNonQuery();
                loadSchoolTimetable();
                clearTextBox();
            }
            else
            {
                MessageBox.Show("Brisanje nije uspjelo!");

            }
        }
    }
}

