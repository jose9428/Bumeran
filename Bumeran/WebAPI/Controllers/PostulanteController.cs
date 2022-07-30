using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Services;
using WebAPI.Transfers;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostulanteController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            List<Postulante> lista = PostulanteSOA.ListarPostulantes();
            return Ok(lista);
        }

        [HttpPost]
        [Route("guardar")]
        public IActionResult Registro(PostulanteDt obj)
        {
            ApiResponse apiResponse = PostulanteSOA.RegistroPostulante(obj);
            return Ok(apiResponse);
        }
    }
}
