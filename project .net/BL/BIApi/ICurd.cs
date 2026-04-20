using DO;

namespace DalApi
{
    public interface ICurd<T>
    {
        int Create( T item);
        T? Read(Func<T, bool> filter);
        List <T?> ReadAll(Func<T,bool>? filter = null);
        void Update( T item ); 
        void Delete( int id );

        

        
    }
}
