using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal;

internal class ProductImplementation:Iproduct
{
    public int Create(Product product)
    {
        int myId = DataSource.Config.ProductCode;
        Product product1 = product with { id = myId };
        DataSource.Sproduct.Add(product1);
        return myId;
    }
    public Product? Read(Func<Product, bool> filter)
    {
        if (filter == null)
            throw new ArgumentNullException(nameof(filter));

        Product? product = DataSource.Sproduct
            .FirstOrDefault(filter);

        if (product == null)
            throw new DalIdNotExsist("product is not exist");

        return product;
    }
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        if (filter == null)
            return DataSource.Sproduct
                .Select(p => p)
                .Cast<Product?>()
                .ToList();

        return DataSource.Sproduct
            .Where(filter)
            .Cast<Product?>()
            .ToList();
    }
    public void Update(Product product)
    {
        if (DataSource.Sproduct.Exists((pro) => pro.id == product.id))
        {
            Delete(DataSource.Sproduct.Find((cus) => cus.id == product.id).id);
            DataSource.Sproduct.Add(product);
        }

    }
    public void Delete(int id)
    {
        if (DataSource.Sproduct.Exists((pro) => pro.id == id))
            DataSource.Sproduct.Remove((DataSource.Sproduct.Find((pro) => pro.id == id)));
        throw new DalIdNotExsist("product id is not exsist");

    }
}
