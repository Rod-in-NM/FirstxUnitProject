using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmYear
    {
        public string YearAbbrev { get; set; } = null!;
        public string? YearType { get; set; }
        public string? YearText { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? CurrentYn { get; set; }
    }
}
