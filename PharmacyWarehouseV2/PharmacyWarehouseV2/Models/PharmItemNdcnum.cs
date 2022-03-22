using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmItemNdcnum
    {
        public int ItemPackageNdcnumId { get; set; }
        public int ItemPackageId { get; set; }
        public string Ndcnum { get; set; } = null!;
        public int? ManufacturerId { get; set; }
        public string? TradeName { get; set; }
        public DateTime? DateEntered { get; set; }

        public virtual PharmItemPackage ItemPackage { get; set; } = null!;
        public virtual PharmManufacturer? Manufacturer { get; set; }
    }
}
