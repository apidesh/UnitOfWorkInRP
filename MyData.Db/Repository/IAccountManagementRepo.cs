using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyData.Db.Repository
{
    public interface IAccountManagementRepo
    {
        IEnumerable GetUserAccounts();

        void Save();
    }
}