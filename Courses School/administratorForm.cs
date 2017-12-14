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
    public partial class administratorForm : Form
    {
        public administratorForm()
        {
            InitializeComponent();
        } 

        private void schoolSubjectbutton_Click(object sender, EventArgs e)
        {
            schoolSubjectForm form = new schoolSubjectForm();
            form.Show();

        }

        private void informationsAboutEmployeesButton_Click(object sender, EventArgs e)
        {
            informationsAboutEmployeesForm form = new informationsAboutEmployeesForm();
            form.Show();
        }

        private void informationsAboutStudentsButton_Click(object sender, EventArgs e)
        {
            informationsAboutStudentsForm form = new informationsAboutStudentsForm();
            form.Show();
        }

        private void schoolTimetableButton_Click(object sender, EventArgs e)
        {
            schoolTimetableForm form = new schoolTimetableForm();
            form.Show();
        }
    }
}