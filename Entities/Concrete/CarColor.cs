
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
namespace Entities.Concrete
{
    public class CarColor : IEntity
    {
        public int CarColorId { get; set; }
        public string CarColorName { get; set; }
    }
}
