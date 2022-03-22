using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class APharmInvOutItemPackageReceipt
    {
        public int InvOutItemPackageReceiptId { get; set; }
        public int InvOutItemLineId { get; set; }
        public int InventoryInDetailId { get; set; }
        public decimal? ItemCost { get; set; }
        public double? QtyIssuedShippedThisReceipt { get; set; }
        public decimal? TotalCostThisReceipt { get; set; }
        public int? ProgramId { get; set; }
        public bool? IsReceiptItem340BYn { get; set; }
        public int? ClinicianId { get; set; }
        public string? Notes { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public int? InventoryOutId { get; set; }
        public int? ItemPackageId { get; set; }
        public byte[]? DateTimeStamp { get; set; }

        public virtual APharmInvOutItemPackage InvOutItemLine { get; set; } = null!;
        public virtual APharmInvInItemPackage InventoryInDetail { get; set; } = null!;
    }
}
