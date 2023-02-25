using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBaseRestaurant
{
    [Serializable]
    class Pizza : Item //DoItYourself
    {
        private List<Topping> toppings;
        public CrustType Type { get; set; }
        private PizzaSize size;
        public PizzaSize Size {
            get {   return this.size;   }
            set {   this.size = value;
                    switch (this.size)
                    {
                        case PizzaSize.SixInch: dough_price = 60; break;
                        case PizzaSize.NineInch: dough_price = 100; break;
                        case PizzaSize.TwelveInch: dough_price = 150; break;
                    }
                }
            }
        public override double Price => this.computeTotalPrice();
        private double dough_price;
        public bool CrustTypeVisibility { get; set; }

        public Pizza(CrustType type, PizzaSize size) : base(0)
        {
            this.toppings = new List<Topping>();
            this.Type = type;
            this.Size = size;
            switch(this.Size)
            {
                case PizzaSize.SixInch: dough_price = 60; break;
                case PizzaSize.NineInch: dough_price = 100; break;
                case PizzaSize.TwelveInch: dough_price = 150; break;
            }
            this.CrustTypeVisibility = false;
        }

        public void addTopping(Topping t)
        {
            if (!this.toppings.Contains(t))
                this.toppings.Add(t);
        }

        protected virtual double computeTotalPrice()
        {
            double total_price = this.dough_price;
            foreach (Topping t in this.toppings)
            {
                total_price += t.Price;
            }
            return total_price;
        }

        public override string ToString()
        {
            string str = this.Price.ToString("0.00") + "\t";
            str += "DIY Pizza (";
            List<string> str_toppings = new List<string>();
            foreach(Topping t in this.toppings)
                str_toppings.Add(t.Name);
            str += string.Join(",", str_toppings);
            str += ") ";
            switch(this.Size)
            {
                case PizzaSize.SixInch: str += " 6\""; break;
                case PizzaSize.NineInch: str += " 9\""; break;
                case PizzaSize.TwelveInch: str += " 12\""; break;
            }
            str += ((CrustTypeVisibility) ? (", " + this.Type) : "");
            return str;
        }
    }
}
