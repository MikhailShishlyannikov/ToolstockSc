﻿using System;
using System.Collections.Generic;
using Sam.ToolStockSc.Web.Areas.Project.ToolStockSc.Models.ScModels;
using Sam.ToolStockSc.Web.Areas.Project.ToolStockSc.Models.ViewModels;

namespace Sam.ToolStockSc.Web.Areas.Project.ToolStockSc.Logic.Interfaces
{
    public interface IToolService
    {
        IEnumerable<ToolScModel> GetAll();

        IEnumerable<ToolScModel> Get(string name);

        ToolScModel Get(Guid Id);

        void Create(ToolViewModel vm);
    }
}