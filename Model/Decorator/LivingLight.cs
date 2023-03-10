using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model.Decorator
{
    public class LivingLight : TentDecorator
    {
        public LivingLight(Tent tent) : base(tent)
        {
            Description = "Living Light";
            Price = 60000.00;
            int[] numberOfItem = _tent.GetNumberOfItems();
            numberOfItem[2] += 1;
            NumberOfItems = numberOfItem;
        }
        public override string GetDescription()
        {
            return _tent.Description;
        }

        public override int[] GetNumberOfItems()
        {
            return NumberOfItems;
        }

        public override double GetPrice()
        {
            return _tent.GetPrice() + this.Price;
        }
       
    }
}
