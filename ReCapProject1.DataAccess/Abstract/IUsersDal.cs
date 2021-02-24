using Core.DataAccess;
using ReCapProject1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject1.DataAccess.Abstract
{
    public interface IUsersDal:IEntityRepository<Users>
    {
    }
}
