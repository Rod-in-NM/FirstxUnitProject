using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmLocation340BRegistration
    {
        public int Location340BRegId { get; set; }
        public int LocationId { get; set; }
        public int Loc340BProgramId { get; set; }
        public string Loc340BRegistrationNum { get; set; } = null!;
        public DateTime? Loc340BRegistrationStartDate { get; set; }
        public DateTime? Loc340BRegistrationExpDate { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? EnteredByEmployeeId { get; set; }
        public DateTime? DateModified { get; set; }
        public byte[]? DateTimeStamp { get; set; }

        public virtual PharmLocation Location { get; set; } = null!;
    }
}
