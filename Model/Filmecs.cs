using System;

namespace CineDBteste.Model
{
    internal class Filmecs
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Ano { get; set; }
        public string Realizador { get; set; }

        public DateTime? DataHoraAlteracao { get; set; }
        public string AlteradoPor { get; set; }
        public int VezesVisto { get; set; }
    }
}
