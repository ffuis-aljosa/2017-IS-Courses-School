using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses_School.Models
{
    public class Exams
    {
        private int id;
        private SchoolSubjects school_subject;
        private Student student;
        private int grade;
        private string date;


        public Exams(int id, Student student, SchoolSubjects school_subject, int grade, string date)

        {
            this.id = id;
            Student = student;
            SchoolSubject = school_subject;
            Grade = grade;
            Date = date;

        }

        public Exams( Student student,SchoolSubjects school_subject, string grade, string date)

        {
            Student = student;
            SchoolSubject = school_subject;
            
            int grade_int;
            bool parseSuccessful2 = int.TryParse(grade, out grade_int);
            if (!parseSuccessful2)
                throw new Exception("Unesite ocjenu !");
            Grade = grade_int;

            Date = date;

        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public SchoolSubjects SchoolSubject
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


        public Student Student
        {
            get
            {
                return student;
            }
            set
            {
                student = value;
            }
        }

        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
               // if (value == 0 )
                 //   throw new Exception("Unesite ocjenu !");
                 if ( value < 0 || value > 5)
                    throw new Exception(" Pogrešan unos ocjene !");

                grade = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
               // if (string.IsNullOrEmpty(value))
                 //   throw new Exception("Datum ne može biti prazan!");

                date = value;
            }
        }

        public override string ToString()
        {
            return grade + " " + date;
        }
    }
}
