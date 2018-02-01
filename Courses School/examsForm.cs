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
            loadSchooSubject();
        }

        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        private void loadSchooSubject()
        {
            List<SchoolSubjects> schoolsubject = SchoolSubjectRepository.fetchAllSchoolSubjects();
            foreach (SchoolSubjects schoolsubjects in schoolsubject)
                schoolSubjectComboBox.Items.Add(schoolsubjects);
        }

    }
}
