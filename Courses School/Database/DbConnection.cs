using System.Data.SqlServerCe;

namespace Courses_School.Database
{
       class DbConnection
        {
            private SqlCeConnection connection;

            private static DbConnection instance;

            private DbConnection(string connectionString)
            {
                connection = new SqlCeConnection(connectionString);
                connection.Open();
            }

            public static DbConnection Instance
            {
                get
                {
                    if (instance == null)
                        instance = new DbConnection(@"Data Source=..\..\CoursesSchoolDb.sdf");

                    return instance;
                }
            }

            public SqlCeConnection Connection
            {
                get
                {
                    return connection;
                }
            }
        }
 }


