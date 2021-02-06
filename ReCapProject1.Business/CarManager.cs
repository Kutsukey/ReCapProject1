using ReCapProject1.DataAccess;
using ReCapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject1.Business
{
    public class CarManager:ICarService,ICarDal
    {
        ICarDal _carService;

        public CarManager(ICarDal carService)
        {
            _carService = carService;
        }

        public void Add(Car car)
        {
            _carService.Add(car);
        }

        public void Delete(Car car)
        {
            _carService.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carService.GetAll();
        }

        public Car GetById(int Id)
        {
            return _carService.GetById(Id);
        }

        public void Update(Car car)
        {
            _carService.Update(car);
        }
    }
}
