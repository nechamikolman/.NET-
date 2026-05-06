using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DO;
using BO;

namespace BO
{
    internal static class Tools
    {
        public static string ToStringProperty<T>(this T obj)
        {
            string str = "";

            foreach (PropertyInfo item in obj.GetType().GetProperties())
            {
                if (item.PropertyType.IsPrimitive
                    || item.PropertyType == typeof(DateTime)
                    || item.PropertyType == typeof(string))
                {
                    str += item.Name + ": " + item.GetValue(obj) + ",";
                }
                else
                {
                    str += item.Name + ": ";
                    str += item.GetValue(obj).ToStringProperty();
                }
            }

            return str;
        }
        public static BO.Customer ToBO(this DO.Customer doCustomer)
        {
            return new BO.Customer
            (
                id: doCustomer.id,
                name: doCustomer.name,
                address: doCustomer.address,
                phone: doCustomer.phone
            );
        }
        public static DO.Customer ToDO(this BO.Customer boCustomer)
        {
            return new DO.Customer
            (
                id: boCustomer.id,
                name: boCustomer.name,
                address: boCustomer.address,
                phone: boCustomer.phone
            );
        }
        public static BO.Product ToBO(this DO.Product doProduct)
        {
            return new BO.Product
            (
                id: doProduct.id,
                category: (BO.Categorys)doProduct.category,
                name: doProduct.name,
                price: doProduct.price,
                amount: doProduct.amount
            );
        }
        public static DO.Product ToDO(this BO.Product boProduct)
        {
            return new DO.Product
            (
                id: boProduct.id,
                category: (DO.Categorys)boProduct.category,
                name: boProduct.name,
                price: boProduct.price,
                amount: boProduct.amount
            );
        }
        public static BO.Sale ToBO(this DO.Sale doSale)
        {
            return new BO.Sale
            (
                id_product: doSale.id_product,
                amount_required: doSale.amount_required,
                final_price: doSale.final_price,
                if_general_sale: doSale.if_general_sale,
                date_start_sale: doSale.date_start_sale,
                date_finish_sale: doSale.date_finish_sale
            );
        }
        public static DO.Sale ToDO(this BO.Sale boSale)
        {
            return new DO.Sale
            (
                id_product: boSale.id_product,
                amount_required: boSale.amount_required,
                final_price: boSale.final_price,
                if_general_sale: boSale.if_general_sale,
                date_start_sale: boSale.date_start_sale,
                date_finish_sale: boSale.date_finish_sale
            );
        }
    }
}
