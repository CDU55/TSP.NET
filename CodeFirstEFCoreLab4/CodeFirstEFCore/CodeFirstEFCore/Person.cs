using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeFirstEFCore
{
    public class Person
    {
        public int PersonId { get; set; }
        [MaxLength(10)]
        public string FirstName { get; set; }
        [MaxLength(10)]
        public string MiddleName { get; set; }
        [MaxLength(10)]
        public string LastName { get; set; }
        [MaxLength(10)]
        public string TelephoneNumber { get; set; }

    }
}
