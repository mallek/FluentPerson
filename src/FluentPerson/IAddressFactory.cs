using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentPerson
{
    public interface IAddressFactory
    {
        IAddressFactory AddAddressLine1(string addressLine1);
        IAddressFactory AddAddressLine2(string addressLine2);
        IAddressFactory AddCity(string city);
        IAddressFactory AddCountry(string country);
        IAddressFactory AddZipCode(string zipCode);
        IAddress Create();
    }
}
