using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmBackorder
    {
        public int BackorderId { get; set; }
        public int LocationId { get; set; }
        public int OrigInventoryOutId { get; set; }
        public int ItemPackageId { get; set; }
        public int QtyBackordered { get; set; }
        public int? BackorderInventoryOutId { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? EnteredByEmployeeId { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ProgramId { get; set; }
    }
}
