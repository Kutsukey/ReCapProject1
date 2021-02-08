using Core.DataAccess;
using ReCapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject1.DataAccess
{
    public interface ICarDal:IEntityRepository<Car>
    {
        
    }
}
