using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Salario
    {
        [Key]
        public int IdSalario { get; set; }
        public int salario { get; set; }
        public DateTime FechaInicio { get; set; }

    }
}