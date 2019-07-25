﻿using Glass.Mapper.Sc.Web.Mvc;
using Sam.ToolStockSc.Web.Areas.Project.ToolStockSc.Models.ViewModels;

namespace Sam.ToolStockSc.Web.Areas.Project.ToolStockSc.Logic.Interfaces
{
    public interface IAccountService
    {
        LoginViewModel GetLoginModel(IMvcContext mvcContext)

        bool Login(LoginViewModel vm);
        void AddUser(RegisterViewModel vm);

        void AssignUserToRole(string domain, string firstName, string lastName, bool isSuperUser);
    }
}
