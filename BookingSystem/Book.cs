using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    internal class Book : Item
    {
        public int NumberOfPages { get; set; }  
        public string BookID { get; set; }


        public Book(int numberofpages, string bookid, string title) : base(title)
        {
            NumberOfPages = numberofpages;
            BookID = bookid;
        }
        public override string ToString()
        {
            return $"\nBook Title: {Title}\nBook ID: {BookID}\nNumber of pages: {NumberOfPages}";
        }
    }
}
