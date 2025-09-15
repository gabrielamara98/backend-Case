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
            var areas = _areaService.GetAll();
            return Ok(areas);
        }
        [HttpGet("{id}")]
        public ActionResult<Area> GetById(int id)
        {
            var areaId = _areaService.GetById(id);
            return Ok(areaId);
        }

        [HttpPost("nova-area")]
        public ActionResult AddAreaNova([FromBody] Area areaNova)
        {
            var areaCriada = _areaService.AddArea(areaNova);
            return Ok(areaCriada);
        }
    }
}
