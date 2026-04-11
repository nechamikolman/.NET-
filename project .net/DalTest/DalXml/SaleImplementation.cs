using DalApi;
using DalXml;
using DO;
using System.Xml.Serialization;

namespace Dal;

internal class SaleImplementation : Isale
{
    string filePath = "../xml/sales.xml";
    XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));

    public int Create(Sale sale)
    {
        List<Sale> sales;

        if (File.Exists(filePath))
        {
            using StreamReader reader = new StreamReader(filePath);
            sales = serializer.Deserialize(reader) as List<Sale> ?? new List<Sale>();
        }
        else
        {
            sales = new List<Sale>();
        }

        int newId = Config.SaleId;

        Sale newSale = sale with { id_product = newId }; 

        sales.Add(newSale);

        using StreamWriter writer = new StreamWriter(filePath);
        serializer.Serialize(writer, sales);

        return newId;
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        if (!File.Exists(filePath))
            throw new DalFileNotExsist();

        List<Sale> sales;

        using StreamReader reader = new StreamReader(filePath);
        sales = serializer.Deserialize(reader) as List<Sale> ?? new List<Sale>();

        return sales.FirstOrDefault(filter);
    }

    public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
    {
        if (!File.Exists(filePath))
            throw new DalFileNotExsist();

        List<Sale> sales;

        using StreamReader reader = new StreamReader(filePath);
        sales = serializer.Deserialize(reader) as List<Sale> ?? new List<Sale>();

        return filter == null ? sales : sales.Where(filter).ToList();
    }

    public void Update(Sale sale)
    {
        if (!File.Exists(filePath))
            throw new DalFileNotExsist();

        List<Sale> sales;

        using StreamReader reader = new StreamReader(filePath);
        sales = serializer.Deserialize(reader) as List<Sale> ?? new List<Sale>();

        int index = sales.FindIndex(s => s.id_product == sale.id_product);

        if (index == -1)
            throw new DalSaleNotExsist();

        sales[index] = sale;

        using StreamWriter writer = new StreamWriter(filePath);
        serializer.Serialize(writer, sales);
    }

    public void Delete(int id)
    {
        if (!File.Exists(filePath))
            throw new DalFileNotExsist();

        List<Sale> sales;

        using StreamReader reader = new StreamReader(filePath);
        sales = serializer.Deserialize(reader) as List<Sale> ?? new List<Sale>();

        var sale = sales.FirstOrDefault(s => s.id_product == id);

        if (sale == null)
            throw new DalSaleNotExsist();

        sales.Remove(sale);

        using StreamWriter writer = new StreamWriter(filePath);
        serializer.Serialize(writer, sales);
    }
}