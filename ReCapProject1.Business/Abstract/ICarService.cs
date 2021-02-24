using Core.Utility.Results;
using ReCapProject1.Business.Abstract;
using ReCapProject1.DataAccess;
using ReCapProject1.Entities;
using ReCapProject1.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject1.Business
{
    public interface ICarService
    {
        IResult Add(Car entity);
        IResult Update(Car entity);
        IResult Delete(Car entity);
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int Id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
