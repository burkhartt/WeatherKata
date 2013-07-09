using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SharedCode
{
    public class Minimum<T> : ContextStrategy<T>
    {
        private readonly Expression<Func<T, object>> func;

        public Minimum(Expression<Func<T, object>> func)
        {
            this.func = func;
        }

        public override T Execute(IEnumerable<T> list)
        {
            return list.OrderBy(func.Compile()).First();
        }
    }
}