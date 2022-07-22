using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IAMS.Models
{
    public class AuditZoneModel
    {
        public int ID { get; set; }
        public string ZONECODE { get; set; }
        public string ZONENAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string ISACTIVE { get; set; }

    }
}
