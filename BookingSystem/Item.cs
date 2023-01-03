using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    internal class Item
    {
        //constructor
        
        public string Title { get; set; }

        public DateTime StartDate { get; set; }





        public Item ( string title, DateTime startdate)
        {
            
            Title = title;
            this.StartDate = startdate;
        }

        public override string ToString()

        {

            return $"\nItem details:\n, Title of item: {Title}\n, Start Date: {StartDate}";
        }
    }
}
