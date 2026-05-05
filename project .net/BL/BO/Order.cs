using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public bool IsPreferredClient { get; set; } 
        public List<BO.ProductInOrder>? Products { get; set; } = new List<BO.ProductInOrder>();
        public double TotalPrice { get; set; }

    }
}
