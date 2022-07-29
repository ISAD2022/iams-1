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
    public class EngagementController : Controller
    {
        private readonly ILogger<EngagementController> _logger;
        private readonly TopMenus tm = new TopMenus();
        private readonly DBConnection dBConnection = new DBConnection();
        private readonly SessionHandler sessionHandler = new SessionHandler();

        public EngagementController(ILogger<EngagementController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }

        public IActionResult task_list()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
			   if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult create_audit_plan()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult engagement_plan()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["AuditDepartments"] = dBConnection.GetDepartments(354);
            ViewData["DivisionsList"] = dBConnection.GetDivisions(false);
            ViewData["AuditZonesList"] = dBConnection.GetZones();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult audit_criteria()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult submission_for_review()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }

        public IActionResult Join()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult acceptance()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult change_request()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult plan_approvals()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult submission_for_approval()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult post_changes_approved_plan()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult post_changes_team_members()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult notifications()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult preparation_ccqs()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult ccqs()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
