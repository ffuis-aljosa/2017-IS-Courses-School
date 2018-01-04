using Courses_School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses_School
{
    class Employees
    {
        private int id;
        private string first_name;
        private string last_name;
        private string address;
        private string date_of_birth;
        private int phone_number;
        private string email;      
        private string qualification;
        private int number_of_classes;
        private SchoolSubjects school_subject;
        private int salary;

        public Employees (int id,string first_name,string last_name, string address, string date_of_birth, int phone_number, string email,
            string qualification, int number_of_classes, SchoolSubjects school_subject, int salary)
        {
            this.id = id;
            First_name = first_name;
            Last_name = last_name;
            Address = address;
            Date_of_birth = date_of_birth;
            Phone_number = phone_number;
            Email = email;
            Qualification = qualification;
            Number_of_classes = number_of_classes;
            SchoolSubject = school_subject;
            Salary = salary;
        }

        public Employees(string first_name, string last_name, string address, string date_of_birth, string phone_number, string email,
           string qualification, string number_of_classes, SchoolSubjects school_subject, string salary)
        {
            First_name = first_name;
            Last_name = last_name;
            Address = address;
            Date_of_birth = date_of_birth; 
            Email = email;
            Qualification = qualification;
            SchoolSubject = school_subject;

            int phone_numberInt;
            bool parseSuccessful = int.TryParse(phone_number, out phone_numberInt);
            if (!parseSuccessful)
                throw new Exception("Neispravan broj telefona.");
            Phone_number = phone_numberInt;

            int number_of_classesInt;
            bool parseSuccessfull = int.TryParse(number_of_classes, out number_of_classesInt);
            if (!parseSuccessfull)
                throw new Exception("Neispravan broj casova.");
            Number_of_classes = phone_numberInt;

            int salaryInt;
            bool parse_Successful = int.TryParse(salary, out salaryInt);
            if (!parse_Successful)
                throw new Exception("Neispavna plata.");
            Salary = salaryInt;
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

        public int Phone_number
        {
            get
            {
                return phone_number;
            }
            set
            {
                if (value < 0 || value  == 0)
                    throw new Exception(" Neispravna plata !");

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

        public int Number_of_classes
        {
            get
            {
                return number_of_classes;
            }
            set
            {
                if (value < 0 || value == 0)
                    throw new Exception("Neispravan broj časova!");

                number_of_classes = value;
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

        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 0 || value == 0)
                    throw new Exception("Neispravna plata !");

                salary = value;
            }
        }
    }
}
