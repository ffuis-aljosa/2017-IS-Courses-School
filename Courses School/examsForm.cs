using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Courses_School.Models;
using Courses_School.Database;
using System.Data.SqlServerCe;

namespace Courses_School
{
    public partial class examsForm : Form
    {
        public examsForm()
        {
            InitializeComponent();
            loadSchooSubjects();
            loadStudents();
        }

        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        private void loadSchooSubjects()
        {
            SqlCeCommand cm = new SqlCeCommand("SELECT school_subject FROM schoolSubjects ", connection);
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
            }
        }

        private void loadStudents()
         {
             SqlCeCommand cm = new SqlCeCommand("SELECT first_name1 FROM Students ", connection);
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
             }
         }
    }
}
