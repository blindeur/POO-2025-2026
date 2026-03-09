namespace Amaury_POO_EX2_Parallelepipede
{
    internal class Program
    {
            static void Main()
            {
                int choix;

                do
                {
                    Console.Clear();

                    Console.WriteLine("===== MENU FORMES =====");
                    Console.WriteLine("1 - Calculer l'aire du carré");
                    Console.WriteLine("2 - Calculer le périmètre du carré");
                    Console.WriteLine("3 - Calculer l'aire du rectangle");
                    Console.WriteLine("4 - Calculer le périmètre du rectangle");
                    Console.WriteLine("5 - Afficher un carré");
                    Console.WriteLine("6 - Afficher un rectangle");
                    Console.WriteLine("0 - Quitter");

                    Console.Write("\nVotre choix : ");
                    choix = int.Parse(Console.ReadLine());

                    switch (choix)
                    {
                        case 1:
                            AireCarre();
                            break;

                        case 2:
                            PerimetreCarre();
                            break;

                        case 3:
                            AireRectangle();
                            break;

                        case 4:
                            PerimetreRectangle();
                            break;

                        case 5:
                            AfficherCarre();
                            break;

                        case 6:
                            AfficherRectangle();
                            break;

                        case 0:
                            Console.WriteLine("Fin du programme.");
                            break;

                        default:
                            Console.WriteLine("Choix invalide !");
                            break;
                    }

                    if (choix != 0)
                    {
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                    }

                } while (choix != 0);
            }

            static void AireCarre()
            {
                Console.Write("Entrez le côté du carré : ");
                float c = float.Parse(Console.ReadLine());

                Carre carre = new Carre(c, "Rouge");

                Console.WriteLine($"Aire du carré = {carre.CalculAire():0.00}");
            }

            static void PerimetreCarre()
            {
                Console.Write("Entrez le côté du carré : ");
                float c = float.Parse(Console.ReadLine());

                Carre carre = new Carre(c, "Rouge");

                Console.WriteLine($"Périmètre du carré = {carre.CalculPerimetre():0.00}");
            }

            static void AireRectangle()
            {
                Console.Write("Entrez la longueur : ");
                float L = float.Parse(Console.ReadLine());

                Console.Write("Entrez la largeur : ");
                float l = float.Parse(Console.ReadLine());

                Rectangle r = new Rectangle(L, l, "Bleu");

                Console.WriteLine($"Aire du rectangle = {r.CalculAire():0.00}");
            }

            static void PerimetreRectangle()
            {
                Console.Write("Entrez la longueur : ");
                float L = float.Parse(Console.ReadLine());

                Console.Write("Entrez la largeur : ");
                float l = float.Parse(Console.ReadLine());

                Rectangle r = new Rectangle(L, l, "Bleu");

                Console.WriteLine($"Périmètre du rectangle = {r.CalculPerimetre():0.00}");
            }

            static void AfficherCarre()
            {
                Console.Write("Entrez le côté : ");
                float c = float.Parse(Console.ReadLine());

                Console.Write("Entrez la couleur : ");
                string couleur = Console.ReadLine();

                Carre carre = new Carre(c, couleur);

                carre.Afficher();
            }

            static void AfficherRectangle()
            {
                Console.Write("Entrez la longueur : ");
                float L = float.Parse(Console.ReadLine());

                Console.Write("Entrez la largeur : ");
                float l = float.Parse(Console.ReadLine());

                Console.Write("Entrez la couleur : ");
                string couleur = Console.ReadLine();

                Rectangle r = new Rectangle(L, l, couleur);

                r.Afficher();
            }
        }
    }