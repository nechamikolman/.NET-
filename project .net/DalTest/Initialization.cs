using DO;
using DalApi;

namespace DalTest;

public static class Initialization
{
    private static IDal? s_dal;

   
    private static void CreateCustomers()
    {
        s_dal.customer.Create(new Customer(1, "Noemi", "Tel Aviv", "0501234567"));
        s_dal.customer.Create(new Customer(2, "Eli", "Jerusalem", "0527654321"));
    }

    private static void CreateSales()
    {
        s_dal.sale.Create(new Sale(1, 2, 10.0, false, DateTime.Today, DateTime.Today.AddDays(7)));
    }

    // שינוי השם ל-Init כדי שיתאים לחיפוש ב-BlTest
    public static void Init()
    {
        // קבלת מופע ה-DAL ישירות מה-Factory
        s_dal = DalApi.Factory.Get;

        CreateProducts();
        CreateCustomers();
        CreateSales();
    }

    private static void CreateProducts()
    {
        s_dal!.product.Create(new Product(1, Categorys.Coffee, "Apple", 5.5, 10));
        s_dal!.product.Create(new Product(2, Categorys.Extras, "Cola", 6.0, 20));
    }

}
