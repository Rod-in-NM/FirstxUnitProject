using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class VwPharmItem
    {
        public int ItemOriginalId { get; set; }
        public string ItemDescr { get; set; } = null!;
        public int? SupplierId { get; set; }
        public int? ItemClassId { get; set; }
        public string? DrugOrSupply { get; set; }
        public string? DrugStrength { get; set; }
        public string? DrugDosageForm { get; set; }
        public bool? CertificationReqYn { get; set; }
        public string? PrescriptionTypeCode { get; set; }
        public bool? RequireLotNumYn { get; set; }
        public bool? RefrigerateYn { get; set; }
        public string? UnitOfMeasure { get; set; }
        public string? ContainerType { get; set; }
        public string? ItemGroup { get; set; }
        public int ItemPackageId { get; set; }
        public int? QtyPerPackage { get; set; }
        public bool? LabelledYn { get; set; }
        public decimal? CurrCost { get; set; }
        public decimal? RetailPrice { get; set; }
        public double? StockingLevel { get; set; }
        public double? ReorderLevel { get; set; }
        public DateTime? LastInventoryDate { get; set; }
        public bool? ExcludeFromParLvlRptYn { get; set; }
        public bool? OrigPackageFromSupplierYn { get; set; }
        public string? Notes { get; set; }
        public DateTime? DateEntered { get; set; }
        public string? OldItemNum { get; set; }
        public string? Upinum { get; set; }
        public int? DepartmentId { get; set; }
        public int? OldItemId { get; set; }
        public bool? DiscontinuedYn { get; set; }
    }
}
