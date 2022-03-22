using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmClinician
    {
        public PharmClinician()
        {
            PharmClinicianCertifications = new HashSet<PharmClinicianCertification>();
        }

        public int ClinicianId { get; set; }
        public string ClinicianName { get; set; } = null!;
        public bool? ActiveYn { get; set; }
        public bool? ImplanonCertified { get; set; }
        public bool? NexplanonCertified { get; set; }
        public DateTime? NexplanonCertEndDate { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? EnteredByEmployeeId { get; set; }

        public virtual ICollection<PharmClinicianCertification> PharmClinicianCertifications { get; set; }
    }
}
