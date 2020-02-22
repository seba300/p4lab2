using p4lab2.NorthwindModel;
using System;
using System.Linq;

namespace p4lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new Context();
            ctx.Database.EnsureCreated();

            ctx.Zajecias.Add(new Zajecia() { Nazwa = "P4",IloscObecnych=15,Sala="B316" });

            ctx.SaveChanges();

            //foreach (var item in ctx.Zajecias)
            //{
            //    Console.WriteLine(item.Nazwa);
            //}

            //ctx.Zajecias

            using var northwindContext = new NorthwindContext();
            var ukClients=northwindContext.Customers.Where(x => x.Country == "UK");

            foreach (var item in ukClients)
            {
                Console.WriteLine(item.CompanyName);
            }
        }
    }
}
