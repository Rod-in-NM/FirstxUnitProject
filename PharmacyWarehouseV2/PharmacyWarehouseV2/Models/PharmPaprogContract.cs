using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmPaprogContract
    {
        public int PaprogContractId { get; set; }
        public int ProgramId { get; set; }
        public string PacontractNum { get; set; } = null!;
        public decimal? PacontractAmt { get; set; }
        public DateTime PacontractBeginDate { get; set; }
        public DateTime PacontractEndDate { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public int? EnteredByEmployeeId { get; set; }

        public virtual Program Program { get; set; } = null!;
    }
}
