using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioVersion1.classes
{
    public class Bibliotheque
    {
        private List<Livre> _contenu;
        public List<Livre> Contenu { get { return _contenu; } }
        private List<Emprunt> _emprunts;

        public List<Emprunt> Emprunts
        {
            get { return _emprunts; }
            set { _emprunts = value; }
        }
        private List<Abonne> _abonnes;

        public List<Abonne> Abonnes
        {
            get { return _abonnes; }
            set { _abonnes = value; }
        }
        //

        public Bibliotheque()
        {
            DataSet contenuTable = new DataSet();
            // DataManager dataManager = new DataManager();
            _abonnes = new List<Abonne>();
            _contenu = new List<Livre>();
            _emprunts = new List<Emprunt>();


            if (DataManager.ChercheContenuTable("abonnes", out contenuTable))
            {
                for (int i = 0; i < contenuTable.Tables[0].Rows.Count; i++)
                {
                    Abonne unAbonne = new Abonne((int)contenuTable.Tables[0].Rows[i]["id"],
                    contenuTable.Tables[0].Rows[i]["nom"].ToString(),
                    contenuTable.Tables[0].Rows[i]["prenom"].ToString(),
                    contenuTable.Tables[0].Rows[i]["email"].ToString());
                    contenuTable.Tables[0].Rows[i]["login"].ToString();
                    contenuTable.Tables[0].Rows[i]["motDePasse"].ToString();


                    _abonnes.Add(unAbonne);
                }
                if (DataManager.ChercheContenuTable("livres", out contenuTable))
                {
                    for (int i = 0; i < contenuTable.Tables[0].Rows.Count; i++)
                    {
                        Livre unlivre = new Livre((int)contenuTable.Tables[0].Rows[i]["id"],
                            contenuTable.Tables[0].Rows[i]["titre"].ToString(),
                            contenuTable.Tables[0].Rows[i]["prenom"].ToString(),
                            contenuTable.Tables[0].Rows[i]["nom"].ToString(),
                           (int)contenuTable.Tables[0].Rows[i]["annee_Parution"],
                           (int)contenuTable.Tables[0].Rows[i]["etat"]);

                        _contenu.Add(unlivre);
                    }
                }
            }
            if (DataManager.ChercheContenuTable("emprunts", out contenuTable))
            {
                for (int i = 0; i < contenuTable.Tables[0].Rows.Count; i++)
                {
                    Livre livreEmprunte;
                    if (methodeDuProjet.TrouveLivreAvecId((int)contenuTable.Tables[0].Rows[i]["idLivre"], _contenu, out livreEmprunte))
                    {
                        Abonne emprunteur;
                        if (methodeDuProjet.TrouveAbonneAvecId((int)contenuTable.Tables[0].Rows[i]["idAbonne"], _abonnes, out emprunteur))
                        {
                            Emprunt unEmprunt = new Emprunt((int)contenuTable.Tables[0].Rows[i]["idEmprunt"],
                                                            livreEmprunte,
                                                            (DateTime)contenuTable.Tables[0].Rows[i]["dateEmprunt"],
                                                            emprunteur);

                            _emprunts.Add(unEmprunt);
                        }
                    }


                }

            }
        }




        //DataRow row = contenuTable.Tables[0].Rows[i];
        //_contenu.Add(new Livre(row["titre"].ToString(), row["auteur"].ToString(), Convert.ToInt32(row["etat"])));




        //



        public void Ajoute(Livre livre)
        {
            _contenu.Add(livre);
        }

        public void Supprimer_livre_abimes()
        {
            for (int iLivre = 0; iLivre < _contenu.Count(); iLivre++)
            {
                Livre unLivre = _contenu[iLivre];

                if (unLivre.Etat < 1)
                {
                    _contenu.Remove(unLivre);
                    iLivre--;
                }
            }
        }
        public string Inventaire()
        {
            string contenuBiblio = "";
            for (int iLivre = 0; iLivre < _contenu.Count(); iLivre++)
            {
                contenuBiblio += _contenu[iLivre].Description();
            }
            return contenuBiblio;
        }
        public string CreeAbonne(string nom, string prenom, string email)
        {
            string info = "";
            //DataManager dataManager = new DataManager();
            if (DataManager.AjouteAbonne(nom, prenom, email, "", "", out int id))
            {
                _abonnes.Add(new Abonne(id, nom, prenom, email));
                info = "L'utilisateur a bien était ajouté a la BDD";

            }
            else
            {
                info = "Nous avons rencontré un probleme avec la BDD";
            }
            return info;

        }
        public void AjouteEmpruntLivre(int id, Livre livre, Abonne abonne, DateTime dateEmprunt)
        {
            _emprunts.Add(new Emprunt(id, livre, dateEmprunt, abonne));
        }
        public string NotifieRetourLivre(Emprunt emprunt, DateTime dateRetour)
        {
            emprunt.DateRetour = dateRetour;
            return "\nRetour enregistré !";
        }
        public string ListeEmprunts()
        {
            string livresEmpruntes = "\n";
            for (int iLivre = 0; iLivre < _emprunts.Count(); iLivre++)
            {
                livresEmpruntes += _emprunts[iLivre].LivreEmprunte.Description() + " emprunté par " + _emprunts[iLivre].infos();
            }
            return livresEmpruntes;
        }
        public string ListeAbonnes()
        {
            string infosAbonnes = "\n";
            for (int iAbonne = 0; iAbonne < _abonnes.Count(); iAbonne++)
            {
                infosAbonnes += _abonnes[iAbonne].Infos();
            }
            return infosAbonnes;
        }
    }
}
