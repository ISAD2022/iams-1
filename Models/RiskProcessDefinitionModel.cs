using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IAMS.Models
{
    public class RiskProcessDefinition
    {        
        public int P_ID { get; set; }
        public string P_NAME { get; set; }
        public int RISK_ID { get; set; }        
    }
}
