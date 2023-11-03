using Microsoft.AspNetCore.Mvc;
using WebApplication2.context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TituloController : ControllerBase
    {
        private readonly ILogger<TituloController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public TituloController(
            ILogger<TituloController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Titulo titulo)
        {
            _aplicacionContexto.Titulos.Add(titulo);
            _aplicacionContexto.SaveChanges();
            return Ok(titulo);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]

        public IEnumerable<Titulo> Get()
        {
            return _aplicacionContexto.Titulos.ToList();
        }

        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Titulo titulo)
        {
            _aplicacionContexto.Titulos.Update(titulo);
            _aplicacionContexto.SaveChanges();
            return Ok(titulo);

        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int tituloID)
        {
            _aplicacionContexto.Titulos.Remove(
                _aplicacionContexto.Titulos.ToList()
                .Where(x => x.IdTitulo == tituloID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(tituloID);
        }
    }
}