﻿using IAMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IAMS.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ILogger<ReportsController> _logger;
        private readonly TopMenus tm = new TopMenus();
        private readonly DBConnection dBConnection = new DBConnection();
        private readonly SessionHandler sessionHandler = new SessionHandler();

        public ReportsController(ILogger<ReportsController> logger)
        {
            _logger = logger;
        }

        public IActionResult approved_plan()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            //string p = System.Reflection.MethodBase.GetCurrentMethod().Name;
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult user_activity_graph()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            ViewData["AuditDepartments"] = dBConnection.GetDepartments(354);
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult role_wise_user()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult department_performance()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult significant_finding()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult riskwise_observations()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult aging_observations()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
