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
                @"SELECT s.id, s.First_name1, s.Last_name1, s.Jmbg, s.Date_of_birth, s.Address,
                  s.Phone_number, s.Membership_cost, ss.school_subject, ss.number_of_classes FROM Students AS s
                   JOIN schoolsubjects AS ss ON s.school_subject_id = ss.id";
            //string sql =
            // @"SELECT * from students";
            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
         
            SqlCeDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                //int id = reader.GetInt32(0);
                //string first_name = reader.GetString(1);
                //string last_name = reader.GetString(2);
                //string jmbg = reader.GetString(3);
                //string date_of_birth = reader.GetString(4);
                //string address = reader.GetString(5);
                //string phone_number = reader.GetString(6);
                //int membership_cost = reader.GetInt32(7);
                //int schoolSubjectId = reader.GetInt32(10);
                //string schoolSubjectName = reader.GetString(11);
                //int schoolSubjectNumberOfClasses = reader.GetInt32(12);

                int id = (int)reader["id"];
                string first_name = (string)reader["first_name1"];
                string last_name = (string)reader["last_name1"];
                string jmbg = (string)reader["jmbg"];
                string date_of_birth = (string)reader["date_of_birth"];
                string address = (string)reader["address"];
                string phone_number = (string)reader["phone_number"];
                int membership_cost = (int)reader["membership_cost"];
                int schoolSubjectId = (int)reader["id"];
                string schoolSubjectName = (string)reader["school_subject"];
                int schoolSubjectNumberOfClasses = (int)reader["number_of_classes"];

                Student newStudent = new Student(id, first_name, last_name, jmbg, date_of_birth, address, phone_number, membership_cost,
                new SchoolSubjects(schoolSubjectId, schoolSubjectName, schoolSubjectNumberOfClasses));
                students.Add(newStudent);
            }

            return students;
        }

        public static void createStudent(Student student)
        {
            string sql = "INSERT INTO Students (first_name1, last_name1, jmbg, date_of_birth, address, phone_number, membership_cost, school_subject_id) VALUES" +
                "('" + student.First_name + "','" + student.Last_name + "','" + student.Jmbg + "','" + student.Date_of_birth + " " + "00:00','"
                + student.Address + "','" + student.Phone_number + "'," + student.Membership_cost + "," + student.SchoolSubject.Id + ")";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }
    }
}