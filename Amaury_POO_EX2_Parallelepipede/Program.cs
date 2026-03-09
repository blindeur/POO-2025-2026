namespace Amaury_POO_EX2_Parallelepipede
{
    internal class Program
    {
        static void Main()
        {
            ConsoleKey choix;

            do
            {
                Console.Clear();
                Console.WriteLine("===== MENU CONSTRUIRE ET CALCULER =====");
                Console.WriteLine("1 - Construire et calculer le périmètre du carré");
                Console.WriteLine("2 - Construire et calculer le périmètre du rectangle");
                Console.WriteLine("3 - Construire et calculer l'aire du carré");
                Console.WriteLine("4 - Construire et calculer l'aire du rectangle");
                Console.WriteLine("0 - Quitter");
                Console.Write("\nChoix : ");

                choix = Console.ReadKey().Key;
                Console.WriteLine();

                switch (choix)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        CalculPerimetreCarre();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        CalculPerimetreRectangle();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        CalculAireCarre();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        CalculAireRectangle();
                        break;
                }

                if (choix != ConsoleKey.D0 && choix != ConsoleKey.NumPad0)
                {
                    Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                    Console.ReadKey();
                }

            } while (choix != ConsoleKey.D0 && choix != ConsoleKey.NumPad0);
        }

        static void CalculPerimetreCarre()
        {
            Console.Write("Entrez la longueur du côté : ");
            float cote = float.Parse(Console.ReadLine());

            float perimetre = 4 * cote;
            Console.WriteLine($"Périmètre du carré = {perimetre}");
        }

        static void CalculPerimetreRectangle()
        {
            Console.Write("Entrez la longueur : ");
            float longueur = float.Parse(Console.ReadLine());

            Console.Write("Entrez la largeur : ");
            float largeur = float.Parse(Console.ReadLine());

            float perimetre = 2 * (longueur + largeur);
            Console.WriteLine($"Périmètre du rectangle = {perimetre}");
        }

        static void CalculAireCarre()
        {
            Console.Write("Entrez la longueur du côté : ");
            float cote = float.Parse(Console.ReadLine());

            float aire = cote * cote;
            Console.WriteLine($"Aire du carré = {aire}");
        }

        static void CalculAireRectangle()
        {
            Console.Write("Entrez la longueur : ");
            float longueur = float.Parse(Console.ReadLine());

            Console.Write("Entrez la largeur : ");
            float largeur = float.Parse(Console.ReadLine());

            float aire = longueur * largeur;
            Console.WriteLine($"Aire du rectangle = {aire}");
        }
    }
}