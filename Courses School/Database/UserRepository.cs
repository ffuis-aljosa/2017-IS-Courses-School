using Courses_School.Models;
using System.Data.SqlServerCe;

namespace Courses_School.Database
{
    class UserRepository
    {
           private static DbConnection connection = DbConnection.Instance;

            public static User login(User user)
            {
                string sql = @"SELECT * FROM Users WHERE Username = @username AND Password = @password ";

                SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

                SqlCeParameter username = new SqlCeParameter("@username", user.Username);
                command.Parameters.Add(username);

                SqlCeParameter password = new SqlCeParameter("@password", user.Password);
                command.Parameters.Add(password);

              //  SqlCeParameter type = new SqlCeParameter("@type", user.Type);
               // command.Parameters.Add(type);

            command.Prepare();
           

                SqlCeDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                user.Type = reader["type"].ToString();
                return user;
            }

            return null;
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

            //SqlCeParameter type = new SqlCeParameter("@type", user.Type);
            //command.Parameters.Add(type);

            command.Prepare();

            command.ExecuteNonQuery();
        }
    }
}
    

