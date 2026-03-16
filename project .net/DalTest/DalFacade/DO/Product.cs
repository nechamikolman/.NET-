using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    //entity of product details that available in the shop 
    public record Product
        (
        int id,
        Categorys category,
        string name,
        double price,
        int amount
        )
    {
        public Product() : this(0,Categorys.Coffee, "", 0, 0) { }
    }
}
