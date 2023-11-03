using Microsoft.AspNetCore.Mvc;
using WebApplication2.context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeguroController : ControllerBase
    {
        private readonly ILogger<SeguroController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public SeguroController(
            ILogger<SeguroController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }

        [HttpPost]
        public IActionResult Post(
            [FromBody] Seguro seguro)
        {
            _aplicacionContexto.Seguros.Add(seguro);
            _aplicacionContexto.SaveChanges();
            return Ok(seguro);
        }

        [HttpGet]

        public IEnumerable<Seguro> Get()
        {
            return _aplicacionContexto.Seguros.ToList();
        }


        [HttpPut]
        public IActionResult Put([FromBody] Seguro seguro)
        {
            _aplicacionContexto.Seguros.Update(seguro);
            _aplicacionContexto.SaveChanges();
            return Ok(seguro);

        }

        [HttpDelete]
        public IActionResult Delete(int seguroID)
        {
            _aplicacionContexto.Seguros.Remove(
                _aplicacionContexto.Seguros.ToList()
                .Where(x => x.IdSeguro == seguroID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(seguroID);
        }
    }
}
