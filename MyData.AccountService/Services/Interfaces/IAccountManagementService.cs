using MyData.AccountService.Model;

namespace MyData.AccountService.Services.Interfaces
{
    public interface IAccountManagementService
    {
        bool CreateStaffInfo(StaffInfoDTO model);

        bool CreateUserAccount(AccountInfoDTO model);

        bool CreateAccountType(AccountTypeDTO model);
    }
}