using System;
using System.Windows.Forms;
using Courses_School.Models;
using Courses_School.Database;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Data;


namespace Courses_School
{
    public partial class paymentForm : Form
    {
        public Payment newPayment { get; set; }

        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public paymentForm()
        {
            InitializeComponent();
            loadStudents();
       
        }


        private void loadStudents()
        {
            //SqlCeCommand cm = new SqlCeCommand("SELECT first_name1, last_name1 FROM Students", connection);

            //try
            //{
            //    SqlCeDataReader dr = cm.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        StudentComboBox.Items.Add(dr["first_name1"] + " " + dr["last_name1"]);
            //    }
            //    dr.Close();
            //    dr.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            List<Student> student = StudentRepository.fetchAllStudents();

            foreach (Student students in student)
                StudentComboBox.Items.Add(students);

        }

        private void addPaymentButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                newPayment = new Payment(paymentTextBox.Text, dataTextBox.Text,(Student)StudentComboBox.SelectedItem);
                PaymentRepository.addPayment(newPayment);
                DialogResult = DialogResult.OK;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
        

}


