using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyData.AccountService.Model
{
    public class StaffInfoDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string EmployeeID { get; set; }

        public string DivisionName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string AccountTypeCode { get; set; }
    }
}