using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CineDBteste.Model;

namespace CineDBteste.Controller
{
    internal static class Form1Controller
    {
        public static List<Filmecs> ObterFilmes()
        {
            using (CinemaContext db = new CinemaContext())
            {
                return db.Filmes
                    .OrderBy(f => f.Titulo)
                    .ToList();
            }
        }

        public static bool AdicionarFilme(string titulo, string genero, int ano,
            string realizador, int vezesVisto, out string mensagem)
        {
            mensagem = "";

            if (titulo.Trim() == "" || genero.Trim() == "" || realizador.Trim() == "")
            {
                mensagem = "Preencha todos os campos.";
                return false;
            }

            if (vezesVisto < 0)
            {
                mensagem = "O número de visualizações não pode ser negativo.";
                return false;
            }

            using (CinemaContext db = new CinemaContext())
            {
                bool repetido = db.Filmes.Any(f =>
                    f.Titulo == titulo &&
                    f.Genero == genero &&
                    f.Ano == ano &&
                    f.Realizador == realizador);

                if (repetido)
                {
                    mensagem = "Este filme já existe na base de dados.";
                    return false;
                }

                Filmecs filme = new Filmecs
                {
                    Titulo = titulo,
                    Genero = genero,
                    Ano = ano,
                    Realizador = realizador,
                    VezesVisto = vezesVisto,
                    DataHoraAlteracao = DateTime.Now,
                    AlteradoPor = Sessao.UtilizadorAtual
                };

                db.Filmes.Add(filme);
                db.SaveChanges();

                mensagem = "Filme guardado com sucesso.";
                return true;
            }
        }

        public static bool AtualizarFilme(int id, string titulo, string genero, int ano,
            string realizador, int vezesVisto, out string mensagem)
        {
            mensagem = "";

            if (titulo.Trim() == "" || genero.Trim() == "" || realizador.Trim() == "")
            {
                mensagem = "Preencha todos os campos.";
                return false;
            }

            if (vezesVisto < 0)
            {
                mensagem = "O número de visualizações não pode ser negativo.";
                return false;
            }

            using (CinemaContext db = new CinemaContext())
            {
                Filmecs filme = db.Filmes.Find(id);

                if (filme == null)
                {
                    mensagem = "Não existe nenhum filme com esse ID.";
                    return false;
                }

                bool repetido = db.Filmes.Any(f =>
                    f.Titulo == titulo &&
                    f.Genero == genero &&
                    f.Ano == ano &&
                    f.Realizador == realizador &&
                    f.Id != id);

                if (repetido)
                {
                    mensagem = "Já existe outro filme com os mesmos dados.";
                    return false;
                }

                filme.Titulo = titulo;
                filme.Genero = genero;
                filme.Ano = ano;
                filme.Realizador = realizador;
                filme.VezesVisto = vezesVisto;
                filme.DataHoraAlteracao = DateTime.Now;
                filme.AlteradoPor = Sessao.UtilizadorAtual;

                db.SaveChanges();

                mensagem = "Filme atualizado com sucesso.";
                return true;
            }
        }

        public static bool RemoverFilme(int id, out string mensagem)
        {
            mensagem = "";

            using (CinemaContext db = new CinemaContext())
            {
                Filmecs filme = db.Filmes.Find(id);

                if (filme == null)
                {
                    mensagem = "Não existe nenhum filme com esse ID.";
                    return false;
                }

                db.Filmes.Remove(filme);
                db.SaveChanges();

                mensagem = "Filme eliminado com sucesso.";
                return true;
            }
        }

        public static void ExportarCsv(string caminho)
        {
            using (CinemaContext db = new CinemaContext())
            {
                var filmes = db.Filmes
                    .OrderBy(f => f.Id)
                    .ToList();

                using (StreamWriter sw = new StreamWriter(caminho, false))
                {
                    sw.WriteLine("Id;Titulo;Genero;Ano;Realizador;DataHoraAlteracao;AlteradoPor;VezesVisto");

                    foreach (Filmecs f in filmes)
                    {
                        string dataHora = "";

                        if (f.DataHoraAlteracao.HasValue)
                        {
                            dataHora = f.DataHoraAlteracao.Value.ToString("dd/MM/yyyy HH:mm:ss");
                        }

                        sw.WriteLine(
                            f.Id + ";" +
                            EscaparCsv(f.Titulo) + ";" +
                            EscaparCsv(f.Genero) + ";" +
                            f.Ano + ";" +
                            EscaparCsv(f.Realizador) + ";" +
                            dataHora + ";" +
                            EscaparCsv(f.AlteradoPor) + ";" +
                            f.VezesVisto
                        );
                    }
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
