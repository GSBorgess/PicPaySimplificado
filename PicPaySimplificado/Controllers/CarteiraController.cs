using Microsoft.AspNetCore.Mvc;
using PicPaySimplificado.Models.Request;
using PicPaySimplificado.Services.Carteiras;

namespace PicPaySimplificado.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarteiraController : Controller
    {
        private readonly ICarteiraService _carteiraService;

        public CarteiraController(ICarteiraService carteiraService)
        {
            _carteiraService = carteiraService;
        }

        [HttpPost]
        public async Task<IActionResult> PostCarteira(CarteiraRequest request)
        {
            var result = await _carteiraService.ExecuteAsync(request);

            if(!result.IsSuccess)
            {
                return BadRequest(result);
            }

            return Created();
        }
    }
}
