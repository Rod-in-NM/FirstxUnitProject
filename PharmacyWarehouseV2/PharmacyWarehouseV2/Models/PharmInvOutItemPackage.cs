using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmInvOutItemPackage
    {
        public PharmInvOutItemPackage()
        {
            PharmInvOutItemPackageReceipts = new HashSet<PharmInvOutItemPackageReceipt>();
        }

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

        public virtual PharmInventoryOut InventoryOut { get; set; } = null!;
        public virtual PharmItemPackage ItemPackage { get; set; } = null!;
        public virtual ICollection<PharmInvOutItemPackageReceipt> PharmInvOutItemPackageReceipts { get; set; }
    }
}
