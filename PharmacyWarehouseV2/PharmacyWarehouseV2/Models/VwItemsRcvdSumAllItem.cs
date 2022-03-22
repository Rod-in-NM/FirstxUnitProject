using System;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Models
{
    public partial class VwItemsRcvdSumAllItem
    {
        public int ItemPackageId { get; set; }
        public double? SumOfQtyIssuedShipped { get; set; }
        public double? SumOfQtyToIssue { get; set; }
    }
}
