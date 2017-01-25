using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentPerson
{
    public class Person : IPerson
    {
        public Person()
        {
            this.Addresses = new List<Address>();
        }

        public List<Address> Addresses { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.MiddleName} {this.LastName}, {this.Addresses.Count} Addresse(s)";
        }
    }
}
