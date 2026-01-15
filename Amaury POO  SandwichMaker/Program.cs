namespace Amaury_POO__SandwichMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace SandwichsAleatoires
    {
        class Program
        {
            static void Main(string[] args)
            {
                SandwichMaker sandwichMaker = new SandwichMaker();
                bool quitter = false;

                Console.WriteLine("Bienvenue dans notre concepteur de sandwich !");

                while (!quitter)
                {
                    Console.WriteLine();
                    Console.WriteLine("1 - Générer un sandwich");
                    Console.WriteLine("2 - Générer plusieurs sandwichs");
                    Console.WriteLine("0 - Quitter");
                    Console.Write("Votre choix : ");

                    string choix = Console.ReadLine();

                    switch (choix)
                    {
                        case "1":
                            Console.WriteLine("Voici votre sandwich :");
                            Console.WriteLine(sandwichMaker.ComposeSandwich());
                            break;

                        case "2":
                            Console.Write("Combien de sandwichs ? ");
                            int nombre;

                            if (int.TryParse(Console.ReadLine(), out nombre))
                            {
                                for (int i = 0; i < nombre; i++)
                                {
                                    Console.WriteLine($"{i + 1} - {sandwichMaker.ComposeSandwich()}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nombre invalide !");
                            }
                            break;

                        case "0":
                            quitter = true;
                            break;

                        default:
                            Console.WriteLine("Choix invalide !");
                            break;
                    }
                }
            }
        }
    }


}



