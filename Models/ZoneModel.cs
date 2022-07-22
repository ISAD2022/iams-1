using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IAMS.Models
{
    public class ZoneModel
    {        
        public int ZONEID { get; set; }
        public string ZONECODE { get; set; }
        public string ZONENAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string ISACTIVE { get; set; }       
    }
}
