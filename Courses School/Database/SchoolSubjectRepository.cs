using Courses_School.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses_School.Database
{
    class SchoolSubjectRepository
    {
        private static DbConnection connection = DbConnection.Instance;

        public static List<SchoolSubjects> fetchAllSchoolSubjects()
        {
            List<SchoolSubjects> schoolSubjects = new List<SchoolSubjects>();

            string sql = "SELECT id, school_subject, number_of_classes FROM schoolSubjects";
            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                string school_subject = (string)reader["school_subject"];
                int number_of_classes = (int)reader["number_of_classes"];

                SchoolSubjects schoolSubject = new SchoolSubjects(id, school_subject, number_of_classes);
                schoolSubject.Add(schoolSubject);
            }
            return schoolSubjects;
        }   
    }
}
