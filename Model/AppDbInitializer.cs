using System;
using System.Data.Entity;
using System.Linq;

namespace CineDBteste.Model
{
    internal class AppDbInitializer : DropCreateDatabaseIfModelChanges<CinemaContext>
    {
        protected override void Seed(CinemaContext context)
        {
            context.Utilizadores.Add(new Utilizador
            {
                Username = "admin",
                Password = "12345"
            });

            context.Utilizadores.Add(new Utilizador
            {
                Username = "pedro",
                Password = "1234"
            });

            context.Filmes.Add(new Filmecs
            {
                Titulo = "Matrix",
                Genero = "Ficção Científica",
                Ano = 1999,
                Realizador = "Lana e Lilly Wachowski",
                DataHoraAlteracao = DateTime.Now,
                AlteradoPor = "Sistema",
                VezesVisto = 1
            });

            context.Filmes.Add(new Filmecs
            {
                Titulo = "Titanic",
                Genero = "Romance",
                Ano = 1997,
                Realizador = "James Cameron",
                DataHoraAlteracao = DateTime.Now,
                AlteradoPor = "Sistema",
                VezesVisto = 1
            });

            context.Filmes.Add(new Filmecs
            {
                Titulo = "Gladiador",
                Genero = "Acção",
                Ano = 2000,
                Realizador = "Ridley Scott",
                DataHoraAlteracao = DateTime.Now,
                AlteradoPor = "Sistema",
                VezesVisto = 3
            });

            context.SaveChanges();

            int mesAtual = DateTime.Today.Month;
            int anoAtual = DateTime.Today.Year;

            Filmecs matrix = context.Filmes.FirstOrDefault(f => f.Titulo == "Matrix");
            Filmecs titanic = context.Filmes.FirstOrDefault(f => f.Titulo == "Titanic");
            Filmecs gladiador = context.Filmes.FirstOrDefault(f => f.Titulo == "Gladiador");

            if (matrix != null)
            {
                context.ComprarFilmes.Add(new ComprarFilme
                {
                    FilmeId = matrix.Id,
                    PrecoCompra = 30,
                    NotaIMDb = 8.7m,
                    DataCompra = new DateTime(anoAtual, mesAtual, 6)
                });
            }

            if (titanic != null)
            {
                context.ComprarFilmes.Add(new ComprarFilme
                {
                    FilmeId = titanic.Id,
                    PrecoCompra = 37.4m,
                    NotaIMDb = 8.1m,
                    DataCompra = new DateTime(anoAtual, mesAtual, 6)
                });
            }

            if (gladiador != null)
            {
                context.ComprarFilmes.Add(new ComprarFilme
                {
                    FilmeId = gladiador.Id,
                    PrecoCompra = 28,
                    NotaIMDb = 8.5m,
                    DataCompra = new DateTime(anoAtual, mesAtual, 6)
                });
            }

            context.OrcamentosMensais.Add(new OrcamentoMensal
            {
                Mes = mesAtual,
                Ano = anoAtual,
                ValorOrcamento = 200m
            });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
