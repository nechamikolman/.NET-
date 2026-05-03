using BlApi;

namespace BlApi
{
    public interface IBl
    {
        BlApi.Icustomer customer { get; }
        BlApi.Iproduct product { get; }
        BlApi.Isale sale { get; }
    }
}
