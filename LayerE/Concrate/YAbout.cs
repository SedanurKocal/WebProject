using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerE.Concrate
{
    public class YAbout
    {
        [Key]
        public int YAbId { get; set; }
        public string YAbDetails { get; set; }
        public string YAbDetails1 { get; set; }
        public string YAbImage { get; set; }
        public string YAbImage1 { get; set; }
        public string YAbMapLocation { get; set; }
        public bool YAbStatus { get; set; }
    }
}
