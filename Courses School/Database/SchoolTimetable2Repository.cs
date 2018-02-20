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


        public static List<SchoolTimetable2> fetchAllSchoolTimetable2()
        {
            List<SchoolTimetable2> schoolTimetables = new List<SchoolTimetable2>();

            string sql = "SELECT id, time, monday, tuesday, wednesday, thursday, friday FROM SchoolTimetable2";
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

                SchoolTimetable2 newSchoolTimetable = new SchoolTimetable2(id, time, monday, tuesday, wednesday, thursday, friday);
                schoolTimetables.Add(newSchoolTimetable);
            }
            return schoolTimetables;
        }



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

