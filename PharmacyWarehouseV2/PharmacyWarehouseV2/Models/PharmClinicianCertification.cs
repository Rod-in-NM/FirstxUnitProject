using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmClinicianCertification
    {
        public int PharmClinicianCertificationsId { get; set; }
        public int ClinicianId { get; set; }
        public int ItemPackageId { get; set; }
        public bool ActiveYn { get; set; }
        public string? Notes { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? EnteredByEmployeeId { get; set; }
        public int? ItemOriginalId { get; set; }

        public virtual PharmClinician Clinician { get; set; } = null!;
        public virtual PharmItemsOriginal? ItemOriginal { get; set; }
        public virtual PharmItemPackage ItemPackage { get; set; } = null!;
    }
}
