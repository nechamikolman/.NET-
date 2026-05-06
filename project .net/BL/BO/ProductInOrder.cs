using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{    
    public class ProductInOrder
    {
        public int id { get; set; }
        public string product_name { get; set; }
        public double basic_price { get; set; }
        public int amount { get; set; }
        public List<BO.SaleInProduct> sales { get; set; }
        public double total_price { get; set; }

        public ProductInOrder()
        {
            id = 0;
            product_name = string.Empty;
            basic_price = 0;
            amount = 0;
            sales = new List<SaleInProduct>();
            total_price = 0;
        }

        public ProductInOrder(int id, string product_name, double basic_price, int amount, List<BO.SaleInProduct> sales, double total_price)
        {
            this.id = id;
            this.product_name = product_name;
            this.basic_price = basic_price;
            this.amount = amount;
            this.sales = sales ?? new List<SaleInProduct>();
            this.total_price = total_price;
        }
    }

    
    
}
