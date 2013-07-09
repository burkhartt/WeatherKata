using System.Collections.Generic;

namespace SharedCode
{
    public abstract class ContextStrategy<T>
    {
        public abstract T Execute(IEnumerable<T> list);
    }
}