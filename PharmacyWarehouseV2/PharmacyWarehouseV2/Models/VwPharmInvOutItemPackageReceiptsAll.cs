using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class VwPharmInvOutItemPackageReceiptsAll
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
        public int InvOutItemPackageReceiptId { get; set; }
        public int InventoryInDetailId { get; set; }
        public decimal? ItemCost { get; set; }
        public double? QtyIssuedShippedThisReceipt { get; set; }
        public decimal? TotalCostThisReceipt { get; set; }
        public int? ProgramId { get; set; }
        public bool? IsReceiptItem340BYn { get; set; }
        public int? ClinicianId { get; set; }
        public string? Notes { get; set; }
        public DateTime? DateEntered { get; set; }
        public string? StateFiscalYearAbbrev { get; set; }
        public short InventoryActionId { get; set; }
        public int? LocationId { get; set; }
        public DateTime? DateOrdered { get; set; }
        public int? OrderedById { get; set; }
        public DateTime? DateFilled { get; set; }
        public int? FilledByEmployeeId { get; set; }
        public DateTime? DateChecked { get; set; }
        public int? CheckedByEmployeeId { get; set; }
        public DateTime? DateIssuedShipped { get; set; }
        public int? IssuedShippedByEmployeeId { get; set; }
        public int? ShipCarrierId { get; set; }
        public bool PostedYn { get; set; }
        public bool IssueShippedAndLockedYn { get; set; }
    }
}
