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

        public YCategoryMannager()
        {
            efYCategoryRepository = new EFYCategoryRepositroy();
        }

        public YCategory GetById(int id)
        {
            return efYCategoryRepository.GetById(id);
        }

        public List<YCategory> GetList()
        {
            return efYCategoryRepository.GetAllList();
        }

        public void YCategoryAdd(YCategory ycategory)
        {
            efYCategoryRepository.Insert(ycategory);
        }

        public void YCategoryDelete(YCategory ycategory)
        {
            efYCategoryRepository.Delete(ycategory);   
        }

        public void YCategoryUpdate(YCategory ycategory)
        {
            efYCategoryRepository.Update(ycategory);
        }
    }
}
