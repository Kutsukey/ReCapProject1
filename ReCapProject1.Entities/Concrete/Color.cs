using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject1.Entities
{
    public class Color:IEntity
    {
        public string ColorName { get; set; }
        public int ColorId { get; set; }
    }
}
