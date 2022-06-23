using System;

namespace IAMS.Models
{
    public class BranchModel
    {        
        public int ID { get; set; }
        public int ZONE_ID { get; set; }
        public string BR_NAME { get; set; }
        public string BR_CODE { get; set; }
        public string ADDRESS { get; set; }
        public DateTime? CREATED_ON { get; set; }
        public DateTime? CLOSED_ON { get; set; }
        public string STATUS { get; set; }
        public string REFERENCE_CIRCULAR { get; set; }
        public int AZ_ID { get; set; }
        public int CAD_ID { get; set; }
    }
}
