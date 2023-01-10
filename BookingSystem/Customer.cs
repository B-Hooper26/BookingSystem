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
        public int CustomerFee { get; set; }

        //constructor
        public Customer (string name, string address, string email, string phonenumber,int customerfee)
        {
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phonenumber;  
            CustomerFee = customerfee;


        }
        public override string ToString()
        {
            //creating conditions so data enter is correct data
            if (Email.Contains("@") && Email.Contains(".com") && PhoneNumber.Length == 11)
            {
                return $"\nName: {Name}\nAddress: {Address}\nEmail: {Email}\nPhone Number: {PhoneNumber}\n";
            }
            else
            {
                return "Error";
            }
        }
    }

}
