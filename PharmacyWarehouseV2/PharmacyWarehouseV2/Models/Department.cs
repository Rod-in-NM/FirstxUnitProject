using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class Department
    {
        public Department()
        {
            Programs = new HashSet<Program>();
        }

        /// <summary>
        /// Also called Program
        /// </summary>
        public int DepartmentId { get; set; }
        public string DohdepartmentId { get; set; } = null!;
        public string DohdepartmentDescr { get; set; } = null!;
        public string DepartmentAbbrev { get; set; } = null!;
        public DateTime? DateEntered { get; set; }
        public string? EnteredBy { get; set; }
        public bool? ActiveYn { get; set; }
        public DateTime? DateModified { get; set; }
        public int? EnteredByEmployeeId { get; set; }

        public virtual ICollection<Program> Programs { get; set; }
    }
}
