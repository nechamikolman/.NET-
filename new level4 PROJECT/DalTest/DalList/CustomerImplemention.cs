using DO;
using DalApi;


namespace Dal;

public class CustomerImplemention: Icustomer
{
    
    public int Create(Customer customer)
    {
        if (!DataSource.Scustomers.Exists((p) => p == customer))
        {
            DataSource.Scustomers.Add(customer);
            return customer.id;
        }
        throw new DalIdExsist("customers is already");
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        if (filter == null)
            throw new ArgumentNullException(nameof(filter));

        Customer? customer = DataSource.Scustomers
            .FirstOrDefault(filter);

        if (customer == null)
            throw new DalIdNotExsist("customer is not exist");

        return customer;
    }
    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        if (filter == null)
            return DataSource.Scustomers!.Cast<Customer?>().ToList();

        return DataSource.Scustomers!
               .Where(filter)
               .Cast<Customer?>()
               .ToList();
    }
    public void Update(Customer customer)
    {
        if (DataSource.Scustomers.Exists((cus) => cus.id == customer.id))
        {
            Delete(DataSource.Scustomers.Find((cus) => cus.id == customer.id).id);
            DataSource.Scustomers.Add(customer);
        }
        
    }
    public void Delete(int id) 
    {
        if (DataSource.Scustomers.Exists((cus) => cus.id == id))
            DataSource.Scustomers.Remove((DataSource.Scustomers.Find((cus) => cus.id == id)));
        throw new DalIdNotExsist("customer id is not exsist");

    }
}
