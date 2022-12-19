using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerE.Concrate
{
    public class YCategory
    {
        [Key]
        public int IdYCategory { get; set; }
        public string NameYCategory { get; set; }
        public string DescriptionYCategory { get; set; }
        public bool StatusYCategory { get; set; }
        //
        public List<YBlog> YBlogs { get; set; }
    }
}
