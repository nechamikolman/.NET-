using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BlApi;
using BO;

namespace BlTest
{
    internal static class Program
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get;

        static void Main()
        {
            Console.WriteLine("BL Test Console");
            while (true)
            {
                Console.WriteLine("\nMain menu:");
                Console.WriteLine("1 - Try init DAL (optional)");
                Console.WriteLine("2 - Customer operations");
                Console.WriteLine("3 - Product operations");
                Console.WriteLine("4 - Sale operations");
                Console.WriteLine("0 - Exit");
                Console.Write("Choice: ");
                switch (Console.ReadLine()?.Trim())
                {
                    case "1": TryInitDal(); break;
                    case "2": CustomerMenu(); break;
                    case "3": ProductMenu(); break;
                    case "4": SaleMenu(); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
        }

        static void TryInitDal()
        {
            try
            {
                var asm = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.GetName().Name == "DalTest");
                if (asm == null)
                {
                    asm = Assembly.LoadFrom("DalTest.dll");
                }
                var type = asm?.GetType("DalTest.Initialization");
                if (type == null)
                    throw new Exception("Type 'DalTest.Initialization' not found in DalTest.dll");
                var method = type.GetMethod("Init", BindingFlags.Public | BindingFlags.Static);
                if (method == null)
                    throw new Exception("Method 'Init' not found in DalTest.Initialization");
                method.Invoke(null, null);
                Console.WriteLine("DAL initialized (DalTest.Initialization.Init invoked).");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"DAL initialization not available: {ex.Message}");
            }
        }

