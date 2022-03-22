using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class APharmInventoryOut
    {
        public APharmInventoryOut()
        {
            APharmInvOutItemPackages = new HashSet<APharmInvOutItemPackage>();
        }

        public int InventoryOutId { get; set; }
        public string? StateFiscalYearAbbrev { get; set; }
        public short InventoryActionId { get; set; }
        public int? LocationId { get; set; }
        public DateTime? DateOrdered { get; set; }
        public int? OrderedById { get; set; }
        public DateTime? DateFilled { get; set; }
        public int? FilledByEmployeeId { get; set; }
        public DateTime? DateChecked { get; set; }
        public int? CheckedByEmployeeId { get; set; }
        public DateTime? DateIssuedShipped { get; set; }
        public int? IssuedShippedByEmployeeId { get; set; }
        public int? ShipCarrierId { get; set; }
        public bool PostedYn { get; set; }
        public bool? IssueShippedAndLockedYn { get; set; }
        public string? Notes { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string? OrderedByName { get; set; }
        public string? ClinicianName { get; set; }
        public int? ClinicianId { get; set; }

        public virtual ICollection<APharmInvOutItemPackage> APharmInvOutItemPackages { get; set; }
    }
}
