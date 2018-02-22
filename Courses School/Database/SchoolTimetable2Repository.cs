using Courses_School.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses_School.Database
{
    class SchoolTimetable2Repository
    {
        private static DbConnection connection = DbConnection.Instance;


        public static void addInSchoolTimetable(SchoolTimetable2 schoolTimetable)
        {
            string sql = "INSERT INTO SchoolTimetable2(time, monday, tuesday, wednesday, thursday,friday) VALUES" +
            "('" + schoolTimetable.Time + "','" + schoolTimetable.Monday + "','" + schoolTimetable.Tuesday + "','" + schoolTimetable.Wednesday + "','"
             + schoolTimetable.Thursday + "','" + schoolTimetable.Friday + "')";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }


    }
}

