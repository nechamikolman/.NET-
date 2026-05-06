using BlApi;
using BO;
using DalApi;

namespace BlImplementation;

internal class CustomerImplementation : BlApi.Icustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Customer customer)
    {
        if (customer is null) throw new ArgumentNullException(nameof(customer));
        try
        {
            return _dal.customer.Create(customer.ToDO());
        }
        catch (Exception ex)
        {
            throw new BlIdExsistException("error while creating customer", ex);
        }
    }
    public BO.Customer? Read(Func<BO.Customer, bool> filter)
    {
        if (filter is null) throw new ArgumentNullException(nameof(filter));
        try
        {
            var doCustomer = _dal.customer.Read(d => filter(d.ToBO()));  
            return doCustomer?.ToBO();                                    
        }
        catch (Exception ex)
        {
            throw new BlIdNotExsistException("error while reading customer", ex);
        }
    }

    public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
    {
        try
        {
            var boQuery = _dal.customer.ReadAll(null).Select(d => d.ToBO());
            if (filter != null)
                return boQuery.Where(filter)
                              .Cast<BO.Customer?>()
                              .ToList();
            return boQuery.Cast<BO.Customer?>().ToList();
        }
        catch (Exception ex)
        {
            throw new BlCustomersNotExsistException("error while reading all customers", ex);
        }
    }

    public void Update(BO.Customer customer)
    {
        if (customer is null) throw new ArgumentNullException(nameof(customer));
        try
        {
            _dal.customer.Update(customer.ToDO());
        }
        catch (Exception ex)
        {
            throw new Exception("DAL error while updating customer", ex);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.customer.Delete(id);
        }
        catch (Exception ex)
        {
            throw new Exception("DAL error while deleting customer", ex);
        }
    }

    public bool IfCustomerExist(BO.Customer customer)
    {
        if (customer is null) throw new ArgumentNullException(nameof(customer));
        try
        {
            return _dal.customer.ReadAll(null).Any(d => d.id == customer.id);
        }
        catch (Exception ex)
        {
            throw new Exception("DAL error while checking customer existence", ex);
        }
    }
}