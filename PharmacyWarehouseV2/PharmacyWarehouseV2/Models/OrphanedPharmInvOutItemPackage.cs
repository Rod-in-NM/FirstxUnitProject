using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class OrphanedPharmInvOutItemPackage
    {
        public int InvOutItemLineId { get; set; }
        public int InventoryOutId { get; set; }
        public int ItemPackageId { get; set; }
        public bool? LabelledYn { get; set; }
        public bool? Is340BYn { get; set; }
        public double? QtyPerPackage { get; set; }
        public double? QtyOrdered { get; set; }
        public double? QtyOnHand { get; set; }
        public double? QtyToBackorder { get; set; }
        public double? QtyToIssue { get; set; }
        public double? QtyIssuedShippedThisItem { get; set; }
        public decimal? TotalCostThisItem { get; set; }
        public string? Notes { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public bool? BackorderedYn { get; set; }
        public byte[]? DateTimeStamp { get; set; }
    }
}
