using System;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {


            // Demande des couleurs à l’utilisateur
            Console.WriteLine("Choisissez une couleur de fond (ex: Black, Blue, Green, Red, Yellow, White) : ");
            string saisieFond = Console.ReadLine();
            Console.WriteLine("Choisissez une couleur de texte (ex: Black, Blue, Green, Red, Yellow, White) : ");
            string saisieTexte = Console.ReadLine();

            // Conversion des choix en ConsoleColor
            ConsoleColor couleurFond;
            ConsoleColor couleurTexte;

            if (!Enum.TryParse(saisieFond, true, out couleurFond))
                couleurFond = ConsoleColor.Black;

            if (!Enum.TryParse(saisieTexte, true, out couleurTexte))
                couleurTexte = ConsoleColor.White;

            // Application des couleurs choisies
            Utilitaires.ChangerCouleurs(couleurFond, couleurTexte);

            MethodesDuProjet mesOutils = new MethodesDuProjet(); // création d'une instance de la classe MethodesDuProjet pour utiliser ses méthodes
           // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE

            string rep;
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;
            bool oui = true;
            string infosTriangle;

            do
            {
                // Lecture sécurisée des côtés avec Utilitaires.LireDouble
                c1 = Utilitaires.LireDouble("Tapez la valeur du côté 1 : ");
                c2 = Utilitaires.LireDouble("Tapez la valeur du côté 2 : ");
                c3 = Utilitaires.LireDouble("Tapez la valeur du côté 3 : ");

                mesOutils.OrdonneCotes(ref c1, ref c2, ref c3);

                //Test si triangle
                if (mesOutils.Triangle(c1, c2, c3))
                {
                    mesOutils.PrepareAffichage(true, "triangle", out infosTriangle);
                    Console.WriteLine(infosTriangle);

                    // Test équilatéral
                    if (mesOutils.Equi(c1, c2, c3))
                    {
                        mesOutils.PrepareAffichage(true, "equilateral", out infosTriangle);
                        Console.WriteLine(infosTriangle);
                    }
                    else
                    {
                        // Test rectangle
                        if (mesOutils.TriangleRectangle(c1, c2, c3))
                        {
                            mesOutils.PrepareAffichage(true, "rectangle", out infosTriangle);
                            Console.WriteLine(infosTriangle);
                        }
                        else
                        {
                            mesOutils.PrepareAffichage(false, "rectangle", out infosTriangle);
                            Console.WriteLine(infosTriangle);
                        }

                        // Test isocèle
                        if ((c1 == c2) || (c1 == c3) || (c2 == c3))
                        {
                            mesOutils.PrepareAffichage(true, "isocele", out infosTriangle);
                            Console.WriteLine(infosTriangle);
                        }
                        else
                        {
                            mesOutils.PrepareAffichage(false, "isocele", out infosTriangle);
                            Console.WriteLine(infosTriangle);
                        }
                    }
                }
                else
                {
                    mesOutils.PrepareAffichage(false, "triangle", out infosTriangle);
                    Console.WriteLine(infosTriangle);
                }

                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace pour continuer)");
                rep = Console.ReadLine();
            } while (rep == " ");
            static double lireDouble(int numeroCote)
            {
                double cote;
                Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
                cote = double.Parse(Console.ReadLine());
                return cote;
            }
        }
    }
}
