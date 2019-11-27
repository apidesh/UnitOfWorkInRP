using Microsoft.AspNetCore.Mvc;
using MyData.AccountService.Model;
using MyData.AccountService.Services.Interfaces;

namespace MyData.AccountService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountManagementService accountManagementService;

        public AccountController(IAccountManagementService accountManagementService)
        {
            this.accountManagementService = accountManagementService;
        }

        [HttpPost]
        [Route("staff/add")]
        public bool AddStaffAccount(AccountInfoDTO model)
        {
            return accountManagementService.CreateAccount(model);
        }

        [HttpPost]
        [Route("type/add")]
        public bool AddAccountType(AccountTypeDTO model)
        {
            return accountManagementService.CreateAccountType(model);
        }
    }
}