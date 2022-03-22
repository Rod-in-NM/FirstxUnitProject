using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class VwInvOutItemPackageReceiptsIssued
    {
        public bool PostedYn { get; set; }
        public int InventoryOutId { get; set; }
        public DateTime? DateIssuedShipped { get; set; }
        public string? LocationCode { get; set; }
        public string? Location { get; set; }
        public string? WhereFromOrTo { get; set; }
        public double? QtyOrdered { get; set; }
        public int InventoryInDetailId { get; set; }
        public double? QtyIssuedShippedThisReceipt { get; set; }
        public decimal? ItemCost { get; set; }
        public decimal? TotalCostThisReceipt { get; set; }
        public bool? IsReceiptItem340BYn { get; set; }
        public string? ClinicianName { get; set; }
        public string ProgramAbbrev { get; set; } = null!;
        public string? Notes { get; set; }
    }
}
