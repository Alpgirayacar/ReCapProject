using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal

   
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
                {
                    new Car {  CarId = 1,
            BrandId = 101,
            ColorId = 201,
            ModelYear = 2023,
            DailyPrice = 50,
            Description = "Audi A3"},
                    new Car { CarId = 2,
            BrandId = 102,
            ColorId = 202,
            ModelYear = 2022,
            DailyPrice = 40,
            Description = "BMW 3 Series"},
                    new Car {   CarId = 3,
    BrandId = 103,
    ColorId = 203,
    ModelYear = 2024,
    DailyPrice = 60,
    Description = "Mercedes C-Class"},
                    new Car {   CarId = 4,
    BrandId = 104,
    ColorId = 204,
    ModelYear = 2022,
    DailyPrice = 45,
    Description = "Volkswagen Golf"}

                };
        }





        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId); 
            _cars.Remove(carToDelete);  

            
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
           return _cars;   
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllById(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrand(int brandId)
        {
          return   _cars.Where(c=>c.BrandId==brandId ).ToList();    
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {

            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.Description= car.Description;   
            carToUpdate.DailyPrice= car.DailyPrice; 
            carToUpdate.ModelYear= car.ModelYear;   
            carToUpdate.BrandId= car.BrandId;   
        }


}
      
    }

