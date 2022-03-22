using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmShelfLocation
    {
        public int ShelfLocationId { get; set; }
        public string ShelfLocationCode { get; set; } = null!;
    }
}
