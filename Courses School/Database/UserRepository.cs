using Courses_School.Models;
using System.Data.SqlServerCe;

namespace Courses_School.Database
{
    class UserRepository
    {
           private static DbConnection connection = DbConnection.Instance;

            public static bool login(User user)
            {
                string sql = @"SELECT * FROM Users WHERE Username = @username AND Password = @password";

                SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

                SqlCeParameter username = new SqlCeParameter("@username", user.Username);
                command.Parameters.Add(username);

                SqlCeParameter password = new SqlCeParameter("@password", user.Password);
                command.Parameters.Add(password);

                command.Prepare();

                SqlCeDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    return true;

                return false;
            }
        public static void createUser(User user)
        {
            string sql = "INSERT INTO users(username, password) VALUES"
                + "(@username, @password)";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeParameter username = new SqlCeParameter("@username", user.Username);
            command.Parameters.Add(username);

            SqlCeParameter password = new SqlCeParameter("@password", user.Password);
            command.Parameters.Add(password);

            command.Prepare();

            command.ExecuteNonQuery();
        }
    }
}
    

