using Case.Dto;
using Case.Models;
using Case.Service;
using Microsoft.AspNetCore.Mvc;

namespace Case.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessoController : Controller
    {
        private readonly IProcessoService _processoService;

        public ProcessoController(IProcessoService processoService)
        {
            _processoService = processoService;
        }

        [HttpGet]
        public ActionResult<List<Processo>> GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]

        public ActionResult <ProcessoDto> GetById(int id)
        {

            return Ok();

        }
    }
}
