using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstMigrations
{
    class Program
    {
        //EF Migration Links
        //http://weblogs.asp.net/scottgu/code-first-development-with-entity-framework-4
        //http://www.appetere.com/Blogs/SteveM/April-2012/Entity-Framework-Code-First-Migrations
        //http://elegantcode.com/2012/04/12/entity-framework-migrations-tips/
        static void Main(string[] args)
        {
            var context = new MyContext();
            context.Addresses.Add(new Address()
            {
                HouseNumber = 1,
                Street = "My Road",
                City = "My City",
                Postcode = "XXX XXX"
            });

            context.SaveChanges();

            context.Addresses.ToList().ForEach(x => Console.WriteLine("House on Road: " + x.Street));

            Console.ReadKey();
        }
    }
}
