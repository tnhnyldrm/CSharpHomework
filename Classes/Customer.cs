﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        /*
        private string _firstName;
        public string FirstName { 
            get { return "mrs."+_firstName; }
            set { _firstName = value; }
        }
        */
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
