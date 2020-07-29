using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestorantManagement.Helper;
using RestorantManagement.Models;
using RestorantManagement.Services.Interfaces;
using RestorantManagement.ViewModels;

namespace RestorantManagement.Controllers
{
    public class TableController : Controller
    {
        private readonly ITableService tableService;

        public TableController(ITableService tableService)
        {
            this.tableService = tableService;
        }
        public IActionResult Overview()
        {
            List<Table> tablesDB = tableService.GetAll();
            var tables = tablesDB.Select(x => x.ToTableOverview()).ToList();
            return View(tables);
        }

        public IActionResult TakeTable(int tableId)
        {
            tableService.TakeTable(tableId);
            return RedirectToAction(nameof(Overview));
        }

        public IActionResult Details(int tableId) 
        {
            var table = tableService.GetById(tableId).ToTableDetails();
            return View(table);
        }

        public IActionResult CloseTable(int tableId)
        {
            tableService.Close(tableId);
            return RedirectToAction(nameof(Overview));
        }



    }
}
