using ReCapProject1.DataAccess;
using ReCapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject1.Business
{
    public class CarManager:ICarService
    {
        ICarDal _carService;

        public CarManager(ICarDal carService)
        {
            _carService = carService;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0 && car.Descriptions[250]>=2)
            {
                _carService.Add(car);
            }
            else
            {
                Console.WriteLine("Açıklama ve günlük miktar geçersiz.");
            }
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
            return _carService.Get(c=>c.Id==Id);
        }

        public void Update(Car car)
        {
            _carService.Update(car);
        }
    }
}
