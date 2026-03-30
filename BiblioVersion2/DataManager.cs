using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BiblioVersion1
{
    public static class DataManager
    {


        public static string DefinirCheminBD() // détermine la chaîne de connexion
        {
            return "server=10.10.51.98;database=biblio;port=3306;User Id=Amaury;password=root";  //mysql:host=10.10.51.98;dbname=biblio
        }


        public static bool ChercheContenuTable(string table, out DataSet contenuTable)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnection.Open();

                query = "SELECT * FROM " + table + ";";

                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnection);
                contenuTable = new DataSet();
                da.Fill(contenuTable, "infoTable");

                maConnection.Close();

                if (contenuTable.Tables[0].Rows.Count >= 1)
                {
                    ok = true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }
            return ok;
        }


        public static bool AjouteAbonne(string prenom, string nom, string email, string login, string motDePasse, out int id)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            string query = "";
            id = 1;
            try
            {
                maConnection.Open();

                query = "INSERT INTO abonnes (nom, prenom, email, login, motDePasse) values (@nom, @prenom, @email, @login, @motDePasse);";

                MySqlCommand insertCommand = new MySqlCommand(query, maConnection);

                insertCommand.Parameters.AddWithValue("@nom", nom);
                insertCommand.Parameters.AddWithValue("@prenom", prenom);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@login", "");
                insertCommand.Parameters.AddWithValue("@motDePasse", "");

                // Ajout des données à la source de données
                if (insertCommand.ExecuteNonQuery() > 0)
                {
                    ok = true;
                    id = (int)insertCommand.LastInsertedId;
                }
                maConnection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }

            return ok;
        }
        public static bool AjouteLivre(string prenomAuteur, string nomAuteur, string titre, int anneeDeParution, int etat, out int id)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            string query = "";
            id = 1;
            try
            {
                maConnection.Open();

                query = "INSERT INTO livres (nom, prenom, titre, annee_parution, etat) values (@nom, @prenom, @titre, @annee_parution, @etat);";

                MySqlCommand insertCommand = new MySqlCommand(query, maConnection);

                insertCommand.Parameters.AddWithValue("@nom", nomAuteur);
                insertCommand.Parameters.AddWithValue("@prenom", prenomAuteur);
                insertCommand.Parameters.AddWithValue("@titre", titre);
                insertCommand.Parameters.AddWithValue("@annee_parution", anneeDeParution);
                insertCommand.Parameters.AddWithValue("@etat", etat);

                // Ajout des données à la source de données
                if (insertCommand.ExecuteNonQuery() > 0)
                {
                    ok = true;
                    id = (int)insertCommand.LastInsertedId;
                }
                maConnection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }

            return ok;
        }
        public static bool AjouteEmprunt(int idLivre, int idAbonne, DateTime dateEmprunt,  out int id)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            string query = "";
            id = 1;
            try
            {
                maConnection.Open();
                query = "INSERT INTO emprunts (idLivre, idAbonne, dateEmprunt, dateRetour) values (@idLivre, @idAbonne, @dateEmprunt, @dateRetour);";
                MySqlCommand insertCommand = new MySqlCommand(query, maConnection);
              
                insertCommand.Parameters.AddWithValue("@idLivre", idLivre);
                insertCommand.Parameters.AddWithValue("@idAbonne", idAbonne);
                insertCommand.Parameters.AddWithValue("@dateEmprunt", dateEmprunt);
                insertCommand.Parameters.AddWithValue("@dateRetour", null);

                // Ajout des données à la source de données
                if (insertCommand.ExecuteNonQuery() > 0)
                {
                    ok = true;
                    id = (int)insertCommand.LastInsertedId;
                }
                maConnection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }
            return ok;
        }


    }
}
   
