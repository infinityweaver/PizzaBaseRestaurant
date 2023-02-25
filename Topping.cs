using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBaseRestaurant
{
    [Serializable]
    class Topping : ICloneable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Topping(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override bool Equals(object obj)
        {
            bool result = false;
            if(obj is Topping)
            {
                if (((Topping)obj).Name == this.Name)
                    result = true;
            }
            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return this.Name + " (P" + this.Price.ToString("0.00") + ")";
        }

        public object Clone()
        {
            Topping t = new Topping(this.Name, this.Price);
            return t;
        }
    }
}
