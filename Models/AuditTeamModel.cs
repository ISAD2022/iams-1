using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace IAMS.Models
{
    public class AuditTeamModel
    {
        public int ID { get; set; }
        public int CODE { get; set; }
        public string NAME { get; set; }
        public int AUDIT_DEPARTMENT { get; set; }
        public int TEAMMEMBER_ID { get; set; }
        public string IS_TEAMLEAD { get; set; }
        [NotMapped]
        public string EMPLOYEENAME { get; set; }
        [NotMapped]
        public string PLACE_OF_POSTING { get; set; }

    }
}
