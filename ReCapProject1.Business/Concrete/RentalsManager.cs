using Core.Utility.Results;
using ReCapProject1.Business.Abstract;
using ReCapProject1.DataAccess.Abstract;
using ReCapProject1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject1.Business.Concrete
{
    public class RentalsManager : IRentalsService
    {
        IRentalsDal _rentalsDal;

        public RentalsManager(IRentalsDal rentalsDal)
        {
            _rentalsDal = rentalsDal;
        }

        public IResult Add(Rentals entity)
        {
            _rentalsDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Rentals entity)
        {
            _rentalsDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_rentalsDal.GetAll());
        }

        public IResult Update(Rentals entity)
        {
            _rentalsDal.Update(entity);
            return new SuccessResult();
        }
    }
}
