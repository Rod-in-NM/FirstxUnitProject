using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmItemPackage
    {
        public PharmItemPackage()
        {
            PharmClinicianCertifications = new HashSet<PharmClinicianCertification>();
            PharmInvInItemPackages = new HashSet<PharmInvInItemPackage>();
            PharmInvOutItemPackages = new HashSet<PharmInvOutItemPackage>();
            PharmItemNdcnums = new HashSet<PharmItemNdcnum>();
            PharmItemsReturnedExpiredFromLocs = new HashSet<PharmItemsReturnedExpiredFromLoc>();
        }

        public int ItemPackageId { get; set; }
        public int? ItemOriginalId { get; set; }
        public int? OldItemId { get; set; }
        public string? OldItemNum { get; set; }
        public int? QtyPerPackage { get; set; }
        public bool? LabelledYn { get; set; }
        public decimal? CurrCost { get; set; }
        public decimal? RetailPrice { get; set; }
        public double? StockingLevel { get; set; }
        public double? ReorderLevel { get; set; }
        public string? BinNum { get; set; }
        public DateTime? LastInventoryDate { get; set; }
        public bool? ExcludeFromParLvlRptYn { get; set; }
        public bool? OrigPackageFromSupplierYn { get; set; }
        public string? Notes { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? EnteredByEmployeeId { get; set; }
        public int? OldprogramPayingForId { get; set; }
        public bool? Tempis340BYn { get; set; }
        public bool? DiscontinuedYn { get; set; }
        public byte[]? DateTimeStamp { get; set; }

        public virtual PharmItemsOriginal? ItemOriginal { get; set; }
        public virtual ICollection<PharmClinicianCertification> PharmClinicianCertifications { get; set; }
        public virtual ICollection<PharmInvInItemPackage> PharmInvInItemPackages { get; set; }
        public virtual ICollection<PharmInvOutItemPackage> PharmInvOutItemPackages { get; set; }
        public virtual ICollection<PharmItemNdcnum> PharmItemNdcnums { get; set; }
        public virtual ICollection<PharmItemsReturnedExpiredFromLoc> PharmItemsReturnedExpiredFromLocs { get; set; }
    }
}
