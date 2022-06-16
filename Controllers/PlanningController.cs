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
    public class PlanningController : Controller
    {
        private readonly ILogger<PlanningController> _logger;

        public PlanningController(ILogger<PlanningController> logger)
        {
            _logger = logger;
        }

        public IActionResult audit_criteria()
        {
            return View();
        }
        public IActionResult audit_period()
        {
            return View();
        }
        public IActionResult holiday_calendar()
        {
            return View();
        }
        public IActionResult plan_approvals()
        {
            return View();
        }
        public IActionResult post_changes_approved_plan()
        {
            return View();
        }
        public IActionResult post_changes_team_members()
        {
            return View();
        }
        public IActionResult special_assignment()
        {
            return View();
        }
        public IActionResult submission_for_approval()
        {
            return View();
        }
        public IActionResult submission_for_review()
        {
            return View();
        }
        public IActionResult team_members()
        {
            return View();
        }
        public IActionResult tentative_audit_plan()
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
