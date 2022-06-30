using Microsoft.EntityFrameworkCore;

namespace OOP
{

        public class EmpresaContext : DbContext
        {
            public DbSet<Empresa> Empresas { get; set; }
            public DbSet<Fornecedor> Fornecedores { get; set; }
            public DbSet<Parceiro> Parceiros { get; set; }
            public DbSet<Obra> Obras { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EmpresaDB;Trusted_Connection=true;");
            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parceiro>().HasMany(x => x.Obras).WithOne(x => x.Parceiro);
            base.OnModelCreating(modelBuilder);
        }
    }

   

}