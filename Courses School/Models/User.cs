using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Courses_School.Models
{
    public class User
    {
            private string username;
            private string password;
            private string type;

        public User(string username, string password)
            {
                Username = username;
                Password = password;
            }

            public string Username
            {
                get
                {
                    return username;
                }
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("Korisničko ime ne može biti prazno!");

                    if (value.Length > 60)
                        throw new Exception("Korisničko ime ne može biti duže od 60 karaktera!");
                     username = value;

                }
            }

            public string Password
            {
                get
                {
                    return password;
                }
                set
                {
                    if (value.Length < 6 )
                        throw new Exception("Lozinka mora da ima bar 6 karaktera!");

                    using (SHA256 sha = new SHA256Managed())
                    {
                        byte[] passwordBytes = Encoding.UTF8.GetBytes(value);
                        byte[] hashedPassword = sha.ComputeHash(passwordBytes);

                        password = Convert.ToBase64String(hashedPassword);
                    }
                }
            }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
    }
}

