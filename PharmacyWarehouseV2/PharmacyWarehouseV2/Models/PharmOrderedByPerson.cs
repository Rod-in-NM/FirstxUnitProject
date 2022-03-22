using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmOrderedByPerson
    {
        public int OrderedById { get; set; }
        public string? PhoneHome { get; set; }
        public bool ActiveYn { get; set; }
        public string? OrderedByFirstName { get; set; }
        public string? OrderedByLastName { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? EnteredByEmployeeId { get; set; }
        public DateTime? DateModified { get; set; }
        public string? OrdererName { get; set; }
    }
}
