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
    public class _LayoutController : Controller
    {
        private readonly ILogger<_LayoutController> _logger;

        public _LayoutController(ILogger<_LayoutController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            DBConnection dBConnection = new DBConnection();
            var topMenus = dBConnection.GetTopMenus();
            List<MenuModel> meunModel = new List<MenuModel>(topMenus);
            string menu = "<ul class=\"navbar - nav mr - auto mt - 2 mt - lg - 0\">";
            foreach (var item in meunModel)
            {
                
                menu += "<li class=\"nav-item active dropdown\"><a class=\"nav - link dropdown - toggle\" href='#' id=\"navRisk\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">"+item.Menu_Name+" </ a ></ li > ";
            }
            menu += "</ul>";
            return Content(menu);
        }
        [HttpPost]
       public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
