using Core.DataAccess;
using ReCapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject1.Business.Abstract
{
    interface IColorService
    {
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
        List<Color> GetAll();
    }
}
