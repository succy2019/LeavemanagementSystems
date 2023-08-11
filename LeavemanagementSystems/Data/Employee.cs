using Microsoft.AspNetCore.Identity;

namespace LeavemanagementSystems.Data
{
    public class Employee : IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? TaxId { get; set; }
        public string? DateOfBirth { get; set; }
        public string? DateJoined { get; set; }
    }
}
