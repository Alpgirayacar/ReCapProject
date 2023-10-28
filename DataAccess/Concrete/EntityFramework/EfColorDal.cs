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
    public class EfColorDal : ICarColorDal
    {
        public void Add(CarColor entity)
        {
            using(ReCapDbContext context = new ReCapDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();  
            }
        }

        public void Delete(CarColor entity)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public CarColor Get(Expression<Func<CarColor, bool>> filter)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                return context.Set<CarColor>().SingleOrDefault(filter);

            }
        }

        public List<CarColor> GetAll(Expression<Func<CarColor, bool>> filter = null)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                return filter ==  null ? context.Set<CarColor>().ToList() : context.Set<CarColor>().Where(filter).ToList(); 

            }
        }

     

        public void Update(CarColor entity)
        {
            
            
                using (ReCapDbContext context = new ReCapDbContext())
                {
                    var updatedEntity = context.Entry(entity);
                    updatedEntity.State = EntityState.Modified;
                    context.SaveChanges();
                }
            
        }
    }
}
