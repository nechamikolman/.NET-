using DO;
using DalApi;

namespace Dal
{
    public class DalList:IDal
    {

        private static readonly DalList instance=new DalList();
        public static DalList Instance { get { return instance; } }
        private DalList() { }
        public Icustomer customer => new CustomerImplemention();
        public Iproduct product => new ProductImplemention();
        public Isale sale=>new SaleImplemention();



    }
}
