using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBaseRestaurant
{
    [Serializable]
    abstract class Item
    {
        protected double price;
        public virtual double Price
        {
            get
            {
                return this.price;
            }
        }

        public Item(double price)
        {
            this.price = price;
        }
    }
}
