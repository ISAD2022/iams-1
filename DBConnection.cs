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
using Oracle.ManagedDataAccess.Client;

namespace IAMS
{
    public class DBConnection
    {
        public OracleConnection DatabaseConnection()
        {
            try
            {
                // create connection
                OracleConnection con = new OracleConnection();

                // create connection string using builder
                OracleConnectionStringBuilder ocsb = new OracleConnectionStringBuilder();
                ocsb.Password = "iamsdev";
                ocsb.UserID = "iamsdev";
                ocsb.DataSource = "10.1.100.222:1521/devdb18c.ztbl.com.pk";

                // connect
                con.ConnectionString = ocsb.ConnectionString;
                con.Open();
                return con;

            }
            catch (Exception e) { return null; }
        }

        public UserModel AutheticateLogin(LoginModel login)
        {
            var con = this.DatabaseConnection();
            UserModel user = new UserModel();
            using (OracleCommand cmd = con.CreateCommand())
            {
                //con.Open();
                cmd.CommandText = "Select * FROM iamsdev.T_USERS u WHERE u.PP_NUMBER='" + login.PPNumber + "' and u.Password ='" + login.Password + "' and u.Status='Active'"; 
                OracleDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    
                    user.ID = Convert.ToInt32(rdr["Id"]);
                    user.Name = rdr["Name"].ToString();
                    user.Email = rdr["Email"].ToString();
                    user.PPNumber = rdr["PP_Number"].ToString();
                }                
            }
            return user;
        }
       
    }
}
