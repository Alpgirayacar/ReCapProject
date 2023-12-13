using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal :EntityRepositoryBase<CarImage, ReCapDbContext>, ICarImageDal
    {
        //public void Add(CarImages entity)
        //{
           
        //        using (ReCapDbContext context = new ReCapDbContext())
        //        {
        //            var addedEntity = context.Entry(entity);
        //            addedEntity.State = EntityState.Added;
        //            context.SaveChanges();

        //        }
            
        //}

        //public void Delete(CarImages entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public CarImages Get(Expression<Func<CarImages, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

     

        //public List<CarImages> GetAll(Expression<Func<CarImages, bool>> filter = null)
        //{
        //    using (ReCapDbContext context = new ReCapDbContext())
        //    {
        //        return filter == null ? context.Set<CarImages>().ToList() : context.Set<CarImages>().Where(filter).ToList();

        //    }
        //}

        //public List<CarImages> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(CarImages entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
