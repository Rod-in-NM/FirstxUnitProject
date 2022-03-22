using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmItemClass
    {
        public int ItemClassId { get; set; }
        public string ItemClassName { get; set; } = null!;
        public DateTime? DateEntered { get; set; }
        public string? EnteredBy { get; set; }
        public int? EnteredByEmployeeId { get; set; }
    }
}
