using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IAMS.Models
{
    public class UserGroupRoleMappingModel
    {        
        public int? USERID { get; set; }
        public int? PPNO { get; set; }
        public int? GROUP_ID { get; set; }        
        public int? ROLE_ID { get; set; }
     
    }
}
