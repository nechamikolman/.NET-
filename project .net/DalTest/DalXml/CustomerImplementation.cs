using DalApi;
using DO;
using System.Xml.Serialization;

namespace Dal;

internal class CustomerImplementation : Icustomer
{
    private string filePath = "../xml/customers.xml";

    public int Create(Customer customer)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        List<Customer> customers;

        if (File.Exists(filePath))
        {
            using StreamReader reader = new StreamReader(filePath);
            customers = serializer.Deserialize(reader) as List<Customer> ?? new List<Customer>();
        }
        else
        {
            customers = new List<Customer>();
        }

        customers.Add(customer);

        using StreamWriter writer = new StreamWriter(filePath);
        serializer.Serialize(writer, customers);

        return customer.id;
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        if (!File.Exists(filePath))
            throw new DalFileNotExsist();

        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));

        using StreamReader reader = new StreamReader(filePath);
        List<Customer> customers = serializer.Deserialize(reader) as List<Customer> ?? new List<Customer>();

        return customers.FirstOrDefault(filter);
    }

    public List<Customer> ReadAll(Func<Customer, bool>? filter = null)
    {
        if (!File.Exists(filePath))
            throw new DalFileNotExsist();

        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));

        using StreamReader reader = new StreamReader(filePath);
        List<Customer> customers = serializer.Deserialize(reader) as List<Customer> ?? new List<Customer>();

        return filter == null ? customers : customers.Where(filter).ToList();
    }

    public void Update(Customer customer)
    {
        if (!File.Exists(filePath))
            throw new DalFileNotExsist();

        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));

        using StreamReader reader = new StreamReader(filePath);
        List<Customer> customers = serializer.Deserialize(reader) as List<Customer> ?? new List<Customer>();

        int index = customers.FindIndex(c => c.id == customer.id);

        if (index == -1)
            throw new DalCustomerNotExsist();

        customers[index] = customer;

        using StreamWriter writer = new StreamWriter(filePath);
        serializer.Serialize(writer, customers);
    }

    public void Delete(int id)
    {
        if (!File.Exists(filePath))
            throw new DalFileNotExsist();

        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));

        using StreamReader reader = new StreamReader(filePath);
        List<Customer> customers = serializer.Deserialize(reader) as List<Customer> ?? new List<Customer>();

        var customer = customers.FirstOrDefault(c => c.id == id);

        if (customer == null)
            throw new DalCustomerNotExsist();

        customers.Remove(customer);

        using StreamWriter writer = new StreamWriter(filePath);
        serializer.Serialize(writer, customers);
    }
}