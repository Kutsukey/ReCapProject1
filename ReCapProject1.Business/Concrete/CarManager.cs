using Core.Utility.Results;
using ReCapProject1.Business.Constrants;
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
    public class CarManager : ICarService
    {
        ICarDal _carService;

        public CarManager(ICarDal carService)
        {
            _carService = carService;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Descriptions.Length > 2)
            {
                _carService.Add(car);

                return new SuccessResult(Messages.CarAdded);
            }
            else
            {
                return new ErrorResult(Messages.CarNamePriceInvalid);
            }
        }

        public IResult Delete(Car car)
        {
            _carService.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            
            return new SuccessDataResult<List<Car>>(_carService.GetAll());
        }

        public IDataResult<Car> GetById(int Id)
        {
            return new SuccessDataResult<Car>(_carService.Get(c => c.Id == Id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carService.GetCarDetails());
        }

        public IResult Update(Car car)
        {
            _carService.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
