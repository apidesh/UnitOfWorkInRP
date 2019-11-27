using MyData.AccountService.BL.Interfaces;
using MyData.Db.Contexts;
using MyData.Db.Models;
using MyData.Db.Repository;

namespace MyData.AccountService.BL
{
    public class AccountManagement : IAccountManagement
    {
        private readonly MyDataDbContext dbContext;
        private BaseRepository<UserAccount> useraccounts;
        private BaseRepository<StaffInfo> staffinfos;
        private BaseRepository<AccountType> accounttypes;

        public AccountManagement(MyDataDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IRepository<AccountType> AccountTypes
        {
            get
            {
                return accounttypes ?? (accounttypes = new BaseRepository<AccountType>(dbContext));
            }
        }

        public IRepository<UserAccount> UserAccounts
        {
            get
            {
                return useraccounts ?? (useraccounts = new BaseRepository<UserAccount>(dbContext));
            }
        }

        public IRepository<StaffInfo> Staffinfos
        {
            get
            {
                return staffinfos ?? (staffinfos = new BaseRepository<StaffInfo>(dbContext));
            }
        }

        public void Commit()
        {
            dbContext.SaveChanges();
        }
    }
}