namespace Amaury_POO_ACT_8__Ex_Héritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe[] employes = new Employe[3];

            employes[0] = new Ouvrier()
            {
                Nom = "Dupont",Prenom = "Jean",Salaire = 2000,Specialite = "Soudure",DateEntreSociete = new DateTime(2015, 1, 1)
            };

            employes[1] = new Cadre()
            {
                Nom = "Martin",Prenom = "Paul",Indice = 2
            };

            employes[2] = new Directeur()
            {
                Nom = "Durand",Prenom = "Luc",Salaire = 5000,ChiffreAffaire = 100000,Pourcentage = 0.05
            };

            foreach (Employe e in employes)
            {
                e.Afficher();
                Console.WriteLine("--------------------");
            }
        }
    }
}
