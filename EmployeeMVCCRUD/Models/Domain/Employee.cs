namespace EmployeeMVCCRUD.Models.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Salary { get; set; } = string.Empty;
        public string JobRole {get; set;} = string.Empty;
        public DateTime DateOfBirth { get; set; } 
        public DateTime DateEmployed { get; set; }

    }
}
