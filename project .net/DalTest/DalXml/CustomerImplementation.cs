using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dal;

internal class CustomerImplementation:Icustomer
{
    private string filePath = "../xml/data-config.xml";
    public int Create(Customer customer)
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

        customers.Add(customer);

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, customers);
        }

        return customer.id;
       
    }
    public Customer? Read(Func<Customer, bool> filter)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        List<Customer> customers;

        if (!File.Exists(filePath))
            throw new DalFileNotExsist();

        using (StreamReader reader = new StreamReader(filePath))
        {
            customers = serializer.Deserialize(reader) as List<Customer>;
        }

        return customers?.FirstOrDefault(filter);
    }
    public List<Customer> ReadAll(Func<Customer, bool>? filter = null)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        List<Customer> customers;

        if (!File.Exists(filePath))
            throw new DalFileNotExsist();

        using (StreamReader reader = new StreamReader(filePath))
        {
            customers = serializer.Deserialize(reader) as List<Customer> ?? new List<Customer>();
        }

        return filter == null ? customers:customers.Where(filter).ToList();
    }
    public void Update(Customer customer)
    {
        XmlSerializer serializer= new XmlSerializer(typeof(List<Customer>));
        List<Customer> customers;
        if (!File.Exists(filePath))
        {
            throw new DalFileNotExsist();
        }
        using(StreamReader reader = new StreamReader(filePath))
        {
            customers = serializer.Deserialize(reader) as List<Customer>;
        }
        int index = customers.FindIndex(c => c.id == customer.id);

        if (index == -1)
            throw new DalCustomerNotExsist();

        customers[index] = customer;

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, customers);
        }

    }
    public void Delete(int id)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        List<Customer> customers;

        if (!File.Exists(filePath))
            throw new DalFileNotExsist();

        using (StreamReader reader = new StreamReader(filePath))
        {
            customers = serializer.Deserialize(reader) as List<Customer>
                        ?? new List<Customer>();
        }

        var customerToDelete = customers.FirstOrDefault(c => c.id == id);

        if (customerToDelete == null)
            throw new DalCustomerNotExsist();

        customers.Remove(customerToDelete);

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, customers);
        }
    }
}
