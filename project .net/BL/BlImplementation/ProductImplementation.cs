using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlImplementation;
using BlApi;
using BO;
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
                return _dal.product.Create(product.ToDO());  // ← ToDO
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
                var doProduct = _dal.product.Read(d => filter(d.ToBO()));  // ← ToBO בתוך הפילטר
                return doProduct?.ToBO();                                   // ← ToBO על התוצאה
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
                var boQuery = _dal.product.ReadAll(null)
                                  .Select(d => d.ToBO());  // ← ToBO

                if (filter != null)
                    return boQuery.Where(filter)
                                  .Cast<BO.Product?>()
                                  .ToList();

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
                _dal.product.Update(product.ToDO());  // ← ToDO
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

        }
    }
}
