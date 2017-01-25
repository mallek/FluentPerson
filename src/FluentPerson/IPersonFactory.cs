using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentPerson
{
    public interface IPersonFactory
    {
        IPersonFactory AddFirstName(string firstName);
        IPersonFactory AddLastName(string lastName);
        IPersonFactory AddMiddleName(string middleName);
        IPerson Create();

    }
}
