using System;


namespace Courses_School.Models
{
   public class Payment
    {
        private int id;
        private Student studentname;
        private int price;
        private string date;
      

        public Payment(int id,int price, string date, Student studentname)

        {
            this.id = id;
            Price = price;
            Date = date;
            Studentname = studentname;

        }

        public Payment(string price, string date, Student studentname)

        {
            Date = date;
            Studentname = studentname;
            int price_int;
            bool parseSuccessful = int.TryParse(price, out price_int);
            if (!parseSuccessful)
                throw new Exception("Greška!");
            Price = price_int;
          
            //DateTime date_int;
            //bool parseSuccessful1 = DateTime.TryParse(payment, out date_int);
            //if (!parseSuccessful)
            //    throw new Exception("Greška!");


        }


        public int Id
        {
            get
            {
                return id;
            }
        }
      
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
               
                price = value;
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
                 date = value;
            }
        }

        public Student Studentname
        {
            get
            {
                return studentname;
            }
            set
            {
                studentname = value;
            }
        }



        public override string ToString()
        {
            return price + " " + date;
        }
    }
}
