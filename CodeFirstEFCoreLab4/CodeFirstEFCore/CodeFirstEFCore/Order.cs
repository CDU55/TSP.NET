using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstEFCore
{
    public class Order
    {
        public int OrderId { get; set; }
        public decimal TotalValue { get; set; }
        public DateTime Date { get; set; }
        public Customer customer { get; set; }
    }
}
