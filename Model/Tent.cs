using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public abstract class Tent
    {
        public double Price { get; set; }
        public int[] NumberOfItems { get; set; }
        public string Description { get; set; }
        public abstract string GetDescription();
        public abstract int[] GetNumberOfItems();
        public abstract double GetPrice();
    }
}
