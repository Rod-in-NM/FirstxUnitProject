using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class ZzTempForInvOutItemPackagesBackordered
    {
        public int? ItemId { get; set; }
        public int? InventoryOutId { get; set; }
        public int? NewItemPackageId { get; set; }
        public string? OlditemNum { get; set; }
    }
}
