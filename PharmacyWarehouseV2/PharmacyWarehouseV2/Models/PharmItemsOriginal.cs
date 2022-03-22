using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmItemsOriginal
    {
        public PharmItemsOriginal()
        {
            PharmClinicianCertifications = new HashSet<PharmClinicianCertification>();
            PharmItemPackages = new HashSet<PharmItemPackage>();
        }

        public int ItemOriginalId { get; set; }
        public int? OldItemId { get; set; }
        public string? ItemDescr { get; set; }
        public int? SupplierId { get; set; }
        public int? ItemClassId { get; set; }
        public int? DepartmentId { get; set; }
        public string? Upinum { get; set; }
        public string? ItemGroup { get; set; }
        public string? DrugOrSupply { get; set; }
        public string? DrugStrength { get; set; }
        public string? DrugDosageForm { get; set; }
        public string? ContainerType { get; set; }
        public bool? CertificationReqYn { get; set; }
        public string? PrescriptionTypeCode { get; set; }
        public bool? RequireLotNumYn { get; set; }
        public bool? RefrigerateYn { get; set; }
        public string? UnitOfMeasure { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? EnteredByEmployeeId { get; set; }
        public byte[]? DateTimeStamp { get; set; }

        public virtual PharmSupplierVendor? Supplier { get; set; }
        public virtual ICollection<PharmClinicianCertification> PharmClinicianCertifications { get; set; }
        public virtual ICollection<PharmItemPackage> PharmItemPackages { get; set; }
    }
}
