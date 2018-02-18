using System.Data.SqlServerCe;
using Courses_School.Models;



namespace Courses_School.Database
{
    class PaymentRepository
    {
        private static DbConnection connection = DbConnection.Instance;


        public static void addPayment(Payment add)
        { 
            string sql = "INSERT INTO Payment (price, date, student_id) VALUES" +
                "(" + add.Price + ",'" + add.Date + "', "+ add.Studentname.Id + ")";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }
    }
   
}
