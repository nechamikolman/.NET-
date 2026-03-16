using DO;
using DalApi;
using System.Diagnostics;
using Dal;

namespace DalTest;
internal class Program
{
    private static IDal s_dal=new DalList();

    private static void ProductMenu()
    {
        int choose;
        Console.WriteLine("choose 1 to create, 2 read,3 readAll, 4 to update, 5 to delete");
        choose = int.Parse(Console.ReadLine());
        switch (choose)
        {
            case 1:
                AddProduct();
                break;
            case 2:
                Console.WriteLine("insert id to read");
                Read<Product>(s_dal.product);
                break;
            case 3:
                ReadAll<Product>(s_dal.product);
                break;
            case 4:
                UpdateProduct();
                break;
            case 5:
                Console.WriteLine("insert id to delete");
                Delete<Product>(s_dal.product);
                break;
        }
    }
    private static void CustomerMenu()
    {
        int choose;
        Console.WriteLine("choose 1 to create, 2 read,3 readAll, 4 to update, 5 to delete");
        choose=int.Parse(Console.ReadLine());
        switch(choose)
        {
            case 1:
                AddCustomer();
                break;
            case 2:
                Read<Customer>(s_dal.customer);
                break;
            case 3:
                ReadAll<Customer>(s_dal.customer);
                break;
            case 4:
                UpdateCustomer();
                break;   
            case 5:
                Console.WriteLine("insert id to delete");
                Delete<Customer>(s_dal.customer); 
                break;
        }
    }
    private static void SaleMenu()
    {
        int choose;
        Console.WriteLine("choose 1 to create, 2 read,3 readAll, 4 to update, 5 to delete");
        choose = int.Parse(Console.ReadLine());
        switch (choose)
        {
            case 1:
                AddSale();
                break;
            case 2:
                Read<Sale>(s_dal.sale);
                break;
            case 3:
                ReadAll<Sale>(s_dal.sale);
                break;
            case 4:
                UpdateSale();
                break;
            case 5:               
                Delete<Sale>(s_dal.sale);
                break;
        }
    }
    private static Product AskProduct(int code = 0)
    {
        string name;
        Categorys category;
        double price;
        int count;
        Console.WriteLine("Enter the Name of the product");
        name = Console.ReadLine();
        Console.WriteLine("Enter the category: between 0 to 3 ");
        int cat;
        if (!int.TryParse(Console.ReadLine(), out cat)) category = 0;
        else
            category = (Categorys)cat;
        Console.WriteLine("Enter Price");
        if (!double.TryParse(Console.ReadLine(), out price)) price = 10;
        Console.WriteLine("Enter count in stock");
        if (!int.TryParse(Console.ReadLine(), out count)) count = 0;
        return new Product(code, category = (Categorys)cat, name, price, count);
    }

    private static Sale AskSale(int code = 0)
    {
        int id_product, amount_required;
        double final_pric;
        bool if_general_sale;
        DateTime date_start_sale, date_finish_sale;
        Console.WriteLine("Enter the id_product");
        if (!int.TryParse(Console.ReadLine(), out id_product)) id_product = 10;
        Console.WriteLine("Enter the amount_required");
        if (!int.TryParse(Console.ReadLine(), out amount_required)) amount_required = 10;
        Console.WriteLine("Enter the final_pric");
        if (!double.TryParse(Console.ReadLine(), out final_pric)) final_pric = 10;
        Console.WriteLine("Enter the if_general_sale");
        if (!bool.TryParse(Console.ReadLine(), out if_general_sale)) if_general_sale = false;
        Console.WriteLine("Enter the date_start_sale");
        if (!DateTime.TryParse(Console.ReadLine(), out date_start_sale)) date_start_sale = DateTime.Today;
        Console.WriteLine("Enter the date_finish_sale");
        if (!DateTime.TryParse(Console.ReadLine(), out date_finish_sale)) date_finish_sale = DateTime.Today;
        return new Sale(id_product, amount_required, final_pric, if_general_sale, date_start_sale, date_finish_sale);
    }
    private static Customer AskCastomer(int identity = 0)
    {
        int id;
        string name, address, phone;
        Console.WriteLine("Enter the id of the castomer");
        if (!int.TryParse(Console.ReadLine(), out id)) id = 10;
        Console.WriteLine("Enter the Name of the castomer");
        name = Console.ReadLine();
        Console.WriteLine("Enter the address of the castomer");
        address = Console.ReadLine();
        Console.WriteLine("Enter the phone of the castomer");
        phone = Console.ReadLine();
        return new Customer(id, name, address, phone);
    }
    private static void AddProduct()
    {
        s_dal.product.Create(AskProduct());
    }
    private static void AddSale() 
    {
        s_dal.sale.Create(AskSale());
    }
    private static void AddCustomer() 
    {
        s_dal.customer.Create(AskCastomer());
    }
    private static void UpdateProduct() 
    {
        s_dal.product.Update(AskProduct());
    }
    private static void UpdateSale() 
    {
        s_dal.sale.Update(AskSale());
    }
    private static void UpdateCustomer() 
    {
        s_dal.customer.Update(AskCastomer());
    }
    private static void ReadAll<T>(ICurd<T> crud)
    {
        List<T> lc = crud.ReadAll();
        foreach (T c in lc)
        {
            Console.WriteLine(c);
        }
    }
    private static void Read<T>(ICurd<T> crud)
    {
        Console.WriteLine("insert id");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine(crud.Read(id));
    }
    private static void Delete<T>(ICurd<T> crud) 
    {
        Console.WriteLine("insert id");
        int id = int.Parse(Console.ReadLine());
        crud.Delete(id);
    }
    public static void MainMenu()
    {
        bool ifcontinu = true;
        while (ifcontinu) {
            int choose;
            Console.WriteLine("choose 1 customr 2 product 3 sale");
            choose=int.Parse(Console.ReadLine());
            switch (choose) 
            { 
                case 1:
                    CustomerMenu();
                    break;
                case 2:
                    ProductMenu();
                    break;
                case 3: 
                    SaleMenu();
                    break;
            }
            Console.WriteLine("do you want to continu?");
            ifcontinu = bool.Parse(Console.ReadLine());
        }
    }
    private static void Main(string[] args)
    {
        try
        {
            Initialization.Initialize(s_dal);
            MainMenu();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

    }   
}  