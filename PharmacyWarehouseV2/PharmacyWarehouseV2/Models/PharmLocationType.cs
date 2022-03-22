using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmLocationType
    {
        public int LocationTypeId { get; set; }
        public string LocationType { get; set; } = null!;
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
