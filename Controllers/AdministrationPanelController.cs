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
    public class AdministrationPanelController : Controller
    {
        private readonly ILogger<AdministrationPanelController> _logger;
        private readonly TopMenus tm = new TopMenus();
        private readonly DBConnection dBConnection = new DBConnection();

        public AdministrationPanelController(ILogger<AdministrationPanelController> logger)
        {
            _logger = logger;
        }


        public IActionResult audit_criteria()
        {

            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            return View();
        }
        public IActionResult audit_observation_text()
        {

            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            return View();
        }

        public IActionResult audit_period()
        {

            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();

            return View();
        }

        public IActionResult audit_template()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            return View();
        }
        public IActionResult groups()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["GroupList"] = dBConnection.GetGroups();
            ViewData["MenuList"] = dBConnection.GetAllTopMenus();
            ViewData["MenuPagesList"] = dBConnection.GetAllMenuPages();
            return View();
        }
        public IActionResult menu_assignment()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["GroupList"] = dBConnection.GetGroups();
            ViewData["MenuList"] = dBConnection.GetAllTopMenus();
            ViewData["MenuPagesList"] = dBConnection.GetAllMenuPages();
            return View();
        }
        public IActionResult observation_status()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            return View();
        }
        public IActionResult pages_management()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            return View();
        }
        public IActionResult plan_status()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            return View();
        }
        public IActionResult risk_model()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            return View();
        }
        public IActionResult user_roles()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["UserList"] = dBConnection.GetAuditEmployees();
            ViewData["MenuList"] = dBConnection.GetAllTopMenus();
            ViewData["MenuPagesList"] = dBConnection.GetAllMenuPages();
            ViewData["GroupList"] = dBConnection.GetGroups();
            return View();
        }
        [HttpPost]
        public List<MenuPagesModel> menu_pages(int MENU_ID=0)
        {
            return dBConnection.GetAllMenuPages(MENU_ID);
        }
        [HttpPost]
        public GroupMenuItemMapping add_group_item_assignment(GroupMenuItemMapping gItemMap)
        {
            if (gItemMap.MENU_ITEM_IDs!=null && gItemMap.MENU_ITEM_IDs.Count > 0)
            {
                var menu_items_ids = String.Join(",", gItemMap.MENU_ITEM_IDs);
                dBConnection.AddGroupMenuAssignment(gItemMap.GROUP_ID, gItemMap.MENU_ID, menu_items_ids);
                if (gItemMap.UNLINK_MENU_ITEM_IDs != null && gItemMap.UNLINK_MENU_ITEM_IDs.Count > 0)
                {
                    foreach (var id in gItemMap.UNLINK_MENU_ITEM_IDs)
                    {
                        dBConnection.RemoveGroupMenuItemsAssignment(gItemMap.GROUP_ID, id);
                    }
                }
                foreach (var id in gItemMap.MENU_ITEM_IDs)
                {
                    dBConnection.AddGroupMenuItemsAssignment(gItemMap.GROUP_ID, id);
                }
            }
            else
            {
                dBConnection.RemoveGroupMenuAssignment(gItemMap.GROUP_ID, gItemMap.MENU_ID);
            }
            return gItemMap;
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
