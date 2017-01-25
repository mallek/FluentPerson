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
            //Non Generic Implimentation using static factory to create new person instance
            IPerson person =
                PersonFluentFactory
                    .Init()
                    .AddFirstName("Travis")
                    .AddLastName("Haley")
                    .Create();


            //Generic Implimentation where T is created in the generic factory constructor
            IPerson person2 =
                GenericFluentFactory<Person>
                    .Init()
                    .AddPropertyValue(x => x.FirstName, "Travis")
                    .AddPropertyValue(x => x.LastName, "Haley")
                    .Create();

            person2.Addresses.Add(
                GenericFluentFactory<Address>
                .Init()
                .AddPropertyValue(x => x.AddressLine1, "123 main st")
                .AddPropertyValue(x => x.City, "Centennial")
                .AddPropertyValue(x => x.Country, "USA")
                .AddPropertyValue(x => x.ZipCode, "80121")
                .Create());
                
            

            Console.Out.WriteLine(person);
            Console.Out.WriteLine(person2);

            Console.WriteLine("Press the any key");

            Console.ReadKey();

        }
    }
}
