using Courses_School.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses_School.Database
{
    class SchoolTimetable3Repository
    {
        private static DbConnection connection = DbConnection.Instance;

      
        public static void addInSchoolTimetable3(SchoolTimetable3 schoolTimetable)
        {
            string sql = "INSERT INTO SchoolTimetable3(time3, monday3, tuesday3, wednesday3, thursday3, friday3) VALUES" +
            "('" + schoolTimetable.Time3 + "','" + schoolTimetable.Monday3 + "','" + schoolTimetable.Tuesday3 + "','" + schoolTimetable.Wednesday3 + "','"
             + schoolTimetable.Thursday3 + "','" + schoolTimetable.Friday3 + "')";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }
    }
}

