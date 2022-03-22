using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmInventoryIn
    {
        public PharmInventoryIn()
        {
            PharmInvInItemPackages = new HashSet<PharmInvInItemPackage>();
        }

        public int InventoryInId { get; set; }
        public string? StateFiscalYearAbbrev { get; set; }
        public string? ShipmentInPonum { get; set; }
        public short InventoryActionId { get; set; }
        public int? ProgramId { get; set; }
        public int? SupplierId { get; set; }
        public string? SupplierOrderNum { get; set; }
        public string? SupplierInvoiceNum { get; set; }
        public int? ReturnedFromLocationId { get; set; }
        public DateTime DateReceived { get; set; }
        public int? OrderedByEmployeeId { get; set; }
        public int? ReceivedByEmployeeId { get; set; }
        public bool PostedYn { get; set; }
        public string? ReasonReturned { get; set; }
        public string? Notes { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual PharmInventoryAction InventoryAction { get; set; } = null!;
        public virtual ICollection<PharmInvInItemPackage> PharmInvInItemPackages { get; set; }
    }
}
