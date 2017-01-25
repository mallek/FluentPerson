using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentPerson
{
    public static class GenericFluentFactory<T> where T : new()
    {
        public static IGenericFactory<T> Init()
        {
            return new GenericFactory<T>();
        }
    }
}
