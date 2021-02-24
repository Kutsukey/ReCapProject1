﻿using Core.DataAccess;
using Core.Utility.Results;
using ReCapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject1.Business.Abstract
{
    public interface IColorService:IServiceRepository<Color>
    {
    }
}
