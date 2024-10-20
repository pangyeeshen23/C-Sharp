﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Default Constructor
        public Customer()
        {
            Name = "DefaultName";
            Address = "NoAddress";
            ContactNumber = "No ContactNumber";
        }

        // Custom Constructor
        public Customer(string name, string address = "NA", string contactNumber ="NA") 
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // Default/Optional Parameter Contact Number
        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("I'm doing some customer stuff");
        }

    }
}
