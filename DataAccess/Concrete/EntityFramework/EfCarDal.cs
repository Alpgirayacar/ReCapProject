using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EntityRepositoryBase<Car,ReCapDbContext> , ICarDal
    {
       public List <CarDetailDto> GetCarDetail()
        {
            using (ReCapDbContext context= new ReCapDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.CarId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                Description = c.Description,
                            
                             };


                return result.ToList();

            }
        }
    }
}
