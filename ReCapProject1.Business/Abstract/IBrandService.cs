using ReCapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject1.Business.Abstract
{
    public interface IBrandService
    {
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);
        List<Brand> GetAll();
    }
}
