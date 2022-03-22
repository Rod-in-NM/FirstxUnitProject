using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class VwItemQtysOnHandAllItemsSqlview
    {
        public int ItemPackageId { get; set; }
        public double? InventoryIn { get; set; }
        public double? PharmacyOut { get; set; }
        public double? QtyOnHand { get; set; }
    }
}
