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
            public static string ToStringProperty<T>(this T obj, int indent = 0, HashSet<object>? visited = null)   
            {
                if (obj == null) return "null";
                visited ??= new HashSet<object>(ReferenceEqualityComparer.Instance);
                if (!visited.Add(obj))
                    return $"[circular reference detected - {obj.GetType().Name}]\n";
               
                var sb = new StringBuilder();
                string pad = new string(' ', indent * 2);
                Type type = obj.GetType();

                sb.AppendLine($"{pad}[{type.Name}]");

                foreach (PropertyInfo prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    object? value = prop.GetValue(obj);
                    if (value is IEnumerable enumerable && value is not string)
                    {
                        sb.AppendLine($"{pad}  {prop.Name}:");
                        int i = 0;
                        foreach (var item in enumerable)
                        {
                            sb.AppendLine($"{pad}    [{i++}]:");
                            sb.Append(item?.ToStringProperty(indent + 3, visited) ?? "null");
                        }
                    }
                    else if (value == null || type.IsPrimitive || value is string
                             || value is DateTime || value is decimal || value is Enum)
                    {
                        sb.AppendLine($"{pad}  {prop.Name}: {value ?? "null"}");
                    }
                    else
                    {
                        sb.AppendLine($"{pad}  {prop.Name}:");
                        sb.Append(value.ToStringProperty(indent + 2, visited));
                    }
                }
                return sb.ToString();
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
