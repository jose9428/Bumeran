using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Services;
using WebAPI.Transfers;

namespace WebAPI.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class PublicacionController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            List<Publicacion> lista = PublicacionSOA.ListarPublicacion();
            return Ok(lista);
        }

        [HttpPost]
        [Route("guardar")]
        public IActionResult Registro(PublicacionDt obj)
        {
            ApiResponse apiResponse = PublicacionSOA.RegistroPublicacion(obj);
            return Ok(apiResponse);
        }

        [HttpPut]
        [Route("editar")]
        public IActionResult Editar(PublicacionDt obj)
        {
            ApiResponse apiResponse = PublicacionSOA.EditarPublicacion(obj);
            return Ok(apiResponse);
        }
        [HttpDelete]
        [Route("eliminar")]
        public IActionResult Eliminar(int id)
        {
            ApiResponse apiResponse = PublicacionSOA.EdliminarPublicacion(id);
            return Ok(apiResponse);
        }
    }
}
