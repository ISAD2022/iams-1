using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAMS.Models;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using IAMS.Controllers;

namespace IAMS
{

    public class TopMenus
    {
        private readonly DBConnection dBConnection = new DBConnection();
        private readonly SessionHandler sessionHandler = new SessionHandler();
        public List<Object> GetTopMenus()
        {
            List<object> menuList = new List<object>();
            var loggedUser=sessionHandler.GetSessionUser();
            if (loggedUser.ID != 0)
            {
                var menus = dBConnection.GetTopMenus();

                foreach (var item in menus)
                {
                    menuList.Add(item);
                }
            }
            return menuList;
        }

        public List<Object> GetTopMenusPages()
        {
            List<object> menuList = new List<object>();
            var loggedUser = sessionHandler.GetSessionUser();
            if (loggedUser.ID != 0)
            {
                var menus = dBConnection.GetTopMenuPages();

                foreach (var item in menus)
                {
                    menuList.Add(item);
                }
            }
            return menuList;
        }

       
    }
}
