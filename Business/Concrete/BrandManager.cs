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
    public class BrandManager : IBrandService
    {
        public IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;   
            
           
        }

        public List<Brand> GetAll()
        {
           return _brandDal.GetAll();   
        }

        public List<Brand> GetAllById(int brandId)
        {
            return _brandDal.GetAll(filter: p =>p.BrandId == brandId);
        }
    }
}
