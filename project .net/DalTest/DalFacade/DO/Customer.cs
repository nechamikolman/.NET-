using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    //entity of customer details of the shop 
    public record Customer
        (
        int id,
        string name,
        string address,
        string phone
        )
    {
        public Customer() : this(0, "", "", "") { }
    }
}
