using Courses_School.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses_School.Database
{
    class SchoolTimetableRepository
    {
        private static DbConnection connection = DbConnection.Instance;


        public static List<SchoolTimetable> fetchAllSchoolTimetable()
        {
            List<SchoolTimetable> schoolTimetables = new List<SchoolTimetable>();

            string sql = "SELECT id, time, monday, tuesday, wednesday thursday, friday FROM SchoolTimetable";
            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                string time = (string)reader["time"];
                string monday = (string)reader["monday"];
                string tuesday = (string)reader["tuesday"];
                string wednesday = (string)reader["wednesday"];
                string thursday = (string)reader["thursday"];
                string friday = (string)reader["friday"];

                SchoolTimetable newSchoolTimetable = new SchoolTimetable(id, time, monday, tuesday, wednesday, thursday, friday);
                schoolTimetables.Add(newSchoolTimetable);
            }
            return schoolTimetables;
        }



        public static void addInSchoolTimetable(SchoolTimetable schoolTimetable)
        {
            string sql = "INSERT INTO SchoolTimetable(time, monday, tuesday, wednesday, thursday,friday) VALUES" +
            "('" + schoolTimetable.Time + "','" + schoolTimetable.Monday + "','" + schoolTimetable.Tuesday + "','" + schoolTimetable.Wednesday + "','"
             + schoolTimetable.Thursday + "','" + schoolTimetable.Friday + "')";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }


    }
}

