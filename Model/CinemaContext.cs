using System.Data.Entity;

namespace CineDBteste.Model
{
    internal class CinemaContext : DbContext
    {
        public CinemaContext() : base("CinemaContext")
        {
        }

        public DbSet<Filmecs> Filmes { get; set; }
        public DbSet<ComprarFilme> ComprarFilmes { get; set; }
        public DbSet<OrcamentoMensal> OrcamentosMensais { get; set; }
        public DbSet<Utilizador> Utilizadores { get; set; }
    }
}
