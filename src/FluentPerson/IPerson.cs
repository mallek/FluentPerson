using System.Collections.Generic;

namespace FluentPerson
{
    public interface IPerson
    {
        List<Address> Addresses { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
    }
}