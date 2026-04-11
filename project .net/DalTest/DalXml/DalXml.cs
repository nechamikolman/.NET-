using DalApi;

namespace Dal;

internal sealed class DalXml : IDal
{
    private static readonly DalXml instance=new DalXml();

    public static DalXml Instance
    {
        get { return instance; }
    }
    public Icustomer customer { get; } = new CustomerImplementation();

    public Iproduct product { get; } = new ProductImplementation();

    public Isale sale { get; } = new SaleImplementation();

    private DalXml() { }
}
