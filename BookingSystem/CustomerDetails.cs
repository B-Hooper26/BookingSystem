using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{

    internal class CustomerDetails : Customer
    {

        public CustomerDetails(string name, string address, string email, string phonenumber,int customerfee) : base(name, address, email, phonenumber, customerfee)
        {

        }
    }
}
