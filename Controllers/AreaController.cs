using Case.Models;
using Case.Service;
using Microsoft.AspNetCore.Mvc;

namespace Case.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AreaController : Controller
    {
        private readonly IAreaService _areaService;

        public AreaController(IAreaService areaService)
        {
            _areaService = areaService;
        }

        [HttpGet("get-all")]
        public ActionResult<List<Area>> GetAll()
        {
            return Ok();
        }
    }
}
