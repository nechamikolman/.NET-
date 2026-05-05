using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BlApi;
internal interface Iorder : ICurd<BO.Order>
{
    int Create(Order item);
    Order? Read(Func<Order, bool> filter);
    List<Order?> ReadAll(Func<Order, bool>? filter = null);
    void Update(Order item);
    void Delete(int id);
    BO.SaleInProduct AddProductToOrder(BO.Order order, int idPro, int amount);
    void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder);
    void CalcTotalPrice(BO.Order order);
    void DoOrder(BO.Order order);
    void SearchSaleForProduct(BO.ProductInOrder productInOrder, bool IsPreferred);
}
