using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;  
            
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _carService.GetAll(); 
            if(result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
            
        }

        [HttpPost("add")]

        public IActionResult Add(Car car)
        {

            var result = _carService.Add(car);
            if(result.Success==true) { 
                return Ok(result);  

            }
            return BadRequest(result);  

        }
        //[HttpPost("update")]

        //public IActionResult Update(Car car)
        //{

        //    var result = _carService.Update(car);
        //    if (result.Success == true)
        //    {
        //        return Ok(result);

        //    }
        //    return BadRequest(result);

        //}


    }
}
