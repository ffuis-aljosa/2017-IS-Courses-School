using Courses_School.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses_School
{
    public partial class schoolSubjectForm : Form
    {
        public schoolSubjectForm()
        {
            InitializeComponent();
        }

        private void schoolSubjectForm_Load(object sender, EventArgs e)
        {

        }

        private void SchoolSubjectButton_Click(object sender, EventArgs e)
        {
            addSchoolSubjectForm form = new addSchoolSubjectForm();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                SchoolSubjectRepository.createSchoolSubject(form.NewSchoolSubject);
            }
        }

        private void SchoolSubjectListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
