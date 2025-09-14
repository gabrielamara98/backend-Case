using Case.Models;
using Microsoft.AspNetCore.Mvc;

namespace Case.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AreaController : Controller
    {

        private static List<Area> listaArea = new List<Area>()
        {
            new Area() {Id = 1, Nome = "TI", Descricao = "Area de TI", Status = true, Responsavel="Gabriel"},
            new Area() {Id = 2, Nome = "Financeiro", Descricao = "Area do Financeiro", Status = true, Responsavel="Julia"},
            new Area() {Id = 3, Nome = "RH", Descricao = "Area do RH", Status = true, Responsavel="Rodrigo"}
        };

        [HttpGet]
        public ActionResult<List<Area>> GetAll()
        {
            return Ok(listaArea);
        }
    }
}
