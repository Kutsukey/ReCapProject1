using ReCapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject1.DataAccess
{
    public class CarDal:ICarDal
    {
        List<Car> cars;
        public CarDal()
        {
            cars = new List<Car>
            {
                new Car{ BrandId=1,ColorId=2,DailyPrice=850,Description="Dizel",Id=1,ModelYear=2013},
                new Car{ BrandId=3,ColorId=2,DailyPrice=1000,Description="Elektrikli",Id=2,ModelYear=2018},
                new Car{ BrandId=2,ColorId=3,DailyPrice=630,Description="Benzinli",Id=3,ModelYear=2010},
                new Car{ BrandId=1,ColorId=4,DailyPrice=400,Description="Gazlı",Id=4,ModelYear=2003},
                new Car{ BrandId=2,ColorId=1,DailyPrice=250,Description="Dizel",Id=5,ModelYear=2001}
            };
        }

        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = cars.SingleOrDefault(c=>car.Id==c.Id);
            cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public Car GetById(int Id)
        {
            return cars.SingleOrDefault(c=>c.Id==Id);
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
