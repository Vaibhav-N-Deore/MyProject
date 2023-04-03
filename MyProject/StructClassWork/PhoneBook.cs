using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.StructClassWork
{
    internal class PhoneBook
    {
        public String name;
        public String telephone;
        public String email;
        public PhoneBook(String firstname, String lastname, String eAddress)
        {
            name = firstname + " " + lastname;
            telephone = "";
            email = eAddress;
        }
        public void Clear()
        {
            name = "";
            telephone = "";
            email = "";
        }
    }
}

