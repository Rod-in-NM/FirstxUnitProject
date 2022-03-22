using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmPreference
    {
        public string? DefaultFiscalYearAbbrev { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? CityLine { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? FedId { get; set; }
        public float? TaxRate { get; set; }
        public byte[]? UpsizeTs { get; set; }
    }
}
