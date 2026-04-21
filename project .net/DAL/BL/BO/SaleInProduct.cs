using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public record SaleInProduct
    (
        int id,
        int amount,
        double price,
        bool if_it_to_all_customers
    )
    {
        public SaleInProduct() : this(0,0,0,true) { }
    }
}
