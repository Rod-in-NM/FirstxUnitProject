using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmItemPackageProgram
    {
        public int ItemProgramId { get; set; }
        public int ItemPackageId { get; set; }
        public int ProgramId { get; set; }
        public bool? Is340BYn { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public int? EnteredByEmployeeId { get; set; }
        public byte[]? DateTimeStamp { get; set; }

        public virtual Program Program { get; set; } = null!;
    }
}
