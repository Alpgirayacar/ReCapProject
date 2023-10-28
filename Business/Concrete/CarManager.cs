using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        

        ICarDal _carDal;

        public CarManager(ICarDal carDal )
        {
            _carDal = carDal;
            
        }



        public List<Car> GetAll()
        { 
            return _carDal.GetAll();
        }

        public List<Car> GetAllById(int id)
        {
            return _carDal.GetAll(p=>p.Id == id);   
        }

        public List<CarDetailDto> GetAllCarDetail()
        {
           return  _carDal.GetCarDetail();
        }
    }
}
