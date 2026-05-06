using BlApi;
using BO;

namespace BlImplementation
{
    internal class OrderImplementation : Iorder
    {
        SaleInProduct Iorder.AddProductToOrder(Order order, int idPro, int amount)
        {
            throw new NotImplementedException();
        }

        void Iorder.CalcTotalPrice(Order order)
        {
            throw new NotImplementedException();
        }

        void Iorder.CalcTotalPriceForProduct(ProductInOrder productInOrder)
        {
            throw new NotImplementedException();
        }

        void Iorder.DoOrder(Order order)
        {
            throw new NotImplementedException();
        }

        void Iorder.SearchSaleForProduct(ProductInOrder productInOrder, bool IsPreferred)
        {
            throw new NotImplementedException();
        }
    }
}