using System;


namespace Courses_School.Models
{
    public class SchoolSubjects
    {
        private int id;
        private string school_subject;
        private int number_of_classes;
       

        public SchoolSubjects(int id, string school_subject, int number_of_classes)

        {
            this.id = id;
            School_subject = school_subject;
            Number_of_classes = number_of_classes;

        }

        public SchoolSubjects(string school_subject, string number_of_classes)
        {
            School_subject = school_subject;

            int number_of_classes_int;
            bool parseSuccessful = int.TryParse(number_of_classes, out number_of_classes_int);
            if (!parseSuccessful)
                throw new Exception("Broj časova nije dobro unesen.");
            Number_of_classes = number_of_classes_int;
        }

        public SchoolSubjects(int id, string school_subject )

        {
            this.id = id;
            School_subject = school_subject;
            

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
                    throw new Exception("Broj časova mora biti veći od 0.");

                if (value > 100)
                    throw new Exception("Broj časova mora biti manji od 100.");

                number_of_classes = value;
            }

        }
        public override string ToString()
        {
            return school_subject /*+ " " + number_of_classes*/;
        }

    }
}
