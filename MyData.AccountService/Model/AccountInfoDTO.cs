using System;

namespace MyData.AccountService.Model
{
    public class AccountInfoDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid StaffInfoID { get; set; }
        public Guid AccountTypeID { get; set; }
        public string EmployeeID { get; set; }
        public string DivisionName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AccountTypeCode { get; set; }
    }
}