using System.ComponentModel.DataAnnotations.Schema;

namespace CineDBteste.Model
{
    [Table("Utilizadores")]
    internal class Utilizador
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
