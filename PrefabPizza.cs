using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBaseRestaurant
{
    [Serializable]
    class PrefabPizza : Pizza, ICloneable
    {
        public string Name { get; set; }

        public PrefabPizza(string name, CrustType type, PizzaSize size, double price) : base(type, size)
        {
            this.Name = name;
            base.price = price;
        }

        protected override double computeTotalPrice()
        {
            return this.price;
        }

        public override string ToString()
        {
            return this.Price.ToString("0.00") + "\t" + this.Name + ((base.CrustTypeVisibility)? (", "+base.Type):"");
        }

        public object Clone()
        {
            PrefabPizza p = new PrefabPizza(this.Name, this.Type, this.Size, base.Price);
            return p;
        }
    }
}
