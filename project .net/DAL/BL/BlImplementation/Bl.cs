using BlApi;
using Dal;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class Bl : IBl
    {
        public BlApi.Icustomer customer => new CustomerImplementation();
        public BlApi.Iproduct product =>new ProductImplementation();
        public BlApi.Isale sale => new SaleImplementation();
    }
}
