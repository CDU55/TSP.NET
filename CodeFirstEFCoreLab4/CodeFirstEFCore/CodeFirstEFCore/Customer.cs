using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstEFCore
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public List<Order> Orders { get; set; }
        public Customer()
        {
            this.Orders = new List<Order>();
        }
    }
}
