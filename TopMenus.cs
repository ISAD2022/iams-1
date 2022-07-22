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


namespace IAMS
{

    public class TopMenus
    {
        private readonly DBConnection dBConnection = new DBConnection();
        public List<Object> GetTopMenus()
        {
            
            var menus =dBConnection.GetTopMenus();
            List<object> menuList = new List<object>();
            foreach (var item in menus)
            {
                menuList.Add(item);
            }
            return menuList;
        }

        public List<Object> GetTopMenusPages()
        {
            var menus = dBConnection.GetTopMenuPages();
            List<object> menuList = new List<object>();
            foreach (var item in menus)
            {
                menuList.Add(item);
            }
            return menuList;
        }

    }
}
