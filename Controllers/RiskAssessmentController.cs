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
    public class RiskAssessmentController : Controller
    {
        private readonly ILogger<RiskAssessmentController> _logger;
        private readonly TopMenus tm = new TopMenus();
        private readonly DBConnection dBConnection = new DBConnection();
        private readonly SessionHandler sessionHandler = new SessionHandler();

        public RiskAssessmentController(ILogger<RiskAssessmentController> logger)
        {
            _logger = logger;
        }

        public IActionResult risk_model()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult risk_assessment_table()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult risk_assessment_branches()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult risk_assessment_ho_units()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult risk_assessment_divisions()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if (!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index", "Login");
            if (!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }
        public IActionResult risk_assessment_functions()
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
