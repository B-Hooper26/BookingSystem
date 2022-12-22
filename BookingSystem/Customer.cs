using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace BookingSystem
{
    internal class Customer
    {
        //customer properties
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        //constructor
        public Customer (string name, string address, string email, string phonenumber)
        {
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phonenumber;
        }
        public override string ToString()
        {
            //creating conditions so data enter is correct data
            if (Email.Contains("@") && PhoneNumber.Length == 11)
            {
                return $"Customer Details\n\n Name: {Name}\nAddress: {Address}\n Email: {Email}\n Phone Number: {PhoneNumber}";
            }
            else
            {
                return "Error";
            }
        }
    }

}
