using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorStudent
{
    public class TextBook
    {
        public bool HasBeenRead { get; set; }

        public TextBook()
        {
            HasBeenRead = false;
        }

        public void ReadBook()
        {
            HasBeenRead = true;
        }

        public void DrinkBeerInstead()
        {
            HasBeenRead = false;
        }
    }
}
