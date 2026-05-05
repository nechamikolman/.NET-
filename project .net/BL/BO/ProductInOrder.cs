using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public record ProductInOrder
    
        (
        int id,
        string product_name,
        double basic_price,
        int amount,
        List<BO.SaleInProduct> sales,
        double total_price
        )

    {   public ProductInOrder() : this(0,"",0,0,null,0) { }
}

}
