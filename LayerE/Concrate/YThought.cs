using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LayerE.Concrate
{
    public class YThought
    {
        [Key]
        public int YTId { get; set; }
        public string YTUserName { get; set; }
        public string YTTitle { get; set; }
        public string YTContent { get; set; }
        public DateTime YTDate { get; set; }
        public bool YTStatus { get; set; }
        //
        public int YBID { get; set; }
        public YBlog YBlog { get; set; }

    }
}
