using System;

namespace CineDBteste.Model
{
    internal class ComprarFilme
    {
        public int Id { get; set; }
        public int FilmeId { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal NotaIMDb { get; set; }
        public DateTime DataCompra { get; set; }

        public virtual Filmecs Filme { get; set; }
    }
}
