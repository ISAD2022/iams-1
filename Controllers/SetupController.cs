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
            ViewData["ZoneList"] = dBConnection.GetZones();
            ViewData["BranchSizeList"] = dBConnection.GetBranchSizes();
            return View();
        }
        [HttpPost]
        public BranchModel branch_add(BranchModel br)
        {
            if (br.ISACTIVE == "Active")
                br.ISACTIVE = "Y";
            else if (br.ISACTIVE == "InActive")
                br.ISACTIVE = "N";

            if (br.BRANCHID == 0)
                br = dBConnection.AddBranch(br);
            else
                br = dBConnection.UpdateBranch(br);
            return br;
        }

        public IActionResult divisions()
        {

            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["DivisionList"] = dBConnection.GetDivisions();
            return View();
        }
        [HttpPost]
        public DivisionModel division_add(DivisionModel div)
        {
            if (div.ISACTIVE == "Active")
                div.ISACTIVE = "Y";
            else if (div.ISACTIVE == "InActive")
                div.ISACTIVE = "N";
           
            if (div.DIVISIONID == 0)
                div=dBConnection.AddDivision(div);
            else
                div=dBConnection.UpdateDivision(div);
            return div;
        }
        public IActionResult departments()
        {

            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["DivisionList"] = dBConnection.GetDivisions();
            ViewData["DepartmentList"] = dBConnection.GetDepartments(0);
            return View();
        }
        [HttpPost]
        public DepartmentModel department_add(DepartmentModel dept)
        {
            if (dept.STATUS == "Active")
                dept.STATUS = "A";
            else if (dept.STATUS == "InActive")
                dept.STATUS = "I";

            if (dept.ID == 0)
                dept = dBConnection.AddDepartment(dept);
            else
                dept = dBConnection.UpdateDepartment(dept);
            return dept;
        }
        public IActionResult audit_zones()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["AuditZoneList"] = dBConnection.GetAuditZones();
            return View();
        }

        public IActionResult processes()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["DivisionList"] = dBConnection.GetDivisions(false);
            ViewData["ProcessList"] = dBConnection.GetRiskProcessDefinition();
            return View();
        }
        public IActionResult process_review()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["TransactionsList"] = dBConnection.GetRiskProcessTransactionsWithStatus(1);
            return View();
        }
        public IActionResult process_authorize()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["DivisionList"] = dBConnection.GetDivisions(false);
            ViewData["ProcessList"] = dBConnection.GetRiskProcessDefinition();
            return View();
        }
        public IActionResult sub_entities()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["SubEntitiesList"] = dBConnection.GetSubEntities();
            ViewData["DivisionList"] = dBConnection.GetDivisions(false);
            ViewData["DepartmentList"] = dBConnection.GetDepartments(0,false);
            return View();
        }
        [HttpPost]
        public List<DepartmentModel> get_departments(int div_id)
        {
            return dBConnection.GetDepartments(div_id,false);
        }
        [HttpPost]
        public List<SubEntitiesModel> get_sub_entities(int div_id=0,int dept_id=0)
        {
            return dBConnection.GetSubEntities(div_id,dept_id);
        }
        [HttpPost]
        public SubEntitiesModel add_sub_entity(SubEntitiesModel entity)
        {
            if (entity.STATUS == "Active")
                entity.STATUS = "Y";
            else
                entity.STATUS = "N";
            if(entity.ID==0)
                return dBConnection.AddSubEntity(entity);
            else
                return dBConnection.UpdateSubEntity(entity);
        }
        [HttpPost]
        public List<RiskProcessDetails> process_details(int ProcessId)
        {
            return dBConnection.GetRiskProcessDetails(ProcessId);
        }
        [HttpPost]
        public List<RiskProcessTransactions> process_transactions(int ProcessDetailId=0, int transactionId = 0)
        {
            return dBConnection.GetRiskProcessTransactions(ProcessDetailId, transactionId);
        }
        [HttpPost]
        public RiskProcessDefinition process_add(RiskProcessDefinition proc)
        {
            return dBConnection.AddRiskProcess(proc);            
        }
        [HttpPost]
        public RiskProcessDetails sub_process_add(RiskProcessDetails subProc)
        {
            return dBConnection.AddRiskSubProcess(subProc);
        }
        [HttpPost]
        public RiskProcessTransactions sub_process_transaction_add(RiskProcessTransactions tran)
        {
            return dBConnection.AddRiskSubProcessTransaction(tran);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
