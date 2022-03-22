using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmInventoryAction
    {
        public PharmInventoryAction()
        {
            PharmInventoryIns = new HashSet<PharmInventoryIn>();
            PharmInventoryOuts = new HashSet<PharmInventoryOut>();
        }

        public short InventoryActionId { get; set; }
        public string? InventoryAction { get; set; }
        public string? WhereFromOrTo { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? EnteredByEmployeeId { get; set; }

        public virtual ICollection<PharmInventoryIn> PharmInventoryIns { get; set; }
        public virtual ICollection<PharmInventoryOut> PharmInventoryOuts { get; set; }
    }
}
