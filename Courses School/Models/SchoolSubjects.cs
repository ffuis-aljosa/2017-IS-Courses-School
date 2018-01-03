using System;


namespace Courses_School.Models
{
    class SchoolSubjects
    {
        private int id;
        private string school_subject;
        private int number_of_classes;
        private Employees employee;

        public SchoolSubjects(int id, string school_subject, int number_of_classes, Employees employee)

        {
            this.id = id;
            School_subject = school_subject;
            Number_of_classes = number_of_classes;
            Employee = employee;

        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string School_subject
        {
            get
            {
                return school_subject;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Naziv predmeta ne može biti prazan!");

                school_subject = value;
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
                if (value < 1)
                    throw new Exception("Broj časova mora biti veći od 1.");

                if (value > 100)
                    throw new Exception("Broj časova mora biti manji od 100.");

                number_of_classes = value;
            }

        }

        public Employees Employee
        {

            get
            {
                return employee;
            }
            set
            {
                employee = value;
            }

        }
        
    }
}
