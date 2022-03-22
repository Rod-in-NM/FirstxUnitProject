using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmLocationPaprogContract
    {
        public int LocationContractId { get; set; }
        public int LocationId { get; set; }
        public int PaprogContractId { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public int? EnteredByEmployeeId { get; set; }
        public byte[]? DateTimeStamp { get; set; }

        public virtual PharmLocation Location { get; set; } = null!;
    }
}
