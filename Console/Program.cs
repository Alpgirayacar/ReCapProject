// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

Console.WriteLine("Hello, World!");
Console.WriteLine("=======Car List ========");
CarTest();




//ColorTest();


//UserManager userManager = new UserManager(new EfUserDal());
////var result = userManager.GetAll();
//if (result.Success == true)
//{

//    foreach (var user in result.Data)
//    {

//        Console.WriteLine(user.FirstName);
//    }

//}
//else
//{
//    Console.WriteLine(result.Message);
//    Console.WriteLine("===============");
//}


static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());

    var result = carManager.GetAll();
    if (result.Success == true)
    {

        foreach (var car in result.Data)
        {

            Console.WriteLine(car.Description );
        }

    }
    else
    {
        Console.WriteLine(result.Message);
        Console.WriteLine("===============");
    }
    

 
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