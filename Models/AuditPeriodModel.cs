using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IAMS.Models
{
    public class AuditPeriodModel
    {        
        public int ID { get; set; }
        public string DESCRIPTION { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public int AUDIT_CONDUCT_BY_DEPTID { get; set; }
        [NotMapped]
        public string DEPARTMENT_NAME { get; set; }
    }
}
