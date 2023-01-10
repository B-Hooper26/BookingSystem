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

        public CD (string cdUniqueCOde, string cDsize, string Title): base (Title)
        {
            CDsize = cDsize;
            CdUniqueCOde = cdUniqueCOde;
        }

        public override string ToString()
        {
            return $"\nTitle of item: {Title}\nCD Code: {CdUniqueCOde}\nCD Size: {CDsize}";
        }
    }
}
