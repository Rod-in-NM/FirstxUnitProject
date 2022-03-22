using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class VwAllInventoryInByItemPackageId
    {
        public int ItemPackageId { get; set; }
        public double? InventoryIn { get; set; }
    }
}
