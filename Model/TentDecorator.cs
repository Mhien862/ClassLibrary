using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class TentDecorator : Tent
    {
        protected Tent _tent;

        public TentDecorator(Tent tent)
        {
            _tent = tent;
        }
        public override string GetDescription()
        {
            return _tent.Description;
        }     

        public override int[] GetNumberOfItems()
        {
            return _tent.GetNumberOfItems();
        }

        public override double GetPrice()
        {
            return _tent.GetPrice();
        }     
    }
}
