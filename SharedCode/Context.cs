using System.Collections.Generic;

namespace SharedCode
{
    public abstract class Context<T>
    {
        public abstract T Apply(IEnumerable<T> data);
    }
}