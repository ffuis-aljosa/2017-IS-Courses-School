using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using Courses_School.Models;


namespace Courses_School.Database
{
    class ExamRepository
    {
        private static DbConnection connection = DbConnection.Instance;


        public static void addExam(Exams exam)
        {
            string sql = "INSERT INTO Exams (school_subject_id,student_id, grade, date) VALUES" +
            "(" + exam.SchoolSubject.Id + "," + exam.Student.Id + ", " + exam.Grade + ",'" + exam.Date + "')";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }
    }
}
