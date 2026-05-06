using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    //entity of sale details that available in the shop 
    public class Sale
    {
        public int id_product { get; set; }
        public int amount_required { get; set; }
        public double final_price { get; set; }
        public bool if_general_sale { get; set; }
        public DateTime date_start_sale { get; set; }
        public DateTime date_finish_sale { get; set; }

        public Sale()
        {
            id_product = 0;
            amount_required = 0;
            final_price = 0;
            if_general_sale = false;
            date_start_sale = DateTime.Today;
            date_finish_sale = DateTime.Today;
        }

        public Sale(int id_product, int amount_required, double final_price, bool if_general_sale, DateTime date_start_sale, DateTime date_finish_sale)
        {
            this.id_product = id_product;
            this.amount_required = amount_required;
            this.final_price = final_price;
            this.if_general_sale = if_general_sale;
            this.date_start_sale = date_start_sale;
            this.date_finish_sale = date_finish_sale;
        }

        public override string ToString() => this.ToStringProperty();
    }
}
