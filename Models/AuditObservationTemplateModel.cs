using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IAMS.Models
{
    public class AuditObservationTemplateModel
    {        
        public int ACTIVITY_ID { get; set; }
        public int TEMP_ID { get; set; }
        public string OBS_TEMPLATE { get; set; }
    }
}
