using LayerB.Abstract;
using LayerDA.Abstract;
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
        IYCategoryDal _yCategoryDal;

        public YCategoryMannager(IYCategoryDal yCategoryDal)
        {
            _yCategoryDal = yCategoryDal;
        }

       
        public YCategory GetById(int id)
        {
            return _yCategoryDal.GetById(id);
        }

        public List<YCategory> GetList()
        {
            return _yCategoryDal.GetAllList();
        }

        public void YCategoryAdd(YCategory ycategory)
        {
            _yCategoryDal.Insert(ycategory);
        }

        public void YCategoryDelete(YCategory ycategory)
        {
            _yCategoryDal.Delete(ycategory);   
        }

        public void YCategoryUpdate(YCategory ycategory)
        {
            _yCategoryDal.Update(ycategory);
        }
    }
}
