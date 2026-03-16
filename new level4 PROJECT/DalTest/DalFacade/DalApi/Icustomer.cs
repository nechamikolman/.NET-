

namespace DalApi;
using DO;
public interface Icustomer:ICurd<Customer>
{
    int Create(Customer customer);
    Customer? Read(int id);
    List<Customer> ReadAll();
    void Update(Customer customer);
    void Delete(int id);


}
