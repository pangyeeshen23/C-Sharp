using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Customer
    {
        // Static field to hold the next ID available
        private static int nextId = 0;
        
        // Read-only instance field initialized from the constructor
        private readonly int _id;

        // Backing field for write-only property
        private string _password;


        // Write-Only property
        public string Password { set { 
                _password = value;
            }
        }

        //Read Only Property
        public int Id { get
            {  return _id; }
        }


        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Default Constructor
        // Custom Constructor
        public Customer()
        {
            _id = nextId++;
            Name = "DefaultName";
            Address = "NoAddress";
            ContactNumber = "No ContactNumber";
        }

        // Custom Constructor
        public Customer(string name, string address = "NA", string contactNumber ="NA") 
        {
            _id = nextId++;
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

        public void Get()
        {
            Console.WriteLine($"Details about the customer: Name is {Name} and Id is {_id} and the password is {_password}");
        }

        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("I'm doing some customer stuff");
        }

    }
}
