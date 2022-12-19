using LayerB.Abstract;
using LayerDA.Repositories;
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
        YCategoryRepository ycategoryRepository =new YCategoryRepository();
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
            if(ycategory.NameYCategory!="" && ycategory.DescriptionYCategory!=""&& ycategory.NameYCategory.Length>4 && ycategory.StatusYCategory == true)
            {
                ycategoryRepository.CategoryAdd(ycategory);
            }
            else
            {
                //Hata
            }
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
