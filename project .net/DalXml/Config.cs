using System.Xml.Linq;

namespace Dal;

internal static class Config
{
    private static readonly string filePath = Path.Combine("..", "xml", "data-config.xml");
    public static int ProductId
    {
        get
        {
            XElement file = XElement.Load(filePath);
            XElement curProID = file.Element("ProductNum")
                ?? throw new Exception("ProductNum element not found in data-config.xml");
            int num = int.Parse(curProID.Value);
            curProID.SetValue(num + 1);
            file.Save(filePath);
            return num;
        }
    }
    public static int SaleId
    {
        get
        {
            XElement file = XElement.Load(filePath);
            XElement curSaleId = file.Element("SaleNum")
                ?? throw new Exception("SaleNum element not found in data-config.xml");
            int num = int.Parse(curSaleId.Value);
            curSaleId.SetValue(num + 1);
            file.Save(filePath);
            return num;
        }
    }
}