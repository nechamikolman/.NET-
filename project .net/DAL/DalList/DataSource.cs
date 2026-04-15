
namespace Dal;
using DO;
internal static class DataSource
{
    internal static List<Customer>? Scustomers = new List<Customer>();
    internal static List<Sale>? Ssale = new List<Sale>();
    internal static List<Product>? Sproduct = new List<Product>();

    internal static class Config
    {
        internal const int ProductMinCode =100;
        internal const int SaleMinCode=200;
        private static int ProductIndex = ProductMinCode;
        private static int SaleIndex = SaleMinCode;
        public static int ProductId=>ProductIndex+=1;
        public static int SaleId => SaleIndex +=1;

    }
}
