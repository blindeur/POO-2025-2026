namespace AmauryPOOEntrainement
{
        public class Programme
        {
            public static void Main()
            {
                // Création d’un tableau d’entraînements
                Entrainement[] entrainements = new Entrainement[3];

                entrainements[0] = new Entrainement("Alice Dupont", 10, 2700);  // 45 min
                entrainements[1] = new Entrainement("Bob Martin", 10, 2500);    // 41 min 40 s
                entrainements[2] = new Entrainement("Charlie Leroy", 10, 3000); // 50 min

                // Affichage des informations
                Console.WriteLine("=== Liste des entraînements ===");
                foreach (Entrainement e in entrainements)
                {
                    Console.WriteLine(e.ToString());
                }

                // Meilleur temps arbitraire
                int meilleurTemps = 2400; // 40 minutes

                Console.WriteLine("\n=== Écart par rapport au meilleur temps ===");
                foreach (Entrainement e in entrainements)
                {
                    int ecart = e.DiffTempsParRapportAuPremier(meilleurTemps);
                    Console.WriteLine($"{e.ToString()} | Écart : {ecart} secondes");
                }
            }
        }
    }
    

