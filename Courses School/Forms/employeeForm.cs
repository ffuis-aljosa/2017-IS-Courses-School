﻿using System;
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
    public partial class employeeForm : Form
    {
        public employeeForm()
        {
            InitializeComponent();
        }

        private void timeTableButton_Click(object sender, EventArgs e)
        {
            schoolTimetableForm form = new schoolTimetableForm();
            form.Show();
        }

        private void examsButton_Click(object sender, EventArgs e)
        {
            examsForm form = new examsForm();
            form.Show();
        }
    }
}
