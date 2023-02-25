using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace PizzaBaseRestaurant
{
    public partial class OrderHome : Form
    {
        private Beverage[] beverage_menu;
        private PrefabPizza[] prefab_menu;
        private Topping[] toppings;

        public OrderHome()
        {
            InitializeComponent();
            beverage_menu = new Beverage[4];
            beverage_menu[0] = new Beverage(BeverageFlavor.Cola, BeverageSize.Small, 20);
            beverage_menu[1] = new Beverage(BeverageFlavor.Cola, BeverageSize.Large, 30);
            beverage_menu[2] = new Beverage(BeverageFlavor.Lemonade, BeverageSize.Small, 25);
            beverage_menu[3] = new Beverage(BeverageFlavor.Lemonade, BeverageSize.Large, 35);

            bevButton1.Click += addBeverage;
            bevButton2.Click += addBeverage;
            bevButton3.Click += addBeverage;
            bevButton4.Click += addBeverage;

            prefab_menu = new PrefabPizza[6];
            prefab_menu[0] = new PrefabPizza("Hawaiian (6\")", CrustType.CrispyBase, PizzaSize.SixInch, 100);
            prefab_menu[1] = new PrefabPizza("Hawaiian (9\")", CrustType.CrispyBase, PizzaSize.NineInch, 150);
            prefab_menu[2] = new PrefabPizza("Hawaiian (12\")", CrustType.CrispyBase, PizzaSize.TwelveInch, 200);
            prefab_menu[3] = new PrefabPizza("Mighty Meaty (6\")", CrustType.CrispyBase, PizzaSize.SixInch, 120);
            prefab_menu[4] = new PrefabPizza("Mighty Meaty (9\")", CrustType.CrispyBase, PizzaSize.SixInch, 180);
            prefab_menu[5] = new PrefabPizza("Mighty Meaty (12\")", CrustType.CrispyBase, PizzaSize.SixInch, 220);

            prefabList.Items.AddRange(prefab_menu);
            prefabList.SelectedIndex = 0;
            prefabAddToOrder.Click += addPrefabPizza;

            toppings = new Topping[8];
            toppings[0] = new Topping("Ham", 23.30);
            toppings[1] = new Topping("Cheese", 56.25);
            toppings[2] = new Topping("Pepperoni", 29.71);
            toppings[3] = new Topping("Chillies", 12.22);
            toppings[4] = new Topping("Onions", 15.38);
            toppings[5] = new Topping("Meat", 40.50);
            toppings[6] = new Topping("Chicken strips", 34.79);
            toppings[7] = new Topping("Olives", 24.99);

            toppingsList.Items.AddRange(toppings);
            DIYPizzaSize.DataSource = Enum.GetNames(typeof(PizzaSize));
            diyAddToOrder.Click += addDIYPizza;

            openOrderbutton.Click += openOrder;
            saveOrderButton.Click += saveOrder;
            clearOrdersButton.Click += clearOrders;
        }

        #region HelperFunctions
        private void openOrder(object sender, EventArgs args)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Order (.order)|*.order";
            ofd.FilterIndex = 0;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream f = File.OpenRead(ofd.FileName);
                BinaryFormatter bf = new BinaryFormatter();
                object[] items = (object[])bf.Deserialize(f);
                ordersList.Items.Clear();
                ordersList.Items.AddRange(items);
                f.Close();
            }
        }

        private void saveOrder(object sender, EventArgs args)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Order (.order)|*.order";
            sfd.FilterIndex = 0;
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream f = File.OpenWrite(sfd.FileName);
                BinaryFormatter bf = new BinaryFormatter();
                object[] items = new object[ordersList.Items.Count];
                ordersList.Items.CopyTo(items, 0);
                bf.Serialize(f, items);
                f.Close();
                MessageBox.Show("Your order has been saved!");
            }
        }

        private void UpdateTotalPrice()
        {
            object[] items = new object[ordersList.Items.Count];
            ordersList.Items.CopyTo(items, 0);

            double totalprice = 0;
            foreach(object i in items)
            {
                if (i is Item)
                    totalprice += ((Item)i).Price;
            }
            totalPriceDisplay.Text = "Total Price: P" + totalprice.ToString("0.00");
        }
        #endregion

        #region Events
        private void clearOrders(object sender, EventArgs args)
        {
            if (sender is Button)
            {
                ordersList.Items.Clear();
            }
        }

        private void addDIYPizza(object sender, EventArgs args)
        {
            if (sender is Button)
            {
                Topping[] selected_toppings = new Topping[toppingsList.CheckedItems.Count];
                toppingsList.CheckedItems.CopyTo(selected_toppings, 0);
                Pizza p = new Pizza((diyctype1.Checked) ? CrustType.CrispyBase : CrustType.DeepCrust,
                    (PizzaSize)Enum.Parse(typeof(PizzaSize), DIYPizzaSize.SelectedItem+""));
                foreach (Topping t in selected_toppings)
                    p.addTopping(t);
                p.CrustTypeVisibility = true;
                ordersList.Items.Add(p);
                UpdateTotalPrice();
                foreach (int i in toppingsList.CheckedIndices)
                    toppingsList.SetItemChecked(i, false);
            }
        }

        private void addPrefabPizza(object sender, EventArgs args)
        {
            if(sender is Button)
            {
                PrefabPizza p = (PrefabPizza)((PrefabPizza)prefabList.SelectedItem).Clone();
                p.Type = (ctype1.Checked) ? CrustType.CrispyBase : CrustType.DeepCrust;
                p.CrustTypeVisibility = true;
                ordersList.Items.Add(p);
                UpdateTotalPrice();
            }
        }

        private void addBeverage(object sender, EventArgs args)
        {
            if(sender is Button)
            {
                Button b = (Button)sender;
                switch(b.Text)
                {
                    case "Cola (Small)":
                        ordersList.Items.Add(beverage_menu[0].Clone());
                        break;
                    case "Cola (Large)":
                        ordersList.Items.Add(beverage_menu[1].Clone());
                        break;
                    case "Lemonade (Small)":
                        ordersList.Items.Add(beverage_menu[2].Clone());
                        break;
                    case "Lemonade (Large)":
                        ordersList.Items.Add(beverage_menu[3].Clone());
                        break;
                }
                UpdateTotalPrice();
            }
        }
        #endregion
    }
}
