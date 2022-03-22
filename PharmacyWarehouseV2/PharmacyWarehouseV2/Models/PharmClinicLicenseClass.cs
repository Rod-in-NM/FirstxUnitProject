using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmClinicLicenseClass
    {
        public PharmClinicLicenseClass()
        {
            PharmLocations = new HashSet<PharmLocation>();
        }

        public short ClinicLicenseClassId { get; set; }
        public string ClinicLicenseClass { get; set; } = null!;
        public DateTime? DateEntered { get; set; }
        public string? EnteredBy { get; set; }
        public int? EnteredByEmployeeId { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual ICollection<PharmLocation> PharmLocations { get; set; }
    }
}
