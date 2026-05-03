using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DalApi;

namespace BlImplementation
{
    internal class CustomerImplementation : BlApi.Icustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Customer customer)
        {
            if (customer is null) throw new ArgumentNullException(nameof(customer));
            try
            {
                var d = new DO.Customer(customer.id, customer.name, customer.address, customer.phone);
                return _dal.customer.Create(d);
            }
            catch (Exception ex)
            {
                throw new Exception("DAL error while creating customer", ex);
            }
        }

        public BO.Customer? Read(Func<BO.Customer, bool> filter)
        {
            if (filter is null)
                throw new ArgumentNullException(nameof(filter));

            try
            {
                // translate BO predicate to DO by projecting DO -> BO inside predicate
                var doCustomer = _dal.customer.Read(d => filter(new BO.Customer(d.id, d.name, d.address, d.phone)));
                if (doCustomer is null) return null;

                return new BO.Customer(doCustomer.id, doCustomer.name, doCustomer.address, doCustomer.phone);
            }
            catch (Exception ex)
            {
                throw new Exception("DAL error while reading customer", ex);
            }
        }

        public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            try
            {
                // get DO list from DAL
                var doList = _dal.customer.ReadAll(null);

                // use query syntax (linq-to-object) for projection
                var boQuery = from d in doList
                              select new BO.Customer(d.id, d.name, d.address, d.phone);

                // use extension methods (method-syntax) for optional filtering (demonstrates both styles)
                if (filter != null)
                    return boQuery.Where(b => filter(b)).Cast<BO.Customer?>().ToList();

                return boQuery.Cast<BO.Customer?>().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL error while reading all customers", ex);
            }
        }

        public void Update(BO.Customer customer)
        {
            if (customer is null) throw new ArgumentNullException(nameof(customer));
            try
            {
                var d = new DO.Customer(customer.id, customer.name, customer.address, customer.phone);
                _dal.customer.Update(d);
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

        public bool IfCastomerExsist(BO.Customer customer)
        {
            if (customer is null) throw new ArgumentNullException(nameof(customer));
            try
            {
                // use extension LINQ method Any (lambda) to check existence
                return _dal.customer.ReadAll(null).Any(d => d.id == customer.id);
            }
            catch (Exception ex)
            {
                throw new Exception("DAL error while checking customer existence", ex);
            }
        }
    }
}