using JovemProgramadorMVC.Data.Mapeamento;
using JovemProgramadorMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace JovemProgramadorMVC.Data
{
    public class BancoContextoP : DbContext
    {
        public BancoContextoP(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProfessorMapeamento());
        }

        public DbSet<Professor> Professor { get; set; }
    }
}
