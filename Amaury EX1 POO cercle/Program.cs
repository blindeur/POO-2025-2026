namespace Amaury_EX1_POO_cercle
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans ce programme sur le cercle !");

            while (true)
            {
                Console.WriteLine("\nTapez un rayon pour votre cercle :");

                if (!double.TryParse(Console.ReadLine(), out double r))
                {
                    Console.WriteLine("Veuillez entrer un nombre valide !");
                    continue;
                }

                Cercle c = new Cercle(r);
                c.Afficher();

                // Exemple avec rayon divisé par 2
                Cercle c2 = new Cercle(r / 2);
                Console.WriteLine("\nAvec un cercle de rayon diminué de moitié :");
                c2.Afficher();

                Console.WriteLine("\nUn autre cercle ? (Tapez sur ESPACE pour quitter)");
                ConsoleKey key = Console.ReadKey().Key;

                if (key == ConsoleKey.Spacebar)
                    break;
            }

            Console.WriteLine("\nProgramme terminé !");
        }
    }
}
