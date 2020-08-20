using System.Collections.Generic;

namespace MerMultimedaPlayer.Utility
{
    public interface ICRUD<T>
        where T : class, new()
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        T Get(int id);
        List<T> MyList();
    }
}
