using Microsoft.EntityFrameworkCore;
using QuizApi.Domain.Entities;

namespace QuizApi.Repositories.Context
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Pergunta> perguntas { get; set; }
        public DbSet<Alternativa> alternativas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseNpgsql("Host=kesavan.db.elephantsql.com;Database=dprpjajp;Username=dprpjajp;Password=O7v0IwisROmwT_o3ztIzsnEvIMySevP_");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
