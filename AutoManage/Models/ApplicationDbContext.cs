using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoManage.Models;

namespace AutoManage.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Veiculo> Consumos { get; set; }
        public DbSet<AutoManage.Models.Consumo> Consumo { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
