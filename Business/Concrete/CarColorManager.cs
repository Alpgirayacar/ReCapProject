using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarColorManager:ICarColorService
    {
        ICarColorDal _carColorDal;
        public CarColorManager(ICarColorDal carColorDal) 
        {
            _carColorDal= carColorDal;

        }

        public List<CarColor> GetAll()
        {
            return _carColorDal.GetAll();
        }

        public List<CarColor> GetAllById(int Id)
        {
            return _carColorDal.GetAll(filter: p => p.CarColorId == Id);
        }

       
    }
}
