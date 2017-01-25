using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentPerson
{
    public static class PersonFluentFactory
    {
        public static IPersonFactory Init()
        {
            return new PersonFactory(new Person());
        }
    }
}
