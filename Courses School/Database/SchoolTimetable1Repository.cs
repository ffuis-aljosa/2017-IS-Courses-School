using Courses_School.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses_School.Database
{
    class SchoolTimetable1Repository
    {
        private static DbConnection connection = DbConnection.Instance;

        public static void addInSchoolTimetable1(SchoolTimetable1 schoolTimetable)
        {
            string sql = "INSERT INTO SchoolTimetable1(time1, monday1, tuesday1, wednesday1, thursday1,friday1) VALUES" +
            "('" + schoolTimetable.Time1 + "','" + schoolTimetable.Monday1 + "','" + schoolTimetable.Tuesday1 + "','" + schoolTimetable.Wednesday1 + "','"
             + schoolTimetable.Thursday1 + "','" + schoolTimetable.Friday1 + "')";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }
    }
}
