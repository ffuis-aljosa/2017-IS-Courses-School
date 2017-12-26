using System;


namespace Courses_School.Models
{
    class Student
    {
        private int id;
        private string first_name;
        private string last_name;
        private int jmbg;
        private string date_and_place_of_birth;
        private string address;
        private int phone_number;
        private int membership_fees;


        public Student(int id, string first_name, string last_name, int jmb, string date_and_place_of_birth,
            string address, int phone_number, int membership_fees)
            
        {
            this.id = id;
            First_name = first_name;
            Last_name = last_name;
            Jmbg = jmbg;
            Date_and_place_of_birth = date_and_place_of_birth;
            Address = address;
            Phone_number = phone_number;
            Membership_fees = membership_fees;

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
                    throw new Exception("Ime ne može biti prazno!");

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
                    throw new Exception("Prezime ne može biti prazno!");

                last_name = value;
            }
        }
        public int Jmbg
        {
            get
            {
                return jmbg;
            }
            set
            {
                if (value != 13)
                    throw new Exception("Neispravan matični broj!");

                jmbg = value;
            }

        }
        public string Date_and_place_of_birth
        {
            get
            {
                return date_and_place_of_birth;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Datum i mjesto rođenja ne može biti prazano!");

                date_and_place_of_birth = value;
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
                    throw new Exception("Adresa stanovanja ne smije biti prazna!");

                address = value;
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
                if (value < 0 || value == 0)
                    throw new Exception("Neispravna broj telefona!");

                phone_number = value;
            }
        }
       public int Membership_fees
        {
            get
            {
                return membership_fees;
            }
            set
            {
                if (value < 0 || value == 0)
                    throw new Exception("Potrebno je unijeti mjesečnu cijenu članarine!");
                membership_fees = value;
            }
        }

    }
}
