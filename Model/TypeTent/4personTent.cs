using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model.TypeTent
{
    public class _4personTent : Tent
    {
        public _4personTent()
        {
            Description = "4 person Tent";
            Price = 500000.00;
            NumberOfItems = new int[3] {0,0,0};
        }

        public override string GetDescription()
        {
            return string.Format("{0}", Description);
        }
        public override int[] GetNumberOfItems()
        {
            return NumberOfItems;
        }

        public override double GetPrice()
        {
            return Price;
        }

    
    }
}
