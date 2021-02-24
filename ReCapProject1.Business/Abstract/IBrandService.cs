using Core.Utility.Results;
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
        IResult Add(Brand entity);
        IResult Update(Brand entity);
        IResult Delete(Brand entity);
        IDataResult<List<Brand>> GetAll();
    }
}
