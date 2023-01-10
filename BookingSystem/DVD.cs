using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    internal class DVD : Item
    {
        //For example 18+
        public int AgeRestriction { get; set; }
        //blueray or normal
        public string TypeOfDvD { get; set; }
        public string size { get; set; }

        public DVD (int ageRestriction, string typeOfDvD, string size, string title): base(title)
        {
            
            AgeRestriction = ageRestriction;
            TypeOfDvD = typeOfDvD;
            this.size = size;
        }
        public override string ToString()
        {
            return $"\nTitle of DVD: {Title}\nDVD type (Blueray or normal): {TypeOfDvD} \nDVD Age Restriction: {AgeRestriction}\nDVD size: {size}";
        }
    }
}
