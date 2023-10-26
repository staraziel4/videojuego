using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Modelss;

namespace WebApplication2.Controllerss
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly ILogger<EmailController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public EmailController(
            ILogger<EmailController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear docentes
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Email email)
        {
            _aplicacionContexto.email.Add(email);
            _aplicacionContexto.SaveChanges();
            return Ok(email);
        }
        //READ: Obtener lista de estudiantes
        [Route("")]
        [HttpGet]
        public IEnumerable<Email> Get()
        {
            return _aplicacionContexto.email.ToList();
        }
        //Update: Modificar estudiantes
        [Route("do/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Email email)
        {
            _aplicacionContexto.email.Update(email);
            _aplicacionContexto.SaveChanges();
            return Ok(email);
        }
        //Delete: Eliminar estudiantes
        [Route("do/id")]
        [HttpDelete]
        public IActionResult Delete(int emailID)
        {
            _aplicacionContexto.email.Remove(
                _aplicacionContexto.email.ToList()
                .Where(x => x.id_email == emailID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(emailID);
        }
    }
}
