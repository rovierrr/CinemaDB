using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CineDBteste.Model;

namespace CineDBteste.Controller
{
    internal static class Form3Controller
    {
        public static List<CompraGridDto> ObterCompras()
        {
            using (CinemaContext db = new CinemaContext())
            {
                return db.ComprarFilmes
                    .OrderByDescending(c => c.DataCompra)
                    .Select(c => new CompraGridDto
                    {
                        Id = c.Id,
                        Titulo = c.Filme.Titulo,
                        PrecoCompra = c.PrecoCompra,
                        NotaIMDb = c.NotaIMDb,
                        DataCompra = c.DataCompra
                    })
                    .ToList();
            }
        }

        public static bool RegistarCompra(string nomeFilme, decimal preco, decimal nota,
            DateTime dataCompra, out string mensagem)
        {
            mensagem = "";

            if (nomeFilme.Trim() == "")
            {
                mensagem = "Indique o nome do filme.";
                return false;
            }

            if (nota < 0 || nota > 10)
            {
                mensagem = "A classificação IMDb deve estar entre 0 e 10.";
                return false;
            }

            using (CinemaContext db = new CinemaContext())
            {
                Filmecs filme = db.Filmes.FirstOrDefault(f => f.Titulo == nomeFilme);

                if (filme == null)
                {
                    filme = new Filmecs
                    {
                        Titulo = nomeFilme,
                        Genero = "Não definido",
                        Ano = DateTime.Today.Year,
                        Realizador = "Desconhecido",
                        VezesVisto = 0,
                        DataHoraAlteracao = DateTime.Now,
                        AlteradoPor = Sessao.UtilizadorAtual
                    };

                    db.Filmes.Add(filme);
                    db.SaveChanges();
                }

                ComprarFilme compra = new ComprarFilme
                {
                    FilmeId = filme.Id,
                    PrecoCompra = preco,
                    NotaIMDb = nota,
                    DataCompra = dataCompra.Date
                };

                db.ComprarFilmes.Add(compra);
                db.SaveChanges();

                mensagem = "Compra registada com sucesso.";
                return true;
            }
        }

        public static bool GuardarOrcamento(int mes, int ano, decimal valor, out string mensagem)
        {
            mensagem = "";

            using (CinemaContext db = new CinemaContext())
            {
                OrcamentoMensal orcamento = db.OrcamentosMensais
                    .FirstOrDefault(o => o.Mes == mes && o.Ano == ano);

                if (orcamento == null)
                {
                    orcamento = new OrcamentoMensal
                    {
                        Mes = mes,
                        Ano = ano,
                        ValorOrcamento = valor
                    };

                    db.OrcamentosMensais.Add(orcamento);
                }
                else
                {
                    orcamento.ValorOrcamento = valor;
                }

                db.SaveChanges();

                mensagem = "Orçamento guardado com sucesso.";
                return true;
            }
        }

        public static ResumoEstatisticas ObterEstatisticas(int mes, int ano)
        {
            using (CinemaContext db = new CinemaContext())
            {
                ResumoEstatisticas resumo = new ResumoEstatisticas();

                resumo.TotalFilmes = db.Filmes.Count();

                var comprasMes = db.ComprarFilmes
                    .Where(c => c.DataCompra.Month == mes && c.DataCompra.Year == ano);

                decimal totalGasto = 0m;
                if (comprasMes.Any())
                {
                    totalGasto = comprasMes.Sum(c => c.PrecoCompra);
                }

                resumo.TotalGasto = totalGasto;

                OrcamentoMensal orcamento = db.OrcamentosMensais
                    .FirstOrDefault(o => o.Mes == mes && o.Ano == ano);

                decimal valorOrcamento = 0m;
                if (orcamento != null)
                {
                    valorOrcamento = orcamento.ValorOrcamento;
                }

                resumo.Saldo = valorOrcamento - totalGasto;

                if (comprasMes.Any())
                {
                    resumo.PrecoMedio = comprasMes.Average(c => c.PrecoCompra);
                }

                var melhorIMDb = db.ComprarFilmes
                    .OrderByDescending(c => c.NotaIMDb)
                    .Select(c => new
                    {
                        Titulo = c.Filme.Titulo,
                        c.NotaIMDb
                    })
                    .FirstOrDefault();

                if (melhorIMDb != null)
                {
                    resumo.MelhorIMDbTexto =
                        melhorIMDb.Titulo + " (" + melhorIMDb.NotaIMDb.ToString("0.0") + ")";
                }
                else
                {
                    resumo.MelhorIMDbTexto = "sem dados";
                }

                var topFilmes = db.Filmes
                    .OrderByDescending(f => f.VezesVisto)
                    .ThenBy(f => f.Titulo)
                    .Take(5)
                    .ToList();

                foreach (Filmecs f in topFilmes)
                {
                    resumo.TopFilmes.Add(f.Titulo + " - " + f.VezesVisto + " visualizações");
                }

                var filmesPorGenero =
                    from f in db.Filmes
                    group f by f.Genero into grupo
                    orderby grupo.Key
                    select new
                    {
                        Genero = grupo.Key,
                        Total = grupo.Count()
                    };

                foreach (var item in filmesPorGenero.ToList())
                {
                    resumo.FilmesPorGenero.Add(item.Genero + ": " + item.Total);
                }

                return resumo;
            }
        }

        public static void ExportarEstatisticasCsv(string caminho, int mes, int ano)
        {
            ResumoEstatisticas resumo = ObterEstatisticas(mes, ano);

            using (StreamWriter sw = new StreamWriter(caminho, false))
            {
                sw.WriteLine("Indicador;Valor");
                sw.WriteLine("Total de filmes;" + resumo.TotalFilmes);
                sw.WriteLine("Total gasto;" + resumo.TotalGasto.ToString("0.00"));
                sw.WriteLine("Saldo disponível;" + resumo.Saldo.ToString("0.00"));
                sw.WriteLine("Preço médio;" + resumo.PrecoMedio.ToString("0.00"));
                sw.WriteLine("Melhor IMDb;" + resumo.MelhorIMDbTexto);

                sw.WriteLine();
                sw.WriteLine("Top filmes mais vistos");
                sw.WriteLine("Descrição");

                foreach (string item in resumo.TopFilmes)
                {
                    sw.WriteLine(EscaparCsv(item));
                }

                sw.WriteLine();
                sw.WriteLine("Filmes por género");
                sw.WriteLine("Descrição");

                foreach (string item in resumo.FilmesPorGenero)
                {
                    sw.WriteLine(EscaparCsv(item));
                }
            }
        }

        private static string EscaparCsv(string valor)
        {
            if (valor == null)
            {
                return "";
            }

            if (valor.Contains(";") || valor.Contains("\""))
            {
                return "\"" + valor.Replace("\"", "\"\"") + "\"";
            }

            return valor;
        }
    }
}
