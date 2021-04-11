using GestionProyectos.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProyectos.Infrastructure.Data
{
    public class GestionProyectoContext : DbContext
    {
        public DbSet<Proyecto> Proyecto { get; set; }
        public DbSet<Obsercion> Obsercion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=E:\WORLD\DDD\GestionProyectos.Solucion\DB\GestionProyectos.db");
    }
}
