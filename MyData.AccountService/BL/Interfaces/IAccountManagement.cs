using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyData.AccountService.BL.Interfaces
{
    public interface IAccountManagement
    {
        //  IRepository<Customer> Customers { get; }
        // IRepository<Order> Orders { get; }
        void Commit();
    }
}