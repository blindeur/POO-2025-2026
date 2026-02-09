namespace AmauryPOOBiblioV2
{

    using System;

    class Program
    {
        static void Main()
        {
            Bibliotheque bibliotheque = new Bibliotheque();
            ConsoleKey choix;
            

            do
            {
                Console.Clear();
                Console.WriteLine("===== MENU BIBLIOTHÈQUE =====");
                Console.WriteLine("1 - Ajouter un livre");
                Console.WriteLine("2 - Afficher l'inventaire");
                Console.WriteLine("3 - Créer un abonné");
                Console.WriteLine("4 - Afficher les abonnés");
                Console.WriteLine("5 - Emprunter un livre");
                Console.WriteLine("6 - Afficher les emprunts");
                Console.WriteLine("7 - Supprimer les livres abîmés");
                Console.WriteLine("0 - Quitter");
                Console.Write("\nChoix : ");

                choix = Console.ReadKey().Key;


                switch (choix)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1: AjouterLivre(bibliotheque); break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2: AfficherInventaire(bibliotheque); break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3: CreerAbonne(bibliotheque); break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4: AfficherAbonnes(bibliotheque); break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5: EmprunterLivre(bibliotheque); break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6: AfficherEmprunts(bibliotheque); break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7: bibliotheque.SupprimeLivresAbimes(); Pause("Livres supprimés"); break;
                }

            } while (choix != 0);
        }

        static void AjouterLivre(Bibliotheque b)
        {
            Console.Write("Titre : ");
            string titre = Console.ReadLine();

            Console.Write("Auteur : ");
            string auteur = Console.ReadLine();

            Console.Write("État (0 neuf, 1 bon, 2 abîmé) : ");
            byte etat = byte.Parse(Console.ReadLine());

            b.Ajoute(new Livre(titre, auteur, etat));
            Pause("Livre ajouté");
        }

        static void CreerAbonne(Bibliotheque b)
        {
            Console.Write("Nom : ");
            string nom = Console.ReadLine();

            Console.Write("Prénom : ");
            string prenom = Console.ReadLine();

            Console.Write("Email : ");
            string email = Console.ReadLine();

            b.CreeAbonne(nom, prenom, email);
            Pause("Abonné créé");
        }

        static void EmprunterLivre(Bibliotheque b)
        {
            Console.WriteLine(b.Inventaire());
            Console.Write("Index du livre : ");
            int iLivre = int.Parse(Console.ReadLine());

            Console.WriteLine(b.ListeAbonnes());
            Console.Write("Index de l'abonné : ");
            int iAbonne = int.Parse(Console.ReadLine());

            Console.Write("Durée (jours) : ");
            int jours = int.Parse(Console.ReadLine());

            b.AjouteEmpruntLivre(b.Livres[iLivre], b.Abonnes[iAbonne], DateTime.Now.AddDays(jours));
            Pause("Emprunt enregistré");
        }

        static void AfficherInventaire(Bibliotheque b)
        {
            Console.WriteLine(b.Inventaire());
            Pause();
        }

        static void AfficherAbonnes(Bibliotheque b)
        {
            Console.WriteLine(b.ListeAbonnes());
            Pause();
        }

        static void AfficherEmprunts(Bibliotheque b)
        {
            Console.WriteLine(b.ListesEmprunts());
            Pause();
        }

        static void Pause(string message = "")
        {
            if (message != "")
                Console.WriteLine(message);

            Console.WriteLine("\nAppuyez sur une touche...");
            Console.ReadKey();
        }
    }
}