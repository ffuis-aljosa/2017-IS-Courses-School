using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses_School.Models
{
    class Exams
    {
        private int id;
        private SchoolSubjects school_subject;
        private Student student;
        private int grade;
        private string date;


        public Exams(int id, SchoolSubjects school_subject, Student student, int grade, string date)

        {
            this.id = id;
            SchoolSubject = school_subject;
            Student = student;
            Grade = grade;
            Date = date;

        }

        public Exams(SchoolSubjects school_subject, Student student, string grade, string date)

        {
            SchoolSubject = school_subject;
            Student = student;

            int grade_int;
            bool parseSuccessful2 = int.TryParse(grade, out grade_int);
            if (!parseSuccessful2)
                throw new Exception("Neispravna cijena mjesečne članarine!");
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
                if (value < 0 || value == 0 || value > 5)
                    throw new Exception("Unesite ocjenu !");
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
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Datum ne može biti prazan!");

                date = value;
            }
        }

        public override string ToString()
        {
            return grade + " " + date;
        }
    }
}
