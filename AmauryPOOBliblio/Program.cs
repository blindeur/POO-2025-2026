namespace AmauryPOOBliblio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création des livres
            Livre livre1 = new Livre("1984", "George Orwell", 3);
            Livre livre2 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", 1);
            Livre livre3 = new Livre("Germinal", "Émile Zola", 5);

            // Création de la bibliothèque
            Bibliotheque biblio = new Bibliotheque();

            // Ajout des livres
            biblio.ajoute(livre1);
            biblio.ajoute(livre2);
            biblio.ajoute(livre3);

            // Inventaire initial
            biblio.inventaire();

            // Dégradation de livres
            livre2.degrade();
            livre2.degrade(); // état passe à 0

            // Suppression des livres abîmés
            biblio.supprime_livres_abimes();

            // Inventaire final
            biblio.inventaire();

            Console.ReadLine();
        }
    }
}

