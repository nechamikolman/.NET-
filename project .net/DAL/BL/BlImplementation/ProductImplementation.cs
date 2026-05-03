using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DalApi;

namespace BlImplementation
{
    internal class ProductImplementation : BlApi.Iproduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Product product)
        {
            if (product is null) throw new ArgumentNullException(nameof(product));
            try
            {
                var d = new DO.Product(product.id, product.category, product.name, product.price, product.amount);
                return _dal.product.Create(d);
            }
            catch (Exception ex)
            {
                throw new Exception("DAL error while creating product", ex);
            }
        }

        public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            if (filter is null) throw new ArgumentNullException(nameof(filter));
            try
            {
                // translate BO predicate to DO by projecting DO -> BO inside predicate
                var doProduct = _dal.product.Read(d => filter(new BO.Product(d.id, d.category, d.name, d.price, d.amount)));
                if (doProduct is null) return null;

                return new BO.Product(doProduct.id, doProduct.category, doProduct.name, doProduct.price, doProduct.amount);
            }
            catch (Exception ex)
            {
                throw new Exception("DAL error while reading product", ex);
            }
        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                // get DO list from DAL
                var doList = _dal.product.ReadAll(null);

                // query syntax projection (LINQ query)
                var boQuery = from d in doList
                              select new BO.Product(d.id, d.category, d.name, d.price, d.amount);

                // method-syntax filtering (extension methods + lambda)
                if (filter != null)
                    return boQuery.Where(p => filter(p)).Cast<BO.Product?>().ToList();

                return boQuery.Cast<BO.Product?>().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL error while reading all products", ex);
            }
        }

        public void Update(BO.Product product)
        {
            if (product is null) throw new ArgumentNullException(nameof(product));
            try
            {
                var d = new DO.Product(product.id, product.category, product.name, product.price, product.amount);
                _dal.product.Update(d);
            }
            catch (Exception ex)
            {
                throw new Exception("DAL error while updating product", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.product.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("DAL error while deleting product", ex);
            }
        }

        public void GetAllSale(BO.ProductInOrder proinorder, bool IsPreferred)
        {
            if (proinorder is null) throw new ArgumentNullException(nameof(proinorder));
            try
            {
                // get sales related to the product (method-syntax + lambda)
                var doSales = _dal.sale.ReadAll(s => s.id_product == proinorder.id && (s.if_general_sale || IsPreferred));

                // project DO.Sale -> BO.SaleInProduct using query syntax (LINQ query)
                var salesBo = (from s in doSales
                               select new BO.SaleInProduct(s.id_product, s.amount_required, s.final_price, s.if_general_sale)).ToList();

                // if caller provided a mutable list inside the record, update it (avoid assigning to init-only record properties)
                if (proinorder.sales != null)
                {
                    proinorder.sales.Clear();
                    proinorder.sales.AddRange(salesBo);
                }

                // Note: product total_price and other positional properties are init-only on the record;
                // here we don't reassign the record itself. Caller can construct a new ProductInOrder if needed.
            }
            catch (Exception ex)
            {
                throw new Exception("DAL error while getting product sales", ex);
            }
        }
    }
}
