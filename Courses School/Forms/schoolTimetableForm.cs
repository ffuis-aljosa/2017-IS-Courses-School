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
    public partial class schoolTimetableForm : Form
    {
        public schoolTimetableForm()
        {
            InitializeComponent();
        }

        private void classroom1Button_Click(object sender, EventArgs e)
        {
            classroom1Form classroom1 = new classroom1Form();
            classroom1.Show();
        }

        private void classroom2Botton_Click(object sender, EventArgs e)
        {
            classroom2Form classroom2 = new classroom2Form();
            classroom2.Show();

        }

        private void classroom3Button_Click(object sender, EventArgs e)
        {
            classroom3Form classroom3 = new classroom3Form();
            classroom3.Show();

        }
    }
}
