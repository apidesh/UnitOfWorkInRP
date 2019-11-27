using MyData.AccountService.Model;

namespace MyData.AccountService.Services.Interfaces
{
    public interface IAccountManagementService
    {
        bool CreateAccount(AccountInfoDTO model);

        bool CreateAccountType(AccountTypeDTO model);
    }
}