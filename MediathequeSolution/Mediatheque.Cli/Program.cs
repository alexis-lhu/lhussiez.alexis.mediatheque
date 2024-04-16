using Mediatheque.Core;
using Mediatheque.Core.Model;

namespace Mediatheque.Cli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ApplicationDBcontexte applicationDBcontexte = new ApplicationDBcontexte();
            CD cd1 = new CD()
            {
                TitreDeLObjet = "toto",
                DateDeSortie = DateTime.Now,
            };
            CD cd2 = new CD()
            {
                TitreDeLObjet = "popo",
                DateDeSortie = DateTime.Now,
            };
            applicationDBcontexte.CDs.Add(cd1);
            applicationDBcontexte.CDs.Add(cd2);
            applicationDBcontexte.SaveChanges();
        }
}
}