        static void CustomerMenu()
        {
            while (true)
            {
                Console.WriteLine("\nCustomer menu:");
                Console.WriteLine("1 - Create");
                Console.WriteLine("2 - Read by id");
                Console.WriteLine("3 - Read all");
                Console.WriteLine("4 - Update");
                Console.WriteLine("5 - Delete");
                Console.WriteLine("6 - IfCustomerExist");
                Console.WriteLine("0 - Back");
                Console.Write("Choice: ");
                switch (Console.ReadLine()?.Trim())
                {
                    case "1": CreateCustomer(); break;
                    case "2": ReadCustomer(); break;
                    case "3": ReadAllCustomers(); break;
                    case "4": UpdateCustomer(); break;
                    case "5": DeleteCustomer(); break;
                    case "6": CheckCustomerExists(); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
        }

        static void CreateCustomer()
        {
            try
            {
                var c = ReadCustomerInput();
                var id = s_bl.customer.Create(c);
                Console.WriteLine($"Created customer id = {id}");
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static void ReadCustomer()
        {
            try
            {
                int id = ReadInt("customer id");
                var cust = s_bl.customer.Read(c => c.id == id);
                Console.WriteLine(cust is null ? "Not found" : cust.ToString());
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static void ReadAllCustomers()
        {
            try
            {
                var list = s_bl.customer.ReadAll(null);
                foreach (var c in list) Console.WriteLine(c?.ToString() ?? "(null)");
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static void UpdateCustomer()
        {
            try
            {
                var c = ReadCustomerInput();
                s_bl.customer.Update(c);
                Console.WriteLine("Updated.");
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static void DeleteCustomer()
        {
            try
            {
                int id = ReadInt("customer id");
                s_bl.customer.Delete(id);
                Console.WriteLine("Deleted.");
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static void CheckCustomerExists()
        {
            try
            {
                var c = ReadCustomerInput();
                bool exists = s_bl.customer.IfCustomerExist(c);
                Console.WriteLine($"Exists: {exists}");
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static BO.Customer ReadCustomerInput()
        {
            int id = ReadInt("id");
            Console.Write("name: "); string name = Console.ReadLine() ?? "";
            Console.Write("address: "); string address = Console.ReadLine() ?? "";
            Console.Write("phone: "); string phone = Console.ReadLine() ?? "";
            return new BO.Customer(id, name, address, phone);
        }

        static void ProductMenu()
        {
            while (true)
            {
                Console.WriteLine("\nProduct menu:");
                Console.WriteLine("1 - Create");
                Console.WriteLine("2 - Read by id");
                Console.WriteLine("3 - Read all");
                Console.WriteLine("4 - Update");
                Console.WriteLine("5 - Delete");
                Console.WriteLine("6 - GetAllSale (for ProductInOrder)");
                Console.WriteLine("0 - Back");
                Console.Write("Choice: ");
                switch (Console.ReadLine()?.Trim())
                {
                    case "1": CreateProduct(); break;
                    case "2": ReadProduct(); break;
                    case "3": ReadAllProducts(); break;
                    case "4": UpdateProduct(); break;
                    case "5": DeleteProduct(); break;
                    case "6": GetAllSaleForProduct(); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
        }

        static void CreateProduct()
        {
            try
            {
                var p = ReadProductInput();
                var id = s_bl.product.Create(p);
                Console.WriteLine($"Created product id = {id}");
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static void ReadProduct()
        {
            try
            {
                int id = ReadInt("product id");
                var prod = s_bl.product.Read(p => p.id == id);
                Console.WriteLine(prod is null ? "Not found" : prod.ToString());
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static void ReadAllProducts()
        {
            try
            {
                var list = s_bl.product.ReadAll(null);
                foreach (var p in list) Console.WriteLine(p?.ToString() ?? "(null)");
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static void UpdateProduct()
        {
            try
            {
                var p = ReadProductInput();
                s_bl.product.Update(p);
                Console.WriteLine("Updated.");
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static void DeleteProduct()
        {
            try
            {
                int id = ReadInt("product id");
                s_bl.product.Delete(id);
                Console.WriteLine("Deleted.");
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static void GetAllSaleForProduct()
        {
            try
            {
                int id = ReadInt("product id");
                Console.Write("product name: "); string name = Console.ReadLine() ?? "";
                double basic = ReadDouble("basic price");
                int amount = ReadInt("amount");
                Console.Write("Is preferred for customer? (y/n): ");
                bool isPreferred = (Console.ReadLine() ?? "").Trim().ToLower() == "y";

                // create mutable sales list and pass into ProductInOrder record
                var salesList = new List<BO.SaleInProduct>();
                var pio = new BO.ProductInOrder(id, name, basic, amount, salesList, 0);
                s_bl.product.GetAllSale(pio, isPreferred);

                Console.WriteLine("Sales for product:");
                foreach (var s in salesList) Console.WriteLine(s.ToString());
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static BO.Product ReadProductInput()
        {
            int id = ReadInt("id");
            Console.WriteLine("Categorys enum values: " + string.Join(", ", Enum.GetNames(typeof(BO.Categorys))));
            Console.Write("category (name): ");
            var catStr = Console.ReadLine() ?? "";
            BO.Categorys cat = Enum.TryParse<BO.Categorys>(catStr, true, out var c) ? c : BO.Categorys.Coffee;
            Console.Write("name: "); string name = Console.ReadLine() ?? "";
            double price = ReadDouble("price");
            int amount = ReadInt("amount");
            return new BO.Product(id, cat, name, price, amount);
        }

        static void SaleMenu()
        {
            while (true)
            {
                Console.WriteLine("\nSale menu:");
                Console.WriteLine("1 - Create");
                Console.WriteLine("2 - Read by product id");
                Console.WriteLine("3 - Read all");
                Console.WriteLine("4 - Update");
                Console.WriteLine("5 - Delete");
                Console.WriteLine("0 - Back");
                Console.Write("Choice: ");
                switch (Console.ReadLine()?.Trim())
                {
                    case "1": CreateSale(); break;
                    case "2": ReadSale(); break;
                    case "3": ReadAllSales(); break;
                    case "4": UpdateSale(); break;
                    case "5": DeleteSale(); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
        }

        static void CreateSale()
        {
            try
            {
                var s = ReadSaleInput();
                var id = s_bl.sale.Create(s);
                Console.WriteLine($"Created sale for product id = {id}");
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static void ReadSale()
        {
            try
            {
                int pid = ReadInt("product id");
                var sale = s_bl.sale.Read(s => s.id_product == pid);
                Console.WriteLine(sale is null ? "Not found" : sale.ToString());
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static void ReadAllSales()
        {
            try
            {
                var list = s_bl.sale.ReadAll(null);
                foreach (var s in list) Console.WriteLine(s?.ToString() ?? "(null)");
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static void UpdateSale()
        {
            try
            {
                var s = ReadSaleInput();
                s_bl.sale.Update(s);
                Console.WriteLine("Updated.");
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static void DeleteSale()
        {
            try
            {
                int pid = ReadInt("product id");
                s_bl.sale.Delete(pid);
                Console.WriteLine("Deleted.");
            }
            catch (Exception ex) { PrintException(ex); }
        }

        static BO.Sale ReadSaleInput()
        {
            int pid = ReadInt("product id");
            int amount = ReadInt("amount required");
            double finalPrice = ReadDouble("final price");
            Console.Write("if_general_sale (y/n): ");
            bool gen = (Console.ReadLine() ?? "").Trim().ToLower() == "y";
            Console.Write("date start (yyyy-MM-dd) or empty for today: ");
            DateTime start = ParseDate(Console.ReadLine());
            Console.Write("date finish (yyyy-MM-dd) or empty for today: ");
            DateTime finish = ParseDate(Console.ReadLine());
            return new BO.Sale(pid, amount, finalPrice, gen, start, finish);
        }

        static DateTime ParseDate(string? s)
        {
            if (string.IsNullOrWhiteSpace(s)) return DateTime.Today;
            return DateTime.TryParse(s, out var d) ? d : DateTime.Today;
        }

        static int ReadInt(string name)
        {
            while (true)
            {
                Console.Write($"{name}: ");
                if (int.TryParse(Console.ReadLine(), out var v)) return v;
                Console.WriteLine("Invalid number, try again.");
            }
        }

        static double ReadDouble(string name)
        {
            while (true)
            {
                Console.Write($"{name}: ");
                if (double.TryParse(Console.ReadLine(), out var v)) return v;
                Console.WriteLine("Invalid number, try again.");
            }
        }

        static void PrintException(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            if (ex.InnerException != null) Console.WriteLine($"Inner: {ex.InnerException.Message}");
        }
    }
}