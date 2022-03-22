using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class InterofficeTransferItem
    {
        public int TransferItemId { get; set; }
        public int TransferId { get; set; }
        public int ItemPackageId { get; set; }
        public short QtyTransferred { get; set; }
        public string? LotNum { get; set; }
        public DateTime? LotExpirationDate { get; set; }
        public DateTime? DateEntered { get; set; }
    }
}
