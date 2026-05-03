using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;
using BlApi;

namespace BlImplementation
{
    internal class SaleImplementation : BlApi.Isale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Sale sale)
        {
            if (sale is null) throw new ArgumentNullException(nameof(sale));
            try
            {
                var d = new DO.Sale(sale.id_product, sale.amount_required, sale.final_price, sale.if_general_sale, sale.date_start_sale, sale.date_finish_sale);
                return _dal.sale.Create(d);
            }
            catch (Exception ex)
            {
                throw new Exception("DAL error while creating sale", ex);
            }
        }

        public BO.Sale? Read(Func<BO.Sale, bool> filter)
        {
            if (filter is null) throw new ArgumentNullException(nameof(filter));
            try
            {
                // translate BO predicate to DO predicate by projecting DO -> BO
                var doSale = _dal.sale.Read(d => filter(new BO.Sale(d.id_product, d.amount_required, d.final_price, d.if_general_sale, d.date_start_sale, d.date_finish_sale)));
                if (doSale is null) return null;

                return new BO.Sale(doSale.id_product, doSale.amount_required, doSale.final_price, doSale.if_general_sale, doSale.date_start_sale, doSale.date_finish_sale);
            }
            catch (Exception ex)
            {
                throw new Exception("DAL error while reading sale", ex);
            }
        }

        public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            try
            {
                var doList = _dal.sale.ReadAll(null);

                // projection using method-syntax (Select + lambda)
                var boList = doList.Select(d => new BO.Sale(d.id_product, d.amount_required, d.final_price, d.if_general_sale, d.date_start_sale, d.date_finish_sale));

                // optional filter using query syntax to demonstrate both styles
                if (filter != null)
                {
                    var filtered = from b in boList
                                   where filter(b)
                                   select b;
                    return filtered.Cast<BO.Sale?>().ToList();
                }

                return boList.Cast<BO.Sale?>().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL error while reading all sales", ex);
            }
        }

        public void Update(BO.Sale sale)
        {
            if (sale is null) throw new ArgumentNullException(nameof(sale));
            try
            {
                var d = new DO.Sale(sale.id_product, sale.amount_required, sale.final_price, sale.if_general_sale, sale.date_start_sale, sale.date_finish_sale);
                _dal.sale.Update(d);
            }
            catch (Exception ex)
            {
                throw new Exception("DAL error while updating sale", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.sale.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("DAL error while deleting sale", ex);
            }
        }
    }
}
