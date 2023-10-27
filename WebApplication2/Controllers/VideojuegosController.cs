using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Modelsss;

namespace WebApplication2.Controllersss
{
    [ApiController]
    [Route("[controller]")]
    public class VideojuegosController : ControllerBase
    {
        private readonly ILogger<VideojuegosController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public VideojuegosController(
            ILogger<VideojuegosController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Videojuegos videojuegos)
        {
            _aplicacionContexto.videojuegos.Add(videojuegos);
            _aplicacionContexto.SaveChanges();
            return Ok(videojuegos);
        }
        //READ: Obtener lista de estudiantes
        [Route("")]
        [HttpGet]
        public IEnumerable<Videojuegos> Get()
        {
            return _aplicacionContexto.videojuegos.ToList();
        }
        //Update: Modificar estudiantes
        [Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Videojuegos videojuegos)
        {
            _aplicacionContexto.videojuegos.Update(videojuegos);
            _aplicacionContexto.SaveChanges();
            return Ok(videojuegos);
        }
        //Delete: Eliminar estudiantes
        [Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int videojuegosID)
        {
            _aplicacionContexto.videojuegos.Remove(
                _aplicacionContexto.videojuegos.ToList()
                .Where(x => x.id_videojuegos == videojuegosID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(videojuegosID);
        }
    }
}
