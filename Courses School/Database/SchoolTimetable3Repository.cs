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

        public static List<SchoolTimetable3> fetchAllSchoolTimetable3()
        {
            List<SchoolTimetable3> schoolTimetables = new List<SchoolTimetable3>();

            string sql = "SELECT id, time3, monday3, tuesday3, wednesday3, thursday3, friday3 FROM SchoolTimetable3";
            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                string time = (string)reader["time3"];
                string monday = (string)reader["monday3"];
                string tuesday = (string)reader["tuesday3"];
                string wednesday = (string)reader["wednesday3"];
                string thursday = (string)reader["thursday3"];
                string friday = (string)reader["friday3"];

                SchoolTimetable3 newSchoolTimetable = new SchoolTimetable3(id, time, monday, tuesday, wednesday, thursday, friday);
                schoolTimetables.Add(newSchoolTimetable);
            }
            return schoolTimetables;
        }

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

