using System;


namespace Courses_School.Models
{
    class Student
    {
        private int id;
        private string first_name;
        private string last_name;
        private int jmbg;
        private string date_of_birth;
        private string address;
        private int phone_number;
        private int membership_cost;


        public Student(int id, string first_name, string last_name, string jmbg, string date_of_birth,
            string address, string phone_number, string membership_cost)

        {
            this.id = id;
            First_name = first_name;
            Last_name = last_name;
            Date_of_birth = date_of_birth;
            Address = address;

            int jmbgInt;
            bool parseSuccessful = int.TryParse(jmbg, out jmbgInt);
            if (!parseSuccessful)
                throw new Exception("Neispravan matični broj!");
            Jmbg = jmbgInt;

            int phone_numberInt;
            bool parseSuccessful1 = int.TryParse(phone_number, out phone_numberInt);
            if (!parseSuccessful1)
                throw new Exception("Neispravan broj telefona!");
            Phone_number = phone_numberInt;

            int membership_costInt;
            bool parseSuccessful2 = int.TryParse(membership_cost, out membership_costInt);
            if (!parseSuccessful2)
                throw new Exception("Neispravna cijena mjesečne članarine!");
            Membership_cost = membership_costInt;

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
        public string Date_of_birth
        {
            get
            {
                return date_of_birth;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Datum i mjesto rođenja ne može biti prazano!");

                date_of_birth = value;
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
        public int Membership_cost
        {
            get
            {
                return membership_cost;
            }
            set
            {
                if (value < 0 || value == 0)
                    throw new Exception("Potrebno je unijeti mjesečnu cijenu članarine!");
                membership_cost = value;
            }
        }

        public override string ToString()
        {
            return first_name + " " + last_name + " " + jmbg + " " + date_of_birth + " " + address + " "
                + phone_number + " " + membership_cost;
        }

    }
}
