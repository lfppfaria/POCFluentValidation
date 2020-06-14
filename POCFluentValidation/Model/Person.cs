using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCFluentValidation.Model
{
    public class Person
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
