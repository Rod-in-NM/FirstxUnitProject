using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmItemsReturnedExpiredFromLoc
    {
        public int ItemReturnedId { get; set; }
        public int? ItemPackageId { get; set; }
        public int? LocationId { get; set; }
        public DateTime? DateReceivedFromLoc { get; set; }
        public decimal QtyReturnedExpired { get; set; }
        public decimal? CurrItemCost { get; set; }
        public string ReturnType { get; set; } = null!;
        public string? ItemDescr { get; set; }
        public int? InventoryInDetailId { get; set; }
        public DateTime? DateSentForProcessing { get; set; }
        public DateTime? DateProcessingComplete { get; set; }
        public string? Comments { get; set; }
        public DateTime? DateEntered { get; set; }

        public virtual PharmItemPackage? ItemPackage { get; set; }
        public virtual PharmLocation? Location { get; set; }
    }
}
