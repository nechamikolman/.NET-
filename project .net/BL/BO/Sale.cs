using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    //entity of sale details that available in the shop 
    public record Sale
        (
        int id_product,
        int amount_required,
        double final_price,
        bool if_general_sale,
        DateTime date_start_sale,
        DateTime date_finish_sale
        )
    {
        public Sale() : this(0, 0, 0, false, DateTime.Today, DateTime.Today) { }
    } 
}
