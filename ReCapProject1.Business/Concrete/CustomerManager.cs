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
    public class CustomerManager : ICustomerService
    {
        ICustomersDal _customersDal;

        public CustomerManager(ICustomersDal customersDal)
        {
            _customersDal = customersDal;
        }

        public IResult Add(Customers entity)
        {
            _customersDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Customers entity)
        {
            _customersDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Customers>> GetAll()
        {
            return new SuccessDataResult<List<Customers>>(_customersDal.GetAll());
        }

        public IResult Update(Customers entity)
        {
            _customersDal.Update(entity);
            return new SuccessResult();
        }
    }
}
