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

        public SetupController(ILogger<SetupController> logger)
        {
            _logger = logger;
        }

        public IActionResult branch_setup()
        {
            TopMenus tm = new TopMenus();
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult audit_period()
        {
            TopMenus tm = new TopMenus();
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult holiday_calendar()
        {
            TopMenus tm = new TopMenus();
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult plan_approvals()
        {
            TopMenus tm = new TopMenus();
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult post_changes_approved_plan()
        {
            TopMenus tm = new TopMenus();
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult post_changes_team_members()
        {
            TopMenus tm = new TopMenus();
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult special_assignment()
        {
            TopMenus tm = new TopMenus();
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult submission_for_approval()
        {
            TopMenus tm = new TopMenus();
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult submission_for_review()
        {
            TopMenus tm = new TopMenus();
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult team_members()
        {
            TopMenus tm = new TopMenus();
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult tentative_audit_plan()
        {
            TopMenus tm = new TopMenus();
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
