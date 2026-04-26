using DalApi;
using DO;
namespace BlApi
{
    public interface IBl
    {
        Icustomer customer { get; }
        Iproduct product { get; }
        Isale sale { get; }
    }
}
