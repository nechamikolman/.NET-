using DO;
using DalApi;

namespace Dal
{
    public class DalList:IDal
    {
        public Icustomer customer => new CustomerImplemention();
        public Iproduct product => new ProductImplemention();
        public Isale sale=>new SaleImplemention();



    }
}
