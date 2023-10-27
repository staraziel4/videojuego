using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public UsuarioController(
            ILogger<UsuarioController> logger, 
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Usuario usuario)
        {
            _aplicacionContexto.usuario.Add(usuario);
            _aplicacionContexto.SaveChanges();
            return Ok(usuario);
        }
        //READ: Obtener lista de estudiantes
        [Route("")]
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return _aplicacionContexto.usuario.ToList();
        }
        //Update: Modificar estudiantes
        [Route("es/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Usuario usuario)
        {
            _aplicacionContexto.usuario.Update(usuario);
            _aplicacionContexto.SaveChanges();
            return Ok(usuario);
        }
        //Delete: Eliminar estudiantes
        [Route("es/id")]
        [HttpDelete]
        public IActionResult Delete(int usuarioID)
        {
            _aplicacionContexto.usuario.Remove(
                _aplicacionContexto.usuario.ToList()
                .Where(x=>x.id_usuario == usuarioID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(usuarioID);
        }
    }
}