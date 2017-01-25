using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentPerson
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPerson person =
                PersonFluentFactory
                    .Init()
                    .AddFirstName("Travis")
                    .AddLastName("Haley")
                    .Create();

            IPerson person2 =
                GenericFluentFactory<Person>
                    .Init(new Person())
                    .AddPropertyValue(x => x.FirstName, "Travis")
                    .AddPropertyValue(x => x.LastName, "Haley")
                    .Create();


        }
    }
}
