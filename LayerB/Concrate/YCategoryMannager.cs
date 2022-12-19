using LayerB.Abstract;
using LayerDA.EntityFramework;
using LayerE.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerB.Concrate
{
    public class YCategoryMannager : IYCategoryService
    {
        EFYCategoryRepositroy efYCategoryRepository;

        public YCategory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<YCategory> GetList()
        {
            throw new NotImplementedException();
        }

        public void YCategoryAdd(YCategory ycategory)
        {
            throw new NotImplementedException();
        }

        public void YCategoryDelete(YCategory ycategory)
        {
            throw new NotImplementedException();
        }

        public void YCategoryUpdate(YCategory ycategory)
        {
            throw new NotImplementedException();
        }
    }
}
