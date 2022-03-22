using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class InterofficeTransfer
    {
        public short TransferId { get; set; }
        public int FromLocation { get; set; }
        public int ToLocation { get; set; }
        public DateTime TransferDate { get; set; }
        public string? FromNurse { get; set; }
        public string? ToNurse { get; set; }
        public string? Notes { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? EnteredByEmployeeId { get; set; }
        public int? TransferNumber { get; set; }
    }
}
