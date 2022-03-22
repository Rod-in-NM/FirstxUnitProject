using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmInvInItemPackage
    {
        public PharmInvInItemPackage()
        {
            PharmInvOutItemPackageReceipts = new HashSet<PharmInvOutItemPackageReceipt>();
        }

        public int InventoryInDetailId { get; set; }
        public int InventoryInId { get; set; }
        public int ItemPackageId { get; set; }
        public string? LotNum { get; set; }
        public double? ItemCost { get; set; }
        public string? ItemDescr { get; set; }
        public string? ItemNdcnum { get; set; }
        public double? QtyPerPackage { get; set; }
        public double? QtyReceived { get; set; }
        public decimal? TotalCost { get; set; }
        public bool LotExpiredYn { get; set; }
        public DateTime? LotExpirationDate { get; set; }
        public int? ShelfLocationId { get; set; }
        public bool? Is340BYn { get; set; }
        public bool? LabelledYn { get; set; }
        public double? QtyRequestedForIssue { get; set; }
        public string? Notes { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public byte[]? DateTimeStamp { get; set; }

        public virtual PharmInventoryIn InventoryIn { get; set; } = null!;
        public virtual PharmItemPackage ItemPackage { get; set; } = null!;
        public virtual ICollection<PharmInvOutItemPackageReceipt> PharmInvOutItemPackageReceipts { get; set; }
    }
}
