using System.Collections.Generic;

namespace SharedCode
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}