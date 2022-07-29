using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using IAMS.Models;
using System.Collections.Generic;

namespace IAMS
{
    public class SessionHandler
    {
        private static SessionModel smodel = new SessionModel();
        private readonly DBConnection dBConnection = new DBConnection();
        public void SetSessionUser(UserModel user)
        {
            smodel.Email = user.Email;
            smodel.PPNumber = user.PPNumber;
            smodel.ID = user.ID;
            smodel.UserPostingAuditZone = user.UserPostingAuditZone;
            smodel.UserPostingBranch = user.UserPostingBranch;
            smodel.UserPostingDept = user.UserPostingDept;
            smodel.UserPostingDiv = user.UserPostingDiv;
            smodel.UserPostingZone = user.UserPostingZone;
            smodel.IsActive = user.IsActive;
            smodel.UserLocationType = user.UserLocationType;
            smodel.UserGroupID = user.UserGroupID;
            smodel.UserRoleID = user.UserRoleID;
        }
        public SessionModel GetSessionUser()
        {
            return smodel;
        }
        public bool DisposeUserSession()
        {
           smodel = new SessionModel();
            return true;
        }
        public bool IsUserLoggedIn()
        {
            if (smodel.ID == 0)
                return false;
            else
                return true;
        }
        public bool HasPermissionToViewPage(string Page_name)
        {
            List<MenuPagesModel> mpages = dBConnection.GetTopMenuPages();
            bool check = false;
            foreach(var item in mpages)
            {
                if (Page_name.ToLower() == (item.Page_Path.Split('/')[1]).ToLower())
                    check = true;
            }
            if (Page_name.ToLower() == "home")
                check = true;
            return check;
        }

    }
}
