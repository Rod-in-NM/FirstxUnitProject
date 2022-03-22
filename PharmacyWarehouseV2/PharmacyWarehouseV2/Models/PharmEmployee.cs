using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmEmployee : IPharmEmployee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? PhoneHome { get; set; }
        public bool? ActiveYn { get; set; }
        public string EmployeeFirstName { get; set; } = null!;
        public string EmployeeLastName { get; set; } = null!;
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
