using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class Program
    {
        public Program()
        {
            PharmItemPackagePrograms = new HashSet<PharmItemPackageProgram>();
            PharmPaprogContracts = new HashSet<PharmPaprogContract>();
        }

        public int ProgramId { get; set; }
        public string ProgramAbbrev { get; set; } = null!;
        public string ProgramName { get; set; } = null!;
        public string? ItemPrefix { get; set; }
        public int? DepartmentId { get; set; }
        public bool? ActiveYn { get; set; }
        public bool? Is340BYn { get; set; }
        public DateTime? DateEntered { get; set; }
        public string? EnteredBy { get; set; }
        public int? EnteredByEmployeeId { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual Department? Department { get; set; }
        public virtual ICollection<PharmItemPackageProgram> PharmItemPackagePrograms { get; set; }
        public virtual ICollection<PharmPaprogContract> PharmPaprogContracts { get; set; }
    }
}
