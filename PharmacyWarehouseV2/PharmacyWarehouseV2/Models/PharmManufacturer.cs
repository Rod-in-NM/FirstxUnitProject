using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmManufacturer
    {
        public PharmManufacturer()
        {
            PharmItemNdcnums = new HashSet<PharmItemNdcnum>();
        }

        public int ManufacturerId { get; set; }
        public string ManufacturerNdcprefix { get; set; } = null!;
        public string ManufacturerName { get; set; } = null!;
        public int? EnteredByEmployeeId { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string? ParentCompanyName { get; set; }

        public virtual ICollection<PharmItemNdcnum> PharmItemNdcnums { get; set; }
    }
}
