using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerE.Concrate
{
    public class YAskUs
    {
        [Key]
        public int YAId { get; set; }
        public string YAUserName { get; set; }
        public string YAMail { get; set; }
        public string YASubject { get; set; }
        public string YAMessage { get; set; }
        public DateTime YADate { get; set; }
        public bool YAStatus { get; set; }
    }
}
