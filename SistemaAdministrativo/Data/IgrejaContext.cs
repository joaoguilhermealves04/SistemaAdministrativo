using Microsoft.EntityFrameworkCore;
using SistemaAdministrativo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAdministrativo.Data
{
    public class IgrejaContext : DbContext
    {
        public DbSet<Igreja> Igrejas { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Cadastro> Cadastros { get; set; }
        public DbSet<Ministerio> Ministerios { get; set; }
        public DbSet<Ministerio> Ministerio { get; set; }
        public DbSet<LivroCadastro> LivroCadastros { get; set; }
        public DbSet<IgrejaMinisterio> IgrejaMinisterios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SistemaAdministrativo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroCadastro>(entity =>
            {
                entity.HasKey(e => new { e.LivroId, e.CadastroId });


            });
            modelBuilder.Entity<IgrejaMinisterio>(entity =>
            {
                entity.HasKey(e => new { e.igrejaId, e.MinisterioId });


            });


        }
        

    }
}
