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

        public static List<SchoolTimetable1> fetchAllSchoolTimetable1()
        {
            List<SchoolTimetable1> schoolTimetables = new List<SchoolTimetable1>();

            string sql = "SELECT id, time1, monday1, tuesday1, wednesday1, thursday1, friday1 FROM SchoolTimetable1";
            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                string time = (string)reader["time1"];
                string monday = (string)reader["monday1"];
                string tuesday = (string)reader["tuesday1"];
                string wednesday = (string)reader["wednesday1"];
                string thursday = (string)reader["thursday1"];
                string friday = (string)reader["friday1"];

                SchoolTimetable1 newSchoolTimetable = new SchoolTimetable1(id, time, monday, tuesday, wednesday, thursday, friday);
                schoolTimetables.Add(newSchoolTimetable);
            }
            return schoolTimetables;
        }

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
