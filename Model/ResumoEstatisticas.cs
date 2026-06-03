using System.Collections.Generic;

namespace CineDBteste.Model
{
    internal class ResumoEstatisticas
    {
        public int TotalFilmes { get; set; }
        public decimal TotalGasto { get; set; }
        public decimal Saldo { get; set; }
        public decimal PrecoMedio { get; set; }
        public string MelhorIMDbTexto { get; set; }
        public List<string> TopFilmes { get; set; }
        public List<string> FilmesPorGenero { get; set; }

        public ResumoEstatisticas()
        {
            TopFilmes = new List<string>();
            FilmesPorGenero = new List<string>();
        }
    }
}
