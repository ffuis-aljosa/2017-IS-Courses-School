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
    public partial class informationsAboutStudentsForm : Form
    {
        public informationsAboutStudentsForm()
        {
            InitializeComponent();
        }

        private void addNewStudentButton_Click(object sender, EventArgs e)
        {
            addNewStudentForm form = new addNewStudentForm();
            form.Show();
            Hide();
        }

    }
}
