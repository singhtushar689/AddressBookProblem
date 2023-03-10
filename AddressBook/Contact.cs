using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        //This is a model class
        public string Name { get; set; }
        public string LastName { get; set; }    

        public string Address { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
