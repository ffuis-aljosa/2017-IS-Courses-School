using System.Data.SqlServerCe;
using System.Collections.Generic;
using Courses_School.Models;

namespace Courses_School.Database
{
    class StudentRepository
    {
        private static DbConnection connection = DbConnection.Instance;
        public static List<Student> fetchAllStudents()
        {
            List<Student> students = new List<Student>();

            string sql =
                @"SELECT s.id, s.First_name, s.Last_name, s.Jmbg, s.Date_of_birth, s.Address,
                  s.Phone_number, s.Membership_cost FROM Students AS s";
            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                int id = reader.GetInt32(0);
                string first_name = reader.GetString(1);
                string last_name = reader.GetString(2);
                string jmbg = reader.GetString(3);
                string date_of_birth = reader.GetString(4);
                string address = reader.GetString(5);
                string phone_number = reader.GetString(6);
                int membership_cost = reader.GetInt32(7);


                Student newStudent = new Student(id, first_name, last_name, jmbg, date_of_birth, address, phone_number, membership_cost);
                students.Add(newStudent);
            }

            return students;
        }

        public static void createStudent(Student student)
        {
            string sql = "INSERT INTO Students (first_name, last_name, jmbg, date_of_birth, address, phone_number, membership_cost) VALUES" +
                "('" + student.First_name + "','" + student.Last_name + "','" + student.Jmbg + "','" + student.Date_of_birth + " " + "00:00','"
                + student.Address + "','" + student.Phone_number + "'," + student.Membership_cost + ")";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }
    }
}