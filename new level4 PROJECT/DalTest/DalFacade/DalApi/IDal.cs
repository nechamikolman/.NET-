using DO;
namespace DalApi
{
    public interface IDal
    {
        Icustomer customer { get; }
        Iproduct product { get; }
        Isale sale { get; }

       
    }
}
