using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Seguro
    {
        [Key]
        public int IdSeguro { get; set; }
        public string Tipo { get; set; }
        public string Importe { get; set; }
        public DateTime FechaImporte { get; set; }

    }
}