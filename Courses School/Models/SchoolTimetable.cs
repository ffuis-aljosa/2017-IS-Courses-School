using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses_School.Models
{
    public class SchoolTimetable
    {
        private int id;
        private string time;
        private string monday;
        private string tuesday;
        private string wednesday;
        private string thursday;
        private string friday;


        public SchoolTimetable(int id, string time, string monday, string tuesday, string wednesday, string thursday, string friday)
        {
            this.id = id;
            Time = time;
            Monday = monday;
            Tuesday = tuesday;
            Wednesday = wednesday;
            Thursday = thursday;
            Friday = friday;

        }

        public SchoolTimetable(string time, string monday, string tuesday, string wednesday, string thursday, string friday)
        {

            Time = time;
            Monday = monday;
            Tuesday = tuesday;
            Wednesday = wednesday;
            Thursday = thursday;
            Friday = friday;

        }

        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Monday
        {
            get
            {
                return monday;
            }
            set
            {
                monday = value;
            }

        }
        public string Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }
        public string Tuesday
        {
            get
            {
                return tuesday;
            }
            set
            {
                tuesday = value;
            }
        }
        public string Wednesday
        {
            get
            {
                return wednesday;
            }
            set
            {
                wednesday = value;
            }
        }
        public string Thursday
        {
            get
            {
                return thursday;
            }
            set
            {
                thursday = value;
            }
        }
        public string Friday
        {
            get
            {
                return friday;
            }
            set
            {
                friday = value;
            }
        }

        public override string ToString()
        {
            return time + " " + monday + " " + tuesday + " " + wednesday + " " + thursday + " " + friday;
        }



    }
}


