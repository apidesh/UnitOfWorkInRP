using System.Collections;

namespace MyData.Db.Repository
{
    public interface IAccountManagementRepo
    {
        IEnumerable GetUserAccounts();

        void Save();
    }
}