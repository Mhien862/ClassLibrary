using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model.TypeTent
{
    public class _6personTent : Tent
    {
        public _6personTent()
        {
            Description = "6 person Tent";
            Price = 700000.00;
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

        public override double  GetPrice()
        {
            return Price;
        }

      
    }
}
