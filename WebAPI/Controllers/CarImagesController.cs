using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class CarImagesController : Controller
    {

        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
            
        }


        [HttpGet("getall")]
        public IActionResult GetAllImage()
        {

            var result = _carImageService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }
    }
}
