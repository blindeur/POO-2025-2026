using BiblioVersion1.classes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BiblioVersion1
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int id;
            //methodeDuProjet Outils = new methodeDuProjet();
            Bibliotheque biblio = new Bibliotheque();
            do
            {
                Console.Clear();
                Console.WriteLine("L: Créer un livre\n" +
                        "B: Créer un abonné\n" +
                        "A: Afficher les abonnés\n" +
                        "D: Dégrader un livre\n" +
                        "S: Supprimer les livres abimés\n" +
                        "I: Afficher les livres se trouvant dans la bibliothèque\n" +
                        "C: Créer un emprunt \n" +
                        "E: Afficher les livres empruntés \n" +
                        "R: Rendre un livre"
                    );
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.L:

                        string titre = "";
                        string prenomAuteur = "";
                        string nomAuteur = "";
                        int anneeDeParution;
                        int etat = 5;

                        Console.WriteLine("\nTitre du livre:");
                        titre = Console.ReadLine();
                        Console.WriteLine("Prénom de l'auteur du livre:");
                        prenomAuteur = Console.ReadLine();
                        Console.WriteLine("Nom del'auteur du livre:");
                        nomAuteur = Console.ReadLine();
                        Console.WriteLine("Année de Parution du livre:");
                        anneeDeParution = int.Parse(Console.ReadLine());
                        Console.WriteLine("Quelle est l'etat du livre de 1-5 : ");
                        etat = int.Parse(Console.ReadLine());


                        Livre livreExistant;
                        if (!methodeDuProjet.TrouveLivre(titre, biblio.Contenu, out livreExistant))
                        {
                            // mettre dans la base de données
                            if (DataManager.AjouteLivre(prenomAuteur, nomAuteur, titre, anneeDeParution, etat, out  id))
                            {
                                biblio.Contenu.Add(new Livre(id,titre, prenomAuteur, nomAuteur, anneeDeParution, etat));
                                Console.WriteLine("livre créé");
                            }                            
                        }
                        else
                        {
                            Console.WriteLine("Ce livre existe déjà dans la bibliothèque !");
                        }

                        break;
                    case ConsoleKey.B:
                     
                        string nom = "";
                        string prenom = "";
                        string email = "";
                        string login = "";
                        string motDePasse = "";

                        Console.WriteLine("\nNom de l'abonné :");
                        nom = Console.ReadLine();
                        Console.WriteLine("Prénom de l'abonné :");
                        prenom = Console.ReadLine();
                        Console.WriteLine("email de l'abonné :");
                        email = Console.ReadLine();
                        Console.WriteLine("login de l'abonné :");
                        login = Console.ReadLine();
                        Console.WriteLine("password de l'abonné :");
                        motDePasse = Console.ReadLine();

                        Abonne abonneExistant;
                        if (!methodeDuProjet.TrouveAbonne(nom, biblio.Abonnes, out abonneExistant))
                        {
                           Console.WriteLine(biblio.CreeAbonne(nom, prenom,""));
                            Console.WriteLine("Abonné enregistré !");
                        }
                        else
                        {
                            Console.WriteLine("L'abonné existe déjà");
                        }

                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("\n" + biblio.ListeAbonnes());
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("\n" + biblio.Inventaire());
                        Console.WriteLine("Titre du livre qui est dégradé :");
                        titre = Console.ReadLine();
                        Livre livreADegrader;
                        if (methodeDuProjet.TrouveLivre(titre, biblio.Contenu, out livreADegrader))
                        {
                            livreADegrader.Degrade();
                            Console.WriteLine("Mise à jour de l'état effectuée !");
                        }
                        else
                        {
                            Console.WriteLine("Ce livre n'est pas dans la bibliothèque !");
                        }
                        break;
                    case ConsoleKey.S:
                        biblio.Supprimer_livre_abimes();
                        Console.WriteLine("\nLivres abimés supprimés !");
                        break;
                    case ConsoleKey.I:
                        Console.WriteLine("\n" + biblio.Inventaire());
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine("\nChoisissez un livre \n");
                        Console.WriteLine("\n" + biblio.Inventaire());
                        int numero =  methodeDuProjet.lireEntier("Numéro du livre que vous désirez emprunter :");
                        Livre livreAEmprunter;
                        if (methodeDuProjet.TrouveLivreAvecId(numero, biblio.Contenu, out livreAEmprunter))
                        {
                            Console.WriteLine("\nListe des abonnés : \n "+ biblio.ListeAbonnes());
                            numero = methodeDuProjet.lireEntier("Quel abonné veut l'emprunter ? Taper son numéro.");
                            Abonne emprunteur;
                            if (methodeDuProjet.TrouveAbonneAvecId(numero, biblio.Abonnes, out emprunteur))
                            {   
                                if (DataManager.AjouteEmprunt(livreAEmprunter.Id, emprunteur.Id, DateTime.Today, out  id))
                                {
                                    biblio.AjouteEmpruntLivre(id,livreAEmprunter, emprunteur, DateTime.Today);

                                    Console.WriteLine("Emprunt enregistré !");
                                }                                                              
                            }
                            else
                            {
                                Console.WriteLine("L'abonné n'existe pas");
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Ce livre n'est pas dans la bibliothèque !");
                        }
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("\nListe des emprunts : \n" + biblio.ListeEmprunts());
                        break;
                    case ConsoleKey.R:
                        Console.WriteLine("\nTitre du livre qui rentre :");
                        titre = Console.ReadLine();
                        Emprunt emprunt;
                        if (methodeDuProjet.TrouveEmprunt(titre, biblio.Emprunts, out emprunt))
                        {
                            Console.WriteLine(biblio.NotifieRetourLivre(emprunt, DateTime.Today));
                            
                        }
                        else
                        {
                            Console.WriteLine("Ce livre n'est pas dans la bibliothèque !");
                        }
                        Console.WriteLine("\n");
                        break;
                    default:
                        break;
                }
                Console.Write("Appuyez sur une touche pour continuer !");
                Console.ReadLine();
                //    Console.WriteLine("\nAppuyez sur espace pour recommencer");
                //} while (Console.ReadKey().Key == ConsoleKey.Spacebar);
            } while (true);
        }
       
    }
}
