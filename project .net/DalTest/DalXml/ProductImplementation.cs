using DalApi;
using DalXml;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dal;

internal class ProductImplementation:Iproduct
{
    string filePath = "../xml/products.xml";
    public int Create(Product pro)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        List<Product> products;

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                products = serializer.Deserialize(reader) as List<Product>;
            }
        }
        else
        {
            products = new List<Product>();
        }
        Product pro2 = pro with { id = Config.ProductId };
        products.Add(pro2);

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, products);
        }

        return pro2.id;
    }
    public Customer? Read(int id)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        List<Customer> customers;


        if (!File.Exists(filePath))
            return null;

        using (StreamReader reader = new StreamReader(filePath))
        {
            customers = serializer.Deserialize(reader) as List<Customer>;
        }

        return customers.FirstOrDefault(c => c.CustomerId == id);
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        List<Customer> customers;




        using (StreamReader reader = new StreamReader(filePath))
        {
            customers = serializer.Deserialize(reader) as List<Customer>;
        }

        return customers.FirstOrDefault(c => filter(c) == true);
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {

        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        List<Customer> customers;


        if (!File.Exists(filePath))
            return null;

        using (StreamReader reader = new StreamReader(filePath))
        {
            customers = serializer.Deserialize(reader) as List<Customer>;
        }
        if (filter != null)
            customers = customers.Where(filter).ToList();
        return customers;



    }
    public List<Customer?> ReadAll()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        List<Customer> customers;


        if (!File.Exists(filePath))
            return null;

        using (StreamReader reader = new StreamReader(filePath))
        {
            customers = serializer.Deserialize(reader) as List<Customer>;
        }

        return customers;

    }

    public void Delete(int cusId)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        List<Customer> customers;

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                customers = serializer.Deserialize(reader) as List<Customer>;
            }
        }
        else
        {
            customers = new List<Customer>();
        }
        Customer cus = customers.FirstOrDefault(c => c.CustomerId == cusId);
        customers.Remove(cus);

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, customers);
        }


    }

    public void Update(Customer cus)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        List<Customer> customers;

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                customers = serializer.Deserialize(reader) as List<Customer>;
            }
        }
        else
        {
            customers = new List<Customer>();
        }
        Customer newcustomer = customers.FirstOrDefault(c => c.CustomerId == cus.CustomerId);

        if (newcustomer != null)
        {
            customers.Remove(newcustomer);
            customers.Add(cus);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, customers);
            }
        }
    }

}
