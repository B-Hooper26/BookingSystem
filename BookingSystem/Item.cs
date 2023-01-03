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

        





        public Item ( string title)
        {
            
            Title = title;
            
        }

        public override string ToString()

        {

            return $"\n\tItem details:\nTitle of item: {Title}";
        }
    }
}
