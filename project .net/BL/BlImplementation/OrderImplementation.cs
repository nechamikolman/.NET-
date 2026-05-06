using System;
using System.Linq;
using System.Collections.Generic;
using BO;
using DalApi;
using DO;
using BlApi;

namespace BlImplementation
{
    internal class OrderImplementation : Iorder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        SaleInProduct Iorder.AddProductToOrder(Order order, int idPro, int amount)
        {
            if (order is null) throw new ArgumentNullException(nameof(order));
            if (amount <= 0) throw new BO.BlInvalidInputException("amount must be positive");
            try
            {
                // read product from DAL
                var doProduct = _dal.product.Read(p => p.id == idPro)
                    ?? throw new BO.BlProductNotExsistException($"product id {idPro} not found");

                // create ProductInOrder (ensure sales list is mutable)
                var salesList = new List<SaleInProduct>();
                var pio = new ProductInOrder(idPro, doProduct.name, doProduct.price, amount, salesList, 0);

                // find applicable sales and calculate price for this product
                ((Iorder)this).SearchSaleForProduct(pio, order.IsPreferredClient);
                ((Iorder)this).CalcTotalPriceForProduct(pio);

                // add to order
                order.Products ??= new List<ProductInOrder>();
                order.Products.Add(pio);

                // return the sale actually applied (best price) or a default "no-sale" entry with base price
                var applied = pio.sales?.OrderBy(s => s.price).FirstOrDefault();
                if (applied is null)
                    return new SaleInProduct(0, 0, pio.basic_price, true);

                return applied;
            }
            catch (BO.BlProductNotExsistException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new BO.BlOperationException("error while adding product to order", ex);
            }
        }

        void Iorder.CalcTotalPrice(Order order)
        {
            if (order is null) throw new ArgumentNullException(nameof(order));

            try
            {
                double total = 0;
                if (order.Products != null)
                {
                    foreach (var p in order.Products)
                    {
                        ((Iorder)this).CalcTotalPriceForProduct(p);
                        total += p.total_price;
                    }
                }
                order.TotalPrice = total;
            }
            catch (Exception ex)
            {
                throw new BO.BlOperationException("error while calculating total price for order", ex);
            }
        }

        void Iorder.CalcTotalPriceForProduct(ProductInOrder productInOrder)
        {
            if (productInOrder is null) throw new ArgumentNullException(nameof(productInOrder));

            try
            {
                double unitPrice = productInOrder.basic_price;

                if (productInOrder.sales != null && productInOrder.sales.Any())
                {
                    // choose the best (lowest) price available
                    var best = productInOrder.sales.OrderBy(s => s.price).First();
                    unitPrice = best.price;
                }

                productInOrder.total_price = unitPrice * productInOrder.amount;

                // No 'with' expression: ProductInOrder is a class, not a record/struct.
            }
            catch (Exception ex)
            {
                throw new BO.BlOperationException("error while calculating total price for product", ex);
            }
        }

        void Iorder.DoOrder(Order order)
        {
            if (order is null) throw new ArgumentNullException(nameof(order));
            if (order.Products == null || !order.Products.Any())
                throw new BO.BlInvalidInputException("order contains no products");

            try
            {
                // compute total and ensure prices are set
                ((Iorder)this).CalcTotalPrice(order);

                // for each product, reduce stock in DAL
                foreach (var p in order.Products)
                {
                    var doProduct = _dal.product.Read(d => d.id == p.id)
                        ?? throw new BO.BlProductNotExsistException($"product id {p.id} not found in DAL");

                    if (doProduct.amount < p.amount)
                        throw new BO.BlInvalidInputException($"not enough stock for product id {p.id}");

                    var updated = new DO.Product(doProduct.id, doProduct.category, doProduct.name, doProduct.price, doProduct.amount - p.amount);
                    _dal.product.Update(updated);
                }
            }
            catch (BO.BlProductNotExsistException)
            {
                throw;
            }
            catch (BO.BlInvalidInputException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new BO.BlOperationException("error while finalizing order", ex);
            }
        }

        void Iorder.SearchSaleForProduct(ProductInOrder productInOrder, bool IsPreferred)
        {
            if (productInOrder is null) throw new ArgumentNullException(nameof(productInOrder));
            try
            {
                var today = DateTime.Today;
                // read all sales for this product from DAL
                var doSales = _dal.sale.ReadAll(s => s.id_product == productInOrder.id);

                var matching = new List<SaleInProduct>();

                foreach (var ds in doSales)
                {
                    if (ds is null) continue;
                    if (today < ds.date_start_sale || today > ds.date_finish_sale) continue;              
                    if (!ds.if_general_sale && ds.amount_required > productInOrder.amount) continue;
                    if (!IsPreferred && !ds.if_general_sale) continue;
                    matching.Add(new SaleInProduct(ds.id_product, ds.amount_required, ds.final_price, ds.if_general_sale));
                }
                // ensure the sales list exists and update it
                productInOrder.sales?.Clear();
                if (productInOrder.sales != null)
                    productInOrder.sales.AddRange(matching);
                else
                    productInOrder.sales = matching;
            }
            catch (Exception ex)
            {
                throw new BO.BlOperationException("error while searching sales for product", ex);
            }
        }
    }
}