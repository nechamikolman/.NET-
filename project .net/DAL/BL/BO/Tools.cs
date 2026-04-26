using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
        // DO -> BO
        internal static BO.Order ToBO(this DO.order doOrder)
        {
            return new BO.Order
            {
                IsPreferredClient= doOrder.IsPreferredClient,
                Products= doOrder.Products?.Select(p => new BO.ProductInOrder
                {
                    ProductId = p.ProductId,
                    Quantity = p.Quantity,
                    Price = p.Price
                }).ToList(),
                TotalPrice = doOrder.TotalPrice
            };
        }

        // BO -> DO
        internal static DO.Order ToDO(this BO.Order boOrder)
        {
            return new DO.Order
            {
                Id = boOrder.Id,
                CustomerName = boOrder.CustomerName,
                // ...המשך מיפוי שדות
            };
        }
    }

}
