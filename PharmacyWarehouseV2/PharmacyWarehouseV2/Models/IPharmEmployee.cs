
namespace PharmacyWarehouseV2.Models
{
    public interface IPharmEmployee
    {
        bool? ActiveYn { get; set; }
        DateTime? DateEntered { get; set; }
        DateTime? DateModified { get; set; }
        string EmployeeFirstName { get; set; }
        int EmployeeId { get; set; }
        string EmployeeLastName { get; set; }
        string? EmployeeName { get; set; }
        string? PhoneHome { get; set; }
    }
}