using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    internal class BookingDetails
    {
        //fee for any overdue items
        public int CustomerFee { get; set; }
        public string CustomerReference { get; set; }

        public BookingDetails (int customerFee, string customerReference)
        {
            CustomerFee = customerFee;
            CustomerReference = customerReference;
        }
    }
}
