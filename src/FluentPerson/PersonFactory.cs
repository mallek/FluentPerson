using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentPerson
{
    public class PersonFactory : IPersonFactory
    {
        private readonly IPerson _person = null;

        public PersonFactory(IPerson person)
        {
            this._person = person;
        }

        public IPersonFactory AddFirstName(string firstName)
        {
            this._person.FirstName = firstName;
            return this;
        }

        public IPersonFactory AddLastName(string lastName)
        {
            this._person.LastName = lastName;
            return this;
        }

        public IPersonFactory AddMiddleName(string middleName)
        {
            this._person.MiddleName = middleName;
            return this;
        }

        public IPerson Create()
        {
            return this._person;
        }
    }
}
