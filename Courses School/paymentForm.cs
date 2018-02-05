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
            loadPayment();
            clearTextBox();
        }


        private void loadStudents()
        {
            List<Student> student = StudentRepository.fetchAllStudents();

            foreach (Student students in student)
                StudentComboBox.Items.Add(students);

        }
        private void loadPayment()
        {
               paymentListView.Items.Clear();
                SqlCeCommand command;

            command = new SqlCeCommand("SELECT s.id, s.first_name1, s.last_name1, p.price, p.date" +
                "FROM Students AS s JOIN Payment AS p ON s.id = p.student_id ", connection);

            try
                {
                    SqlCeDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["id"].ToString());
                        item.SubItems.Add(reader["first_name1"].ToString());
                        item.SubItems.Add(reader["last_name1"].ToString());
                        item.SubItems.Add(reader["price"].ToString());
                        item.SubItems.Add(reader["date"].ToString());

                        paymentListView.Items.Add(item);
                         
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
           
            }
            

        private void addPaymentButton_Click(object sender, EventArgs e)
        {
            try
            {
                newPayment = new Payment(paymentTextBox.Text, dateTimePicker.Value.ToString(),(Student)StudentComboBox.SelectedItem);
                PaymentRepository.addPayment(newPayment);
                loadPayment();
                clearTextBox();
                DialogResult = DialogResult.OK;

            }
           catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }
        private void clearTextBox()
        {
            paymentTextBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
            StudentComboBox.Text = "";
        }
    }

}


