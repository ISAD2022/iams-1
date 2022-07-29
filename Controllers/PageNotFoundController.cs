using IAMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IAMS.Controllers;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace IAMS.Controllers
{
    public class PageNotFoundController : Controller
    {
        private readonly ILogger<PageNotFoundController> _logger;

        public PageNotFoundController(ILogger<PageNotFoundController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();

        }
      
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
