using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using IAMS.Models;

namespace IAMS
{
    public class SessionHandler
    {
        private static SessionModel smodel = new SessionModel();
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

    }
}
