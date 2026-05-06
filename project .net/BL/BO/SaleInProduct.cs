using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInProduct
    {
        public int id { get; set; }
        public int amount { get; set; }
        public double price { get; set; }
        public bool if_it_to_all_customers { get; set; }

        public SaleInProduct()
        {
            id = 0;
            amount = 0;
            price = 0;
            if_it_to_all_customers = true;
        }

        public SaleInProduct(int id, int amount, double price, bool if_it_to_all_customers)
        {
            this.id = id;
            this.amount = amount;
            this.price = price;
            this.if_it_to_all_customers = if_it_to_all_customers;
        }
    }

}
