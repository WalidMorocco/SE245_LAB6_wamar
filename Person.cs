 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE245_LAB5_wamar
{
    class Person
    {
        private string fName, mName, lName, street1, street2, city, state, zip, phone, email;
        protected string feedback;
        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {   
                    fName = value;
                }

                else
                {
                    feedback += "\n ERROR : Enter the first name";
                }
            }

        }
        public string MName
        {
            get
            {
                return mName;
            }
            set
            {
                if (!ValidationLibrary.GotBadWords(value))
                {
                    mName = value;
                }
                else
                {
                    feedback += "\n ERROR : Middle name has a bad word";
                }
            }

        }
        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    lName = value;
                }
                else
                {
                    feedback += "\n ERROR : Enter the last name";
                }
            }

        }
        public string Street1
        {
            get
            {
                return street1;
            }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    street1 = value;
                }
                else
                {
                    feedback += "\n ERROR : Enter the street name";
                }
            }

        }
        public string Street2
        {
            get
            {
                return street2;
            }
            set
            {
                if (!ValidationLibrary.GotBadWords(value))
                {
                    mName = value;
                }
                else
                {
                    feedback += "\n ERROR : Street 2 name has a bad word";
                }
            }

        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    city = value;
                }
                else
                {
                    feedback += "\n ERROR : Enter the city name";
                }
            }

        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                if (ValidationLibrary.IsValidState(value))
                {
                    state = value;
                }
                else
                {
                    feedback += "\n ERROR : Invalid state syntax";
                }
            }

        }
        public string Zip
        {
            get
            {
                return zip;
            }
            set
            {
                if (ValidationLibrary.IsValidZip(value))
                {
                    zip = value;
                }
                else
                {
                    feedback += "\n ERROR : Invalid zip syntax";
                }
            }

        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if (ValidationLibrary.IsValidPhone(value))
                {
                    phone = value;
                }
                else
                {
                    feedback += "\n ERROR : Invalid phone syntax";
                }
            }

        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (ValidationLibrary.IsValidEmail(value))
                {
                    email = value;
                }
                else
                {
                    feedback += "\n ERROR : Invalid email syntax";
                }
            }

        }

        public string Feedback
        {
            get
            {
                return feedback;
            }
        }

        public Person()
        {
            fName = "";
            mName = "";
            lName = "";
            street1 = "";
            street2 = "";
            city = "";
            state = "";
            phone = "";
            email = "";
            feedback = "";
        }
    }
}
