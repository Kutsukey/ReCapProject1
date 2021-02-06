using ReCapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject1.DataAccess
{
    public class BrandDal
    {
        List<Brand> brands;
        public BrandDal()
        {
            brands = new List<Brand>
            {
                new Brand{BrandId=1,BrandName="Mercedes" },
                new Brand{BrandId=2,BrandName="BMW"},
                new Brand{BrandId=3,BrandName="Toyota"},
            };
        }
    }
}
