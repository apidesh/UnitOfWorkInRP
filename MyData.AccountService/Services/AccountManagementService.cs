using System;
using System.Linq;
using MyData.AccountService.BL.Interfaces;
using MyData.AccountService.Model;
using MyData.AccountService.Services.Interfaces;
using MyData.Db.Models;

namespace MyData.AccountService.Services
{
    public class AccountManagementService : IAccountManagementService
    {
        private readonly IAccountManagement accountManagement;

        public AccountManagementService(IAccountManagement accountManagement)
        {
            this.accountManagement = accountManagement;
        }

        public bool CreateUserAccount(AccountInfoDTO model)
        {
            try
            {
                //Get the reference data from existing
                var accountType = accountManagement.AccountTypes.Get(item => item.AccountTypeCode == model.AccountTypeCode)
                                                                    .FirstOrDefault();

                //Staff Info data
                var staffInfoId = Guid.NewGuid();
                var staffInfo = new StaffInfo
                {
                    ID = staffInfoId,
                    DivisionName = model.DivisionName,
                    Email = model.Email,
                    EmployeeID = model.EmployeeID,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    ModifyBy = "System",
                    ModifyDate = DateTime.Now,
                    IsActive = true
                };

                accountManagement.Staffinfos.Insert(staffInfo);

                //User Account data
                var userAccount = new UserAccount
                {
                    ID = Guid.NewGuid(),
                    AccountTypeFK = accountType.ID,
                    StaffInfoFK = staffInfoId,
                    Username = model.UserName,
                    Password = model.Password,
                    IsActive = true,
                    ModifyBy = "System",
                    ModifyDate = DateTime.Now
                };

                accountManagement.UserAccounts.Insert(userAccount);

                //Commit all data into database at same transaction
                accountManagement.Commit();

                return true;
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                // Log the error
                return false;
            }
        }

        public bool CreateAccountType(AccountTypeDTO model)
        {
            try
            {
                var accountType = new AccountType
                {
                    ID = Guid.NewGuid(),
                    AccountTypeCode = model.TypeCode,
                    AccountTypeName = model.TypeName,
                    IsActive = model.IsActive,
                    ModifyBy = "System",
                    ModifyDate = DateTime.Now
                };

                accountManagement.AccountTypes.Insert(accountType);

                //Commit all data into database at same transaction
                accountManagement.Commit();

                return true;
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                // Log the error
                return false;
            }
        }

        public bool CreateStaffInfo(StaffInfoDTO model)
        {
            try
            {
                var staffInfo = new StaffInfo
                {
                    ID = Guid.NewGuid(),
                    EmployeeID = model.EmployeeID,
                    DivisionName = model.DivisionName,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    IsActive = true,
                    ModifyBy = "System",
                    ModifyDate = DateTime.Now
                };

                accountManagement.Staffinfos.Insert(staffInfo);

                //Commit all data into database at same transaction
                accountManagement.Commit();

                return true;
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                // Log the error
                return false;
            }
        }
    }
}