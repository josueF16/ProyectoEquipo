using Microsoft.AspNetCore.Mvc;
using WebApplication2.context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpleadoController : ControllerBase
    {
        private readonly ILogger<EmpleadoController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public EmpleadoController(
            ILogger<EmpleadoController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Empleado empleado)
        {
            _aplicacionContexto.Empleados.Add(empleado);
            _aplicacionContexto.SaveChanges();
            return Ok(empleado);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]

        public IEnumerable<Empleado> Get()
        {
            return _aplicacionContexto.Empleados.ToList();
        }

        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Empleado empleado)
        {
            _aplicacionContexto.Empleados.Update(empleado);
            _aplicacionContexto.SaveChanges();
            return Ok(empleado);

        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int empleadoID)
        {
            _aplicacionContexto.Empleados.Remove(
                _aplicacionContexto.Empleados.ToList()
                .Where(x => x.IdEmpleado == empleadoID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(empleadoID);
        }
    }
}