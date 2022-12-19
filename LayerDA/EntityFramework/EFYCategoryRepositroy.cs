using LayerDA.Abstract;
using LayerDA.Repositories;
using LayerE.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDA.EntityFramework
{
    public class EFYCategoryRepositroy:GenericRepository<YCategory>, IYCategoryDal
    {
    }
}
