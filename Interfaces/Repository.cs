using System.Collections.Generic;

namespace dio_series.Interfaces
{
    public interface Repository<T>
    {
        List<T> List();
        T ReturnById(int id);
        void Insert(T serie);
        void Delete(int id);
        void Update(int id, T serie);
        int NextId();

    }
}