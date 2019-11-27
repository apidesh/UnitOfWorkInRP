using MyData.Db.Models;
using MyData.Db.Repository;

namespace MyData.AccountService.BL.Interfaces
{
    public interface IAccountManagement
    {
        IRepository<StaffInfo> Staffinfos { get; }
        IRepository<AccountType> AccountTypes { get; }
        IRepository<UserAccount> UserAccounts { get; }

        void Commit();
    }
}