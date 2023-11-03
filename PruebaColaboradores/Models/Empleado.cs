using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdTitulo { get; set; }


    }
}