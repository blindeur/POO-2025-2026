using System.Diagnostics;
using System.Numerics;

namespace Poo_Chien_Amaury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chien[] ToutLesChiens = new Chien[4];


            ToutLesChiens[0] = new Chien("Kage", "Berger Allemand", 5, "Long", "65", "grand", false, true, "12345ABC");
            ToutLesChiens[1] = new Chien("Nova", "Husky de Sibérie", 3, "Long", "63", "grand", true, false, "78945CFT");
            ToutLesChiens[2] = new Chien("Ghost", "Malamute de l'Alaska", 4, "Long", "60", "grand", false, true, "16483SPQ");
            ToutLesChiens[3] = new Chien("Balto", "Dobermann", 2, "Court", "80", "grand", false, true, "65347LCD");
            for (int i = 0; i < ToutLesChiens.Length; i++)
            {
                Console.WriteLine(ToutLesChiens[i].RaceChien());
                Console.WriteLine(ToutLesChiens[i].Aboyer());
                Console.WriteLine(ToutLesChiens[i].Manger("croquettes"));
                Console.WriteLine(ToutLesChiens[i].Jouer("balle"));
                Console.WriteLine(ToutLesChiens[i].SeFaireCaresser());
                Console.WriteLine(ToutLesChiens[i].FaireUnePromenade("parc"));
                Console.WriteLine(ToutLesChiens[i].AfficherInfos());
            }
           

        }
    }
}
