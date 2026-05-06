using Dal;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    //entity of product details that available in the shop 
    public class Product
    {
        public int id { get; set; }
        public Categorys category { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int amount { get; set; }

        public Product()
        {
            id = 0;
            category = Categorys.Coffee;
            name = string.Empty;
            price = 0;
            amount = 0;
        }

        public Product(int id, Categorys category, string name, double price, int amount)
        {
            this.id = id;
            this.category = category;
            this.name = name;
            this.price = price;
            this.amount = amount;
        }

        public override string ToString() => this.ToStringProperty();
    }
}
