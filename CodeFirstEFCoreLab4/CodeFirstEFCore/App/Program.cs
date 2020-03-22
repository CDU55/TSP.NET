using System;
using CodeFirstEFCore;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer { Name = "Claudiu", City = "Iasi" };
            Order o = new Order { customer = c, TotalValue = 200, Date = DateTime.Now };
            CustomerOrderContext context = new CustomerOrderContext();
            context.Customers.Add(c);
            context.Orders.Add(o);
            context.SaveChanges();
        }
    }
}
