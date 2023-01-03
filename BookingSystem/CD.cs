using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem 
{
    internal class CD : Item
    {
        public string CdUniqueCOde { get; set; }
        public string CDsize { get; set; }
        //inheriting properties from item class

        public CD (string cdUniqueCOde, string cDsize, string Title, DateTime StartDate): base (Title, StartDate)
        {
            CDsize = cDsize;
            CdUniqueCOde = cdUniqueCOde;
        }

        public override string ToString()
        {
            return $"\nCD  details:\n, Title of item: {Title}\n,CD Code: {CdUniqueCOde}\n,CD Size: {CDsize}, Start Date: {StartDate}";
        }
    }
}
