using Courses_School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses_School
{
    public class Employees
    {
        private int id;
        private string first_name;
        private string last_name;
        private string address;
        private string date_of_birth;
        private string phone_number;
        private string email;      
        private string qualification;
        private SchoolSubjects school_subject;
        private string salary;

        public Employees (int id,string first_name,string last_name, string address, string date_of_birth, string phone_number, string email,
            string qualification, SchoolSubjects school_subject, string salary)
        {
            this.id = id;
            First_name = first_name;
            Last_name = last_name;
            Address = address;
            Date_of_birth = date_of_birth;
            Phone_number = phone_number;
            Email = email;
            Qualification = qualification;
            SchoolSubject = school_subject;
            Salary = salary;
        }

        public Employees(string first_name, string last_name, string address, string date_of_birth, string phone_number, string email,
           string qualification, SchoolSubjects school_subject, string salary)
        {
            First_name = first_name;
            Last_name = last_name;
            Address = address;
            Date_of_birth = date_of_birth;
            Phone_number = phone_number;
            Email = email;
            Qualification = qualification;
            SchoolSubject = school_subject;
            Salary = salary;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string First_name
        {
            get
            {
                return first_name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Ime ne može biti prazno !");

                first_name = value;
            }
        }

        public string Last_name
        {
            get
            {
                return last_name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Prezime ne može biti prazno !");

                last_name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Adresa ne smije biti prazna !");

                address = value;
            }
        }

        public string Date_of_birth
        {
            get
            {
                return date_of_birth;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Datum rođenja ne moze biti prazan !");

                date_of_birth = value;
            }
        }

        public string Phone_number
        {
            get
            {
                return phone_number;
            }
            set
            {
                phone_number = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("E-mail ne moze biti prazan !");

                email = value;
            }
        }

        public string Qualification
        {
            get
            {
                return qualification;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Zanimanje ne moze biti prazno !");

                qualification = value;
            }
        }

        public  SchoolSubjects SchoolSubject
        {
            get
            {
                return school_subject;
            }
            set
            {
                school_subject = value;
            }
        }

        public string Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public override string ToString()
        {
            return first_name + " " + last_name + " " + address + " " + date_of_birth + " " + phone_number +  " "
                + email + " " + qualification + " " + salary;
        }
    }
}
