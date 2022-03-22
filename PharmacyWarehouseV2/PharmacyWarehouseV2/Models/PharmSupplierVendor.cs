using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmSupplierVendor
    {
        public PharmSupplierVendor()
        {
            PharmItemsOriginals = new HashSet<PharmItemsOriginal>();
        }

        public int SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string? MainSupplies { get; set; }
        public bool WarehouseSupplierYn { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? CityLine { get; set; }
        public string? SupplierCity { get; set; }
        public string? SupplierState { get; set; }
        public string? SupplierZip { get; set; }
        public string? Contact1Name { get; set; }
        public string? Phone1 { get; set; }
        public string? Contact2Name { get; set; }
        public string? Phone2 { get; set; }
        public string? Fax { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public int? EnteredByEmployeeId { get; set; }
        public string? NdclabelerCode { get; set; }

        public virtual ICollection<PharmItemsOriginal> PharmItemsOriginals { get; set; }
    }
}
