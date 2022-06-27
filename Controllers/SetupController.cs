using IAMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IAMS.Controllers
{
    public class SetupController : Controller
    {
        private readonly ILogger<SetupController> _logger;
        private readonly TopMenus tm = new TopMenus();
        private readonly DBConnection dBConnection = new DBConnection();

        public SetupController(ILogger<SetupController> logger)
        {
            _logger = logger;
        }

        public IActionResult branches()
        {
            
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["BranchList"] = dBConnection.GetBranches();
            return View();
        }
        public IActionResult divisions()
        {

            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["DivisionList"] = dBConnection.GetDivisions();
            return View();
        }
        public IActionResult departments()
        {

            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["DepartmentList"] = dBConnection.GetDepartments();
            return View();
        }
        public IActionResult audit_zones()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["AuditZoneList"] = dBConnection.GetDepartments();
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
