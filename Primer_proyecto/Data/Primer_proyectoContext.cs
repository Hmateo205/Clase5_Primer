using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Primer_proyecto.Models;

namespace Primer_proyecto.Data
{
    public class Primer_proyectoContext : DbContext
    {
        public Primer_proyectoContext (DbContextOptions<Primer_proyectoContext> options)
            : base(options)
        {
        }

        public DbSet<Primer_proyecto.Models.Persona> Persona { get; set; } = default!;
    }
}
