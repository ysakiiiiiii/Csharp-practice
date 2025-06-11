using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    internal class Customer
    {
        private static int nextID = 0;

        private readonly int _customerID;

        private string _password;

        public string Password
        {
            set
            {
                _password = value;
            }
        }

        public int Id 
        { 
            get { return _customerID; } 
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public Customer()
        {
            _customerID = nextID++;
            Name = "Guest";
            Address = "Unknown Address";
            ContactNumber = "No Number";
        }

        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            _customerID = nextID++; 
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public Customer(string name)
        {
            _customerID = nextID++;
            Name = name;
        }

        public void setDetails(string name, string address = "NA", string contactNumber="NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
        
        public void showDetails()
        {
            Console.WriteLine($"Customer Name : {Name}\nID : {_customerID}");
        }

    }
}
