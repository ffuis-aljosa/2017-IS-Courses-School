using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses_School.Models
{
     public class SchoolTimetable3
    {
        private int id;
        private string time3;
        private string monday3;
        private string tuesday3;
        private string wednesday3;
        private string thursday3;
        private string friday3;

        public SchoolTimetable3(int id, string time3, string monday3, string tuesday3, string wednesday3, string thursday3, string friday3)
        {
            this.id = id;
            Time3 = time3;
            Monday3 = monday3;
            Tuesday3 = tuesday3;
            Wednesday3 = wednesday3;
            Thursday3 = thursday3;
            Friday3 = friday3;
        }
        public SchoolTimetable3(string time3, string monday3, string tuesday3, string wednesday3, string thursday3, string friday3)
        {
            Time3 = time3;
            Monday3 = monday3;
            Tuesday3 = tuesday3;
            Wednesday3 = wednesday3;
            Thursday3 = thursday3;
            Friday3 = friday3;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Time3
        {
            get
            {
                return time3;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Unesite vrijeme održavanja časa");
                time3 = value;
            }
        }

        public string Monday3
        {
            get
            {
                return monday3;
            }
            set
            {
                monday3 = value;
            }
        }
        public string Tuesday3
        {
            get
            {
                return tuesday3;
            }
            set
            {
                tuesday3 = value;
            }
        }
        public string Wednesday3
        {
            get
            {
                return wednesday3;
            }
            set
            {
                wednesday3 = value;
            }
        }
        public string Thursday3
        {
            get
            {
                return thursday3;
            }
            set
            {
                thursday3 = value;
            }
        }
        public string Friday3
        {
            get
            {
                return friday3;
            }
            set
            {
                friday3 = value;
            }
        }

        public override string ToString()
        {
            return time3 + " " + monday3 + " " + tuesday3 + " " + wednesday3 + " " + thursday3 + " " + friday3;
        }








    }
}
