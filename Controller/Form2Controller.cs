using System.Linq;
using CineDBteste.Model;

namespace CineDBteste.Controller
{
    internal static class Form2Controller
    {
        public static bool Autenticar(string login, string password, out string mensagem)
        {
            mensagem = "";

            if (login.Trim() == "" || password.Trim() == "")
            {
                mensagem = "Deve introduzir o login e a password.";
                return false;
            }

            using (CinemaContext db = new CinemaContext())
            {
                Utilizador utilizador = db.Utilizadores
                    .FirstOrDefault(u => u.Username == login && u.Password == password);

                if (utilizador == null)
                {
                    mensagem = "Login ou password incorretos.";
                    return false;
                }

                Sessao.UtilizadorAtual = utilizador.Username;
                mensagem = "Autenticação efetuada com sucesso.";
                return true;
            }
        }
    }
}
