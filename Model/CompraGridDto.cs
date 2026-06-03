using System;

namespace CineDBteste.Model
{
    internal class CompraGridDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal NotaIMDb { get; set; }
        public DateTime DataCompra { get; set; }
    }
}
