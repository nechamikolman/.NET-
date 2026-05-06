using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BlApi;
public interface Iorder 
{
    BO.SaleInProduct AddProductToOrder(BO.Order order, int idPro, int amount);
    void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder);
    void CalcTotalPrice(BO.Order order);
    void DoOrder(BO.Order order);
    void SearchSaleForProduct(BO.ProductInOrder productInOrder, bool IsPreferred);
}
