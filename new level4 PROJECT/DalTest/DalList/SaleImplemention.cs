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
    public Sale? Read(int id)
    {
        if (DataSource.Ssale.Exists((sal) => sal.id_product == id))
            return (DataSource.Ssale.Find((sal) => sal.id_product == id));
        throw new DalIdNotExsist("sale is not exsist");

    }
    public List<Sale> ReadAll()
    {
        List<Sale> sale = new List<Sale>();
        sale = DataSource.Ssale;
        return sale;
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
