namespace Amaury_EX2_POO_nombre_complexe
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans ce programme sur les complexes !");

            while (true)
            {
                Console.WriteLine("Que vaut la partie réelle du complexe de départ ?");
                double r1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Que vaut la partie imaginaire du complexe de départ ?");
                double i1 = double.Parse(Console.ReadLine());

                Complexe c1 = new Complexe(r1, i1);

                Console.WriteLine($"Le premier complexe : {c1.AfficheComplexe()} par module : {c1.CalculeModule():0.00}");

                // Second complexe
                Console.WriteLine("\nEncodez un second nombre complexe :");
                Console.WriteLine("Que vaut la partie réelle du second complexe ?");
                double r2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Que vaut la partie imaginaire du second complexe ?");
                double i2 = double.Parse(Console.ReadLine());

                Complexe c2 = new Complexe(r2, i2);

                Console.WriteLine($"\nLe second complexe est : {c2.AfficheComplexe()}");

                // Ajout du second au premier
                c1.Ajoute(c2);

                Console.WriteLine($"\nLe premier complexe devient : {c1.AfficheComplexe()} après ajout du second.");

                Console.WriteLine("\nUn autre test ? (Tapez sur espace)");
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                    break;

                Console.WriteLine("\n------------------------------------------\n");
            }
        }
    }

}
