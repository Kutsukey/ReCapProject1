using Core.DataAccess.EntityFramework;
using ReCapProject1.DataAccess.Abstract;
using ReCapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject1.DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color,RentCarContext>,IColorDal
    {
    }
}
