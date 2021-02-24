using Core.Utility.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject1.Business.Abstract
{
    public interface IServiceRepository<T>
    {
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);
        IDataResult<List<T>> GetAll();
    }
}
