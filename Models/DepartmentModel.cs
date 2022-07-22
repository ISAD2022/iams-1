using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IAMS.Models
{
    public class DepartmentModel
    {        
        public int ID { get; set; }
        public int DIV_ID { get; set; }
        public string NAME { get; set; }
        public string CODE { get; set; }
        public string STATUS { get; set; }
        [NotMapped]
        public string DIV_NAME { get; set; }
        [NotMapped]
        public string HO_UNIT_NAME { get; set; }


    }
}
