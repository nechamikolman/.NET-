using DO;
using DalApi;

namespace DalTest;

public static class Initialization
{
    private static IDal? s_dal;

    private static void CreateProducts()
    {
        s_dal.product.Create(new Product(1, Categorys.Coffee, "Apple", 5.5, 10));
        s_dal.product.Create(new Product(2, Categorys.Extras, "Cola", 6.0, 20));
    }

    private static void CreateCustomers()
    {
        s_dal.customer.Create(new Customer(1, "Noemi", "Tel Aviv", "0501234567"));
        s_dal.customer.Create(new Customer(2, "Eli", "Jerusalem", "0527654321"));
    }

    private static void CreateSales()
    {
        s_dal.sale.Create(new Sale(1, 2, 10.0, false, DateTime.Today, DateTime.Today.AddDays(7)));
    }
    public static void Initialize(IDal sdal)
    {
        s_dal = sdal;
        CreateProducts();
        CreateCustomers();
        CreateSales();
    }

}
