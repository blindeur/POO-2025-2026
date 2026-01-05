using System;
using System.Collections.Generic;
using System.Text;

namespace ACT00_REVISION
    {
        public struct Utilitaires
        {
            public static double LireDouble(string question)
            {
                double valeur;
                bool ok;
                do
                {
                    Console.Write(question);
                    string saisie = Console.ReadLine();
                    ok = double.TryParse(saisie, out valeur);
                    if (!ok)
                    {
                        Console.WriteLine("Erreur : veuillez entrer une valeur entiere");
                    }
                } while (!ok);

                return valeur;
            }

            public static void ChangerCouleurs(ConsoleColor fond, ConsoleColor texte)
            {
                Console.BackgroundColor = fond;
                Console.ForegroundColor = texte;
                Console.Clear();
            }
        }
    }

