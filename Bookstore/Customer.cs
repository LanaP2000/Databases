using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Lana
/// Customer class with all the essential information about customers (properties and constructors)
/// </summary>
/// 
namespace Assignment1
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Customer(string firstName, string lastName, string address, string city, string state, string zip, string phone, string email) // Explicit-value constructor
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }

        public Customer() { } // Default constructor
    }
}
