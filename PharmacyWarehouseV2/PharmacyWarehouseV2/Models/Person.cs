using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
