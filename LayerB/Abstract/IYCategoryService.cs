using LayerE.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerB.Abstract
{
    public interface IYCategoryService
    {
        void YCategoryAdd(YCategory ycategory);
        void YCategoryDelete(YCategory ycategory);
        void YCategoryUpdate(YCategory ycategory);
        List<YCategory> GetList();
        YCategory GetById(int id);
    }
}
