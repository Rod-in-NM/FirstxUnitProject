using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmLocation
    {
        public PharmLocation()
        {
            PharmItemsReturnedExpiredFromLocs = new HashSet<PharmItemsReturnedExpiredFromLoc>();
            PharmLocation340BRegistrations = new HashSet<PharmLocation340BRegistration>();
            PharmLocationPaprogContracts = new HashSet<PharmLocationPaprogContract>();
        }

        public int LocationId { get; set; }
        public bool? ActiveYn { get; set; }
        public string? LocationCode { get; set; }
        public string? LocationType { get; set; }
        public string? Location { get; set; }
        public string? LocationOldName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? CityLine { get; set; }
        public string? LocCity { get; set; }
        public string? LocState { get; set; }
        public string? LocZip { get; set; }
        public string? PhoneMain { get; set; }
        public string? PhoneAlt { get; set; }
        public string? Fax { get; set; }
        public string? Contact1Name { get; set; }
        public string? Contact2Name { get; set; }
        public DateTime? ClinicLicenseExpDate { get; set; }
        public string? ClinicLicenseNum { get; set; }
        public short? ClinicLicenseClassId { get; set; }
        public string? PaShareVendorId { get; set; }
        public DateTime? LocOpenDate { get; set; }
        public DateTime? LocCloseDate { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public int? EnteredByEmployeeId { get; set; }

        public virtual PharmClinicLicenseClass? ClinicLicenseClass { get; set; }
        public virtual ICollection<PharmItemsReturnedExpiredFromLoc> PharmItemsReturnedExpiredFromLocs { get; set; }
        public virtual ICollection<PharmLocation340BRegistration> PharmLocation340BRegistrations { get; set; }
        public virtual ICollection<PharmLocationPaprogContract> PharmLocationPaprogContracts { get; set; }
    }
}
