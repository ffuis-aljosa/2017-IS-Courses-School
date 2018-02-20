using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses_School.Models
{
    public class SchoolTimetable1
    {
        private int id;
        private string time1;
        private string monday1;
        private string tuesday1;
        private string wednesday1;
        private string thursday1;
        private string friday1;

        public SchoolTimetable1(int id, string time1, string monday1, string tuesday1, string wednesday1, string thursday1, string friday1)
        {
            this.id = id;
            Time1 = time1;
            Monday1 = monday1;
            Tuesday1 = tuesday1; 
            Wednesday1 = wednesday1;
            Thursday1 = thursday1;
            Friday1 = friday1;
        }
        public SchoolTimetable1(string time1, string monday1, string tuesday1, string wednesday1, string thursday1, string friday1)
        {
            Time1 = time1;
            Monday1 = monday1;
            Tuesday1 = tuesday1;
            Wednesday1 = wednesday1;
            Thursday1 = thursday1;
            Friday1 = friday1;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Time1
        {
            get
            {
                return time1;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Unesite vrijeme održavanja časa");
                time1 = value;
            }
        }

        public string Monday1
        {
            get
            {
                return monday1;
            }
            set
            {
                monday1 = value;
            }
        }
        public string Tuesday1
        {
            get
            {
                return tuesday1;
            }
            set
            {
                tuesday1 = value;
            }
        }
        public string Wednesday1
        {
            get
            {
                return wednesday1;
            }
            set
            {
                wednesday1 = value;
            }
        }
        public string Thursday1
        {
            get
            {
                return thursday1;
            }
            set
            {
                thursday1 = value;
            }
        }
        public string Friday1
        {
            get
            {
                return friday1;
            }
            set
            {
                friday1 = value;
            }
        }

        public override string ToString()
        {
            return time1 + " " + monday1 + " " + tuesday1 + " " + wednesday1 + " " + thursday1 + " " + friday1;
        }
    }
}
