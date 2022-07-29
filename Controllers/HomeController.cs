﻿using IAMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace IAMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TopMenus tm = new TopMenus();
        private readonly SessionHandler sessionHandler = new SessionHandler(); 

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            if(!sessionHandler.IsUserLoggedIn())
                return RedirectToAction("Index","Login");
            if(!sessionHandler.HasPermissionToViewPage("Home"))
                return RedirectToAction("Index", "PageNotFound");
            return View();
        }

        public IActionResult Privacy()
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
