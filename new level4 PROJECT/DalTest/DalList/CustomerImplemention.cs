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

    public Customer? Read(int id)
    {
        if (DataSource.Scustomers.Exists((cus) => cus.id == id))
           return (DataSource.Scustomers.Find((cus) => cus.id == id));
        throw new DalIdNotExsist("customer is not exsist");

    }
    public List<Customer> ReadAll()
    { 
        List<Customer> customers = new List<Customer>();
        customers=DataSource.Scustomers;
        return customers;
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
