using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using ReCapProject1.Entities;
using ReCapProject1.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject1.DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from r in context.Cars
                             join c in context.Colors
                             on r.ColorId equals c.ColorId
                             join b in context.Brands
                             on r.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 BrandName = b.BrandName,
                                 CarName = r.Descriptions,
                                 ColorName = c.ColorName,
                                 DailyPrice = r.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
