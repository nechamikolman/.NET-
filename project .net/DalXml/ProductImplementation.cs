using DalApi;
using DO;
using System.Xml.Linq;

namespace Dal;

internal class ProductImplementation : Iproduct
{
    private string filePath = "../xml/products.xml";
    public int Create(Product product)
    {
        XElement root;
        if (File.Exists(filePath))
            root = XElement.Load(filePath);
        else
            root = new XElement("Products");
        int newId = Config.ProductId;
        XElement newProduct = new XElement("Product",
            new XElement("Id", newId),
            new XElement("Category", product.category.ToString()),
            new XElement("Name", product.name),
            new XElement("Price", product.price),
            new XElement("Amount", product.amount)
        );
        root.Add(newProduct);
        root.Save(filePath);
        return newId;
    }
    public Product? Read(Func<Product, bool> filter)
    {
        if (!File.Exists(filePath))
            throw new DalFileNotExsist();
        XElement root = XElement.Load(filePath);
        var product = root.Elements("Product")
            .Select(p => new Product(
                (int)p.Element("Id"),
                (Categorys)Enum.Parse(typeof(Categorys), p.Element("Category")!.Value),
                (string)p.Element("Name"),
                (double)p.Element("Price"),
                (int)p.Element("Amount")
            ))
            .FirstOrDefault(filter);
        return product;
    }
    public List<Product> ReadAll(Func<Product, bool>? filter = null)
    {
        if (!File.Exists(filePath))
            throw new DalFileNotExsist();
        XElement root = XElement.Load(filePath);
        var products = root.Elements("Product")
            .Select(p => new Product(
                (int)p.Element("Id"),
                (Categorys)Enum.Parse(typeof(Categorys), p.Element("Category")!.Value),
                (string)p.Element("Name"),
                (double)p.Element("Price"),
                (int)p.Element("Amount")
            ))
            .ToList();
        return filter == null ? products : products.Where(filter).ToList();
    }
    public void Update(Product product)
    {
        if (!File.Exists(filePath))
            throw new DalFileNotExsist();
        XElement root = XElement.Load(filePath);
        var existing = root.Elements("Product")
            .FirstOrDefault(p => (int) p.Element("Id") == product.id);
        if (existing == null)
            throw new DalProductNotExsist();
        existing.Element("Category")!.Value = product.category.ToString();
        existing.Element("Name")!.Value = product.name;
        existing.Element("Price")!.Value = product.price.ToString();
        existing.Element("Amount")!.Value = product.amount.ToString();
        root.Save(filePath);
    }
    public void Delete(int id)
    {
        if (!File.Exists(filePath))
            throw new DalFileNotExsist();
        XElement root = XElement.Load(filePath);
        var product = root.Elements("Product")
            .FirstOrDefault(p => (int)p.Element("Id") == id);
        if (product == null)
            throw new DalProductNotExsist();
        product.Remove();
        root.Save(filePath);
    }
}