using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model.Decorator
{
    public class Lamp : TentDecorator
    {
        public Lamp(Tent tent) : base(tent)
        {
            Description = "Lamp";
            Price = 30000.00;        
            int[] numberOfItem = _tent.GetNumberOfItems();
            numberOfItem[1] += 1;
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
            return _tent.GetPrice()+this.Price;
        }
      

    }
}
