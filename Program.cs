using System;
using System.Data.Entity;
using System.Windows.Forms;
using CineDBteste.View;
using CineDBteste.Model;

namespace CineDBteste
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new AppDbInitializer());

            using (CinemaContext db = new CinemaContext())
            {
                db.Database.Initialize(false);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (Form2 login = new Form2())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form1());
                }
            }
        }
    }
}
