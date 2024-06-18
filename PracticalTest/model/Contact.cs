using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalTest.model
{
    public class Contact
    {
        public String Name{ get; set; }
        public String PhoneNumber{ get; set; }

        public Contact(string name, string phoneNumber)
        {
        Name = name;
        PhoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return string.Format("{0,-20} {1}", Name, PhoneNumber);
        }

    }
}