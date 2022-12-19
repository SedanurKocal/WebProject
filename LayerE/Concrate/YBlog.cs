using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerE.Concrate
{
    public class YBlog
    {
        [Key]
        public int YBID { get; set; }
        public string YBTitle { get; set; }
        public string YBContent { get; set; }
        public string YBSmallImage { get; set; }
        public string YBImage { get; set; }
        public string YBCreateDate { get; set; }
        public bool YBStatus { get; set; }
        //
        public int IdYCategory { get; set; }
        public YCategory YCategory { get; set; }
        public List<YThought> YThoughts { get; set; }
    }
}
