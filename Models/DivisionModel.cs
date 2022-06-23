using System;

namespace IAMS.Models
{
    public class DivisionModel
    {        
        public int ID { get; set; }
        public string NAME { get; set; }
        public string CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public DateTime? CREATED_ON { get; set; }
        public DateTime? CLOSED_ON { get; set; }
        public string STATUS { get; set; }
        public string REFERENCE_CIRCULAR { get; set; }
      
    }
}
