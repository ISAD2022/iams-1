using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IAMS.Models
{
    public class RiskProcessTransactions
    {
        public int ID { get; set; }
        public int PD_ID { get; set; }
        public int DIV_ID { get; set; }
        public string DIV_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string CONTROL_OWNER { get; set; }
        public string ACTION { get; set; }
        public string RISK_WEIGHTAGE { get; set; }
        public int RISK_MAX_NUMBER { get; set; }

    }
}
