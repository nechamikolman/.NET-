using DO;
using DalApi;

namespace Dal;

public class SaleImplemention:Isale
{
    public int Create(Sale sale)
    {
        int myId = DataSource.Config.SaleCode;
        Sale sale1 = sale with { id_product = myId };
        DataSource.Ssale.Add(sale1);
        return myId;
    }
    public Sale? Read(Func<Sale, bool> filter)
    {
        if (filter == null)
            throw new ArgumentNullException(nameof(filter));

        Sale? sale = DataSource.Ssale
            .FirstOrDefault(filter);

        if (sale == null)
            throw new DalIdNotExsist("customer is not exist");

        return sale;
    }
    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        if (filter == null)
            return DataSource.Ssale
                .Select(s => s)
                .Cast<Sale?>()
                .ToList();

        return DataSource.Ssale
            .Where(filter)
            .Cast<Sale?>()
            .ToList();
    }
    public void Update(Sale sale)
    {
        if (DataSource.Ssale.Exists((sal) => sal.id_product == sale.id_product))
        {
            Delete(DataSource.Ssale.Find((sal) => sal.id_product == sale.id_product).id_product);
            DataSource.Ssale.Add(sale);
        }

    }
    public void Delete(int id_product)
    {
        if (DataSource.Ssale.Exists((sal) => sal.id_product == id_product))
            DataSource.Ssale.Remove((DataSource.Ssale.Find((sal) =>sal.id_product== id_product)));
        throw new DalIdNotExsist("sale id is not exsist");

    }

}
