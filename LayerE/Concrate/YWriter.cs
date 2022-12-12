using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerE.Concrate
{
    public class YWriter
    {
        [Key]
        public int YWID { get; set; }
        public string YWName { get; set; }
        public string YWAbout { get; set; }
        public string YWImage { get; set; }
        public string YWMail { get; set; }
        public string YWPass { get; set; }
        public bool YWStatus { get; set; }
    }
}
