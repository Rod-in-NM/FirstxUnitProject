using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class VwItemPackageIds340B
    {
        public int ItemPackageId { get; set; }
        public string ItemDescr { get; set; } = null!;
        public string? OldItemNum { get; set; }
        public int? OldprogramPayingForId { get; set; }
        public bool? Tempis340BYn { get; set; }
    }
}
