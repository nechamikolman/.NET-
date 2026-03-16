using DO;
using DalApi;

namespace Dal;
public class ProductImplemention:Iproduct
{
    public int Create(Product product)
    {
        int myId = DataSource.Config.ProductCode;
        Product product1 = product with { id = myId };
        DataSource.Sproduct.Add(product1);
        return myId;
    }
    public Product? Read(int id)
    {
        if (DataSource.Sproduct.Exists((pro) => pro.id == id))
            return (DataSource.Sproduct.Find((pro) => pro.id == id));
        throw new DalIdNotExsist("product is not exsist");

    }
    public List<Product> ReadAll()
    {
        List<Product> products = new List<Product>();
        products = DataSource.Sproduct;
        return products;
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
