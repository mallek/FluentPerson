using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FluentPerson
{
    public interface IGenericFactory<T>
    {
        IGenericFactory<T> AddPropertyValue<TValue>(Expression<Func<T, object>> property, TValue value);

        T Create();
    }
}
