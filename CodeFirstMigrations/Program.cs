using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstMigrations
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MyContext();
            context.Addresses.Add(new Address()
            {
                HouseNumber = 1,
                Street = "My Road",
                City = "My City"
            });

            context.SaveChanges();

            context.Addresses.ToList().ForEach(x => Console.WriteLine("House on Road: " + x.Street));

            Console.ReadKey();
        }
    }
}
