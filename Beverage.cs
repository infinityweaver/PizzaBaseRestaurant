using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBaseRestaurant
{
    [Serializable]
    class Beverage : Item, ICloneable
    {
        public BeverageSize Size { get; set; }
        public BeverageFlavor Flavor { get; set; }

        public Beverage(BeverageFlavor flavor, BeverageSize size, double price) : base(price)
        {
            this.Size = size;
            this.Flavor = flavor;
        }

        public object Clone()
        {
            Beverage b = new Beverage(this.Flavor, this.Size, base.price);
            return b;
        }

        public override string ToString()
        {
            return this.Price.ToString("0.00") + "\t" + this.Flavor + " (" + this.Size + ")";
        }
    }
}
