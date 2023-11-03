using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Titulo> Titulos { get; set; }
        public DbSet<Salario> Salarios { get; set; }
        public DbSet<Seguro> Seguros { get; set; }


    }
}
