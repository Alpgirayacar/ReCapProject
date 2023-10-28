// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

Console.WriteLine("Hello, World!");
Console.WriteLine("=======Car List ========");
CarTest();

Console.WriteLine("===============");


Console.WriteLine("=========Brand Test======");

BrandTest();

Console.WriteLine("===============");
Console.WriteLine("=========CarColor Test======");




ColorTest();



static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    foreach (var car in carManager.GetAll())
    {
        Console.WriteLine(car.Description);
    }
    Console.WriteLine("=======Special Car With id ========");
    foreach (var car in carManager.GetAllById(1))
    {
        Console.WriteLine(car.Description);
    }

    Console.WriteLine("=====Deail Car==========");
    foreach (var car in carManager.GetAll())
    {
        Console.WriteLine(car.Description+"/"+car.BrandId);
    }
    Console.WriteLine("===============");

 
}

static void BrandTest()
{
    BrandManager brandManager = new BrandManager(new EfBrandDal());




    foreach (var brand in brandManager.GetAll())
    {
        Console.WriteLine(brand.BrandName);
    }
}

static void ColorTest()
{
    CarColorManager carColorManager = new CarColorManager(new EfColorDal());
    foreach (var carColor in carColorManager.GetAll())
    {
        Console.WriteLine(carColor.CarColorName);


    }
    foreach (var carColor in carColorManager.GetAllById(1))
    {
        Console.WriteLine(carColor.CarColorName);


    }
}