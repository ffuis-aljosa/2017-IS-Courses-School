using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses_School.Models;

namespace Courses_School.Database
{
    class EmployeeRepository
    {
        private static DbConnection connection = DbConnection.Instance;
        public static List<Employees> fetchAllEmployees()

        {
            List<Employees> employees = new List<Employees>();

            string sql =
                @"SELECT e.id, e.first_name, e.last_name, e.address, e.date_of_birth, e.phone_number, e.email, e.qualification,
                  e.number_of_classes, e.salary, e.school_subject_id, s.school_subject 
                  FROM employees AS e JOIN schoolsubjects AS s ON e.school_subject_id = s.id";

            System.Data.SqlServerCe.SqlCeCommand command = new System.Data.SqlServerCe.SqlCeCommand(sql, connection.Connection);

            SqlCeDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string first_name = reader.GetString(1);
                string last_name = reader.GetString(2);
                string address = reader.GetString(3);
                string date_of_birth = reader.GetString(4);
                int phone_number = reader.GetInt32(5);
                string email = reader.GetString(6);
                string qualification = reader.GetString(7);
                int salary = reader.GetInt32(9);
                int schoolSubjectId = reader.GetInt32(10);
                string schoolSubjectName = reader.GetString(11);
                int schoolSubjectNumberOfClasses = reader.GetInt32(12);

                Employees newEmployee = new Employees(id, first_name, last_name, address, date_of_birth, phone_number, email, qualification,
                     new SchoolSubjects(schoolSubjectId, schoolSubjectName, schoolSubjectNumberOfClasses), salary);
                     employees.Add(newEmployee);
            }
            return employees;
        }

        public static void createEmployee(Employees employee)
        {
            string sql = "INSERT INTO employees (first_name,last_name,address,date_of_birth,phone_number,email,qualification,number_of_classes, school_subject_id,salary) VALUES " +
                    "('" + employee.First_name + "', " + employee.Last_name + ", " + employee.Address + ", " + employee.Date_of_birth + ", "
                    + employee.Phone_number + ", " + employee.Email + ", " + employee.Qualification + ", "
                    + employee.SchoolSubject.Id + ")"
                    + employee.Salary + ", ";

            System.Data.SqlServerCe.SqlCeCommand command = new System.Data.SqlServerCe.SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }



    }
}
