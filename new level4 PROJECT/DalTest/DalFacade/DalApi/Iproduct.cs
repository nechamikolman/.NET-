

namespace DalApi;
using DO;

public interface Iproduct: ICurd<Product>
{
    int Create(Product product);
    Product? Read(Func<Product, bool> filter);
    List<Product?> ReadAll(Func<Product, bool>? filter = null);
    void Update(Product product);
    void Delete(int id);
}
