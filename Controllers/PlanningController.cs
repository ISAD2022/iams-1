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
    public class PlanningController : Controller
    {
        private readonly ILogger<PlanningController> _logger;
        private readonly TopMenus tm = new TopMenus();
        private readonly DBConnection dBConnection = new DBConnection();

        public PlanningController(ILogger<PlanningController> logger)
        {
            _logger = logger;
        }

        public IActionResult audit_criteria()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult audit_period()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            SessionHandler sessionHandler = new SessionHandler();
            bool sessionCheck = true;
            var loggedInUser = sessionHandler.GetSessionUser();
            if (loggedInUser.UserRoleID == 1)
                sessionCheck = false ;
            ViewData["AuditDepartments"] = dBConnection.GetDepartments(354, sessionCheck);
            return View();
        }
        [HttpGet]
        public IActionResult audit_plan(int dept_code, int periodId)
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["AuditTeams"] = dBConnection.GetAuditTeams(dept_code);
            ViewData["AuditPlan"] = dBConnection.GetAuditPlan(periodId);
            return View();
        }
        public IActionResult holiday_calendar()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult plan_approvals()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult post_changes_approved_plan()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult post_changes_team_members()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult special_assignment()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult submission_for_approval()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult submission_for_review()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult staff_position()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            SessionHandler sessionHandler = new SessionHandler();
            bool sessionCheck = true;
            var loggedInUser = sessionHandler.GetSessionUser();
            if (loggedInUser.UserRoleID == 1)
                sessionCheck = false;
            ViewData["AuditDepartments"] = dBConnection.GetDepartments(354, sessionCheck);
            return View();
        }
        public IActionResult team_members()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["AuditDepartments"] = dBConnection.GetDepartments(354);
            return View();
        }
        [HttpPost]
        public List<AuditEmployeeModel> audit_employees(int dept_code=0)
        {
            return dBConnection.GetAuditEmployees(dept_code);
        }
        [HttpPost]
        public List<AuditTeamModel> audit_team(int dept_code)
        {
            return dBConnection.GetAuditTeams(dept_code);
        }
        [HttpPost]
        public List<AuditPeriodModel> audit_periods(int dept_code)
        {
            return dBConnection.GetAuditPeriods(dept_code);
        }
        [HttpPost]
        public List<AuditPeriodModel> add_audit_period(AddAuditPeriodModel auditPeriod)
        {
            List<AuditPeriodModel> periodList = new List<AuditPeriodModel>();
            foreach(var id in auditPeriod.DEPARTMENT_IDS) {
                AuditPeriodModel apm = new AuditPeriodModel();
                apm.AUDIT_CONDUCT_BY_DEPTID = id;
                apm.DESCRIPTION =auditPeriod.DESCRIPTION;
                apm.START_DATE = DateTime.ParseExact(auditPeriod.STARTDATE, "MM/dd/yyyy", null);
                apm.END_DATE = DateTime.ParseExact(auditPeriod.ENDDATE, "MM/dd/yyyy", null);
                periodList.Add(dBConnection.AddAuditPeriod(apm));
            }
            return periodList;
        }
        [HttpPost]
        public AuditPlanModel add_audit_plan(AuditPlanModel plan)
        {
            return dBConnection.AddAuditPlan(plan);
        }
        public IActionResult tentative_audit_plan()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["AuditDepartments"] = dBConnection.GetDepartments(354);
            ViewData["DivisionsList"] = dBConnection.GetDivisions(false);
            ViewData["AuditZonesList"] = dBConnection.GetZones();
            return View();
        }
        [HttpPost]
        public List<BranchModel> zone_branches(int zone_code)
        {
            return dBConnection.GetBranches(zone_code);
        }
        [HttpPost]
        public List<DepartmentModel> div_departments(int div_code)
        {
            return dBConnection.GetDepartments(div_code,false);
        }
        [HttpPost]
        public List<AuditTeamModel> audit_teams(int dept_code)
        {
            return dBConnection.GetAuditTeams(dept_code);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
