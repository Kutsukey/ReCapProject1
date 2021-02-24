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
    public class UsersManager : IUsersService
    {
        IUsersDal _usersDal;

        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }

        public IResult Add(Users entity)
        {
            _usersDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Users entity)
        {
            _usersDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_usersDal.GetAll());
        }

        public IResult Update(Users entity)
        {
            _usersDal.Update(entity);
            return new SuccessResult();
        }
    }
}
