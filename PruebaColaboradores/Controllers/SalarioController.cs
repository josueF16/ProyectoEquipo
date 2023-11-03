using Microsoft.AspNetCore.Mvc;
using WebApplication2.context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalarioController : ControllerBase
    {
        private readonly ILogger<SalarioController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public SalarioController(
            ILogger<SalarioController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }



        [HttpPost]
        public IActionResult Post(
            [FromBody] Salario salario)
        {
            _aplicacionContexto.Salarios.Add(salario);
            _aplicacionContexto.SaveChanges();
            return Ok(salario);
        }



        [HttpGet]

        public IEnumerable<Salario> Get()
        {
            return _aplicacionContexto.Salarios.ToList();
        }




        [HttpPut]
        public IActionResult Put([FromBody] Salario salario)
        {
            _aplicacionContexto.Salarios.Update(salario);
            _aplicacionContexto.SaveChanges();
            return Ok(salario);

        }



        [HttpDelete]
        public IActionResult Delete(int salarioID)
        {
            _aplicacionContexto.Salarios.Remove(
                _aplicacionContexto.Salarios.ToList()
                .Where(x => x.IdSalario == salarioID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(salarioID);
        }
    }
}
