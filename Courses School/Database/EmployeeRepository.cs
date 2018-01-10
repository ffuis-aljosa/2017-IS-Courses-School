using System.Data.SqlServerCe;
using System.Collections.Generic;
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
                @"SELECT e.Id, e.First_name, e.Last_name, e.Address, e.date_of_birth, e.phone_number, e.email, e.qualification,
                  e.salary, e.schoolSubject_id, s.school_subject 
                  FROM employees AS e JOIN schoolsubjects AS s ON e.schoolSubject_id = s.id";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string first_name = reader.GetString(1);
                string last_name = reader.GetString(2);
                string address = reader.GetString(3);
                string date_of_birth = reader.GetString(4);
                string phone_number = reader.GetString(5);
                string email = reader.GetString(6);
                string qualification = reader.GetString(7);
                string salary = reader.GetString(9);
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
            string sql = "INSERT INTO employees (first_name,last_name,address,date_of_birth,phone_number,email,qualification, schoolSubject_id,salary) VALUES " +
                    "('" + employee.First_name + "', '" + employee.Last_name + "', '" + employee.Address + "', '" + employee.Date_of_birth + " " + "00:00', '"
                    + employee.Phone_number + "', '" + employee.Email + "', '" + employee.Qualification + "', "
                    + employee.SchoolSubject.Id + ",'"
                    + employee.Salary + "') ";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }
    }
}
