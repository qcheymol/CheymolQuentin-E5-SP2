using MySql.Data.MySqlClient;
using Biblio_gsb;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace Biblio_BD
{
    public class DBconnect
    {
        #region Base de données
        public static MySqlConnection Connexion;

        public static MySqlConnection OuvertureConnexion()
        {


            if (Connexion != null)
            {
                return Connexion;
            }
            else
            {
                string connectionString;
                connectionString = "SERVER=localhost;DATABASE=gsbc;UID=root;PASSWORD='';";
                Connexion = new MySqlConnection(connectionString);
                Connexion.Open();
                return Connexion;
            }
        }

        public static void FermetureConnexion()
        {
            Connexion.Close();
        }

        public static void ExecutionMaj(string req)
        {   // type de maj : insertion, suppression, modification
            MySqlCommand cmdMaj = new MySqlCommand(req, Connexion);
            cmdMaj.ExecuteNonQuery();
        }
        #endregion

        #region Medecin
        public static Medecin GetMedecin(int Index)
        {
            Medecin medecin = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM medecin WHERE idMedecin = " + Index + ";";
            DbDataReader reader = dbc.ExecuteReader();
            String nom_personne = "", prenom_personne = "", adresse_personne = "", tel = "", departement = "";
            int id_personne = 0, idspe = 0;
            Specialite laSpecialite;
            if (reader.Read())
            {


                // récupération des informations du médecin
                id_personne = (int)reader[0];
                nom_personne = (String)reader[1];
                prenom_personne = (String)reader[2];
                adresse_personne = (String)reader[3];
                tel = (String)reader[4];
                departement = (String)reader[5];
                idspe = (int)reader[6];

            }

            reader.Close();
            // Récupération de laSpecialite
            dbc.CommandText = "SELECT * FROM specialite WHERE idSpecialite = " + idspe;
            reader = dbc.ExecuteReader();
            reader.Read();
            laSpecialite = new Specialite((int)reader["idSpecialite"], (String)reader["libelle"]);
            reader.Close();
            // instanciation du médecin
            medecin = new Medecin(id_personne, nom_personne, prenom_personne, adresse_personne, tel, departement, laSpecialite);

            return medecin;

        }

        public static Rapport GetRapport(int Index)
        {
            Rapport rapport = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM rapport WHERE idRapport = " + Index + ";";
            DbDataReader reader = dbc.ExecuteReader();
            DateTime date = new DateTime();
            String motif = "", bilan = "";
            int id_rapport = 0, idmedecin = 0, idvisiteur = 0;
            Visiteur leVisiteur;
            Medecin leMedecin;
            if (reader.Read())
            {
                // récupération des informations du rapport
                id_rapport = (int)reader[0];
                date = (DateTime)reader[1];
                motif = (String)reader[2];
                bilan = (String)reader[3];
                idmedecin = (int)reader[4];
                idvisiteur = (int)reader[5];

            }
            reader.Close();
            dbc.CommandText = "SELECT * FROM medecin WHERE idMedecin = " + idmedecin;
            reader = dbc.ExecuteReader();
            reader.Read();
            leMedecin = new Medecin((int)reader["idMedecin"], (String)reader["nom"], (String)reader["prenom"], (String)reader["adresse"], (String)reader["tel"], (String)reader["departement"], (Specialite)reader["idSpecialite"]);
            reader.Close();
            dbc.CommandText = "SELECT * FROM visiteur WHERE idVisiteur = " + idvisiteur;
            reader = dbc.ExecuteReader();
            reader.Read();
            leVisiteur = new Visiteur((int)reader["idVisiteur"], (String)reader["nom"], (String)reader["prenom"], (String)reader["login"], (String)reader["mdp"], (String)reader["adresse"], (int)reader["cp"], (String)reader["ville"], (DateTime)reader["dateEmbauche"]);
            reader.Close();
            reader = dbc.ExecuteReader();
            reader.Read();
            reader.Close();
            // instanciation du rapport
            rapport = new Rapport(id_rapport, date, motif, bilan, leMedecin, leVisiteur);

            return rapport;
        }
        public static List<Medecin> GetMedecins()
        {
            // liste de médecins
            List<Medecin> liste = new List<Medecin>();
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL qui récupère tous les médecin, triés par nom 
            dbc.CommandText = "SELECT idmedecin, nom, prenom, adresse, tel, departement, M.idSpecialite, libelle FROM medecin M inner join specialite S on S.idspecialite = M.idspecialite";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                // ajoute le médecin à la liste
                Specialite laSpecialite = new Specialite((int)reader[6], (String)reader[7]);
                Medecin medecin = new Medecin((int)reader[0], (String)reader[1], (String)reader[2], (String)reader[3], (String)reader[4], (String)reader[5], laSpecialite);
                liste.Add(medecin);
            }
            reader.Close();
            return liste;
        }

        public static Medecin AjouterUnMedecin(string nom, string prenom, string adresse, string tel, string departement, int idSpecialite)
        {
            Medecin medecin = new Medecin();
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL 
            dbc.CommandText = "INSERT INTO medecin (nom, prenom, adresse, tel, departement, idSpecialite) VALUES ('" + nom + "', '" + prenom + "', '" + adresse + "', '" + tel + "', " + departement + "," + idSpecialite + ")";
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();
            return medecin;

        }

        public static Medecin UpdateUnMedecin(int Index, string nom, string prenom, string adresse, string tel, string departement, int idSpecialite)
        {
            Medecin medecin = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL
            dbc.CommandText = "UPDATE medecin SET nom = '" + nom + "' , prenom = '" + prenom + "' , adresse = '" + adresse + "', tel = '" + tel + "' , departement = '" + departement + "' , idSpecialite = '" + idSpecialite + "' WHERE idMedecin =  " + Index + ";";
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();
            return medecin;

        }

        public static Medecin DeleteUnMedecin(int id)
        {
            Medecin medecin = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL 
            dbc.CommandText = "DELETE FROM medecin WHERE idMedecin = " + id + "";
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();
            return medecin;

        }

        #endregion

        #region Specialite
        public static List<Specialite> GetSpecialites()
        {
            List<Specialite> liste = new List<Specialite>();
            DbCommand dbc = OuvertureConnexion().CreateCommand();

            dbc.CommandText = "SELECT IdSpecialite, libelle FROM specialite";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                Specialite laSpecialite = new Specialite((int)reader[0], (String)reader[1]);
                liste.Add(laSpecialite);
            }
            reader.Close();
            return liste;
        }

        public static List<Medicament> GetMedicaments()
        {
            // liste de Medicament
            List<Medicament> liste = new List<Medicament>();
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL qui récupère tous les Medicament, triés par nom 
            dbc.CommandText = "SELECT idMedicament, nomCommercial, composition, effets, contreIndications, S.idFamille, libelle, PrixUnitaire FROM medicament M inner join famille S on S.idFamille = M.idFamille";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {

                Famille laFamille = new Famille((int)reader[5], (string)reader[6]);
                Medicament medicament = new Medicament((int)reader[0], (String)reader[1], (String)reader[2], (String)reader[3], (String)reader[4], (int)reader[7], laFamille);
                liste.Add(medicament);
            }
            reader.Close();
            return liste;
        }

        public static Medicament GetMedicament(int Index)
        {
            // liste de Medicament
            Medicament medicament = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL qui récupère tous les Medicament, triés par nom 
            dbc.CommandText = "SELECT idMedicament, nomCommercial, composition, effets, contreIndications, S.idFamille, libelle, PrixUnitaire FROM medicament M inner join famille S on S.idFamille = M.idFamille WHERE idMedicament=" + Index + "";
            DbDataReader reader = dbc.ExecuteReader();
            if (reader.Read())
            {

                Famille laFamille = new Famille((int)reader[5], (string)reader[6]);
                medicament = new Medicament((int)reader[0], (String)reader[1], (String)reader[2], (String)reader[3], (String)reader[4], (int)reader[7], laFamille);

            }
            reader.Close();
            return medicament;
        }

        #endregion

        public static List<Visiteur> GetVisiteurs()
        {
            List<Visiteur> liste = new List<Visiteur>();
            DbCommand dbc = OuvertureConnexion().CreateCommand();

            dbc.CommandText = "SELECT idVisiteur, nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche FROM visiteur";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                Visiteur leVisiteur = new Visiteur((int)reader[0], (String)reader[1], (String)reader[2], (String)reader[3], (String)reader[4], (String)reader[5], (int)reader[6], (String)reader[7], (DateTime)reader[8]);
                liste.Add(leVisiteur);
            }
            reader.Close();
            return liste;
        }

        public static List<Rapport> GetRapports()
        {
            List<Rapport> liste = new List<Rapport>();
            DbCommand dbc = OuvertureConnexion().CreateCommand();

            dbc.CommandText = "SELECT idRapport, date, motif, bilan, idVisiteur, idMedecin FROM rapport";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                Medecin lemedecin = new Medecin((int)reader[4], (String)reader[5], (String)reader[6], (String)reader[7], (String)reader[8], (String)reader[9], (Specialite)reader[10]);
                Visiteur levisiteur = new Visiteur((int)reader[11], (String)reader[12], (String)reader[13], (String)reader[14], (String)reader[15], (String)reader[16], (int)reader[17], (String)reader[18], (DateTime)reader[19]);
                Rapport leRapport = new Rapport((int)reader[0], (DateTime)reader[1], (String)reader[2], (String)reader[3], lemedecin, levisiteur);
                liste.Add(leRapport);
            }
            reader.Close();
            return liste;
        }

        
            public static Rapport AjouterUnRapport(string Date,string Motif,string Bilan,Visiteur Visiteur, Medecin Medecin)
        {
            Rapport rapport = new Rapport();
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL 
            dbc.CommandText = "INSERT INTO rapport (date, motif, bilan, idVisiteur, idmedecin) VALUES ('" + Date + "', '" + Motif + "', '" + Bilan + "', '" + Visiteur + "', " + Medecin + ")";
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();
            return rapport;
        }

        public static Rapport UpdateUnRapport(int Index, DateTime date, string motif, string bilan, int idVisiteur , int idMedecin)
        {
            Rapport rapport = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL
            dbc.CommandText = "UPDATE rapport SET date = '" + date + "' , motif = '" + motif + "' , bilan = '" + bilan + "', idVisiteur = '" + idVisiteur + "' , idMedecin = " + idMedecin + " WHERE idRapport =  " + Index + ";";
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();
            return rapport;

        }

        public static Rapport DeleteUnRapport(int id)
        {
            Rapport rapport = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL 
            dbc.CommandText = "DELETE FROM rapport WHERE idRapport = " + id + "";
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();
            return rapport;

        }

        public static Visiteur GetVisiteur(int Index)
        {
            Visiteur visiteur = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM visiteur WHERE idVisiteur = " + Index + ";";
            DbDataReader reader = dbc.ExecuteReader();
            String nom_personne = "", prenom_personne = "", adresse_personne = "", login = "", mdp = "", ville = "";
            int id_personne = 0, cp = 0;
            DateTime dateEmbauche;
            if (reader.Read())
            {


                // récupération des informations du médecin
                id_personne = (int)reader[0];
                nom_personne = (String)reader[1];
                prenom_personne = (String)reader[2];
                login = (String)reader[3];
                mdp = (String)reader[4];
                adresse_personne = (String)reader[5];
                cp = (int)reader[6];
                ville = (String)reader[7];
                dateEmbauche = (DateTime)reader[8];


            }

            reader.Close();
            // instanciation du médecin
            visiteur = new Visiteur(id_personne, nom_personne, prenom_personne, login, mdp, adresse_personne,cp, ville, dateEmbauche);

            return visiteur;

        }

        public static Medicament AjouterUnMedicament(string effets, string NomCommercial, string contreIndications, string Composition, int idFamille, int PrixUnitaire)
        {
            Medicament medicament = new Medicament();
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL 
            dbc.CommandText = "INSERT INTO medicament (effets, NomCommercial, contreIndications, Composition, idFamille, PrixUnitaire) VALUES ('" + effets + "', '" + NomCommercial + "', '" + contreIndications + "', '" + Composition + "','" + idFamille + "','" + PrixUnitaire + "')";
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();
            return medicament;
        }

        public static List<Famille> GetFamilles()
        {
            List<Famille> liste = new List<Famille>();
            DbCommand dbc = OuvertureConnexion().CreateCommand();

            dbc.CommandText = "SELECT idFamille, libelle FROM famille";
            DbDataReader reader = dbc.ExecuteReader();
            while (reader.Read())
            {
                Famille laFamille = new Famille((int)reader[0], (String)reader[1]);
                liste.Add(laFamille);
            }
            reader.Close();
            return liste;
        }

        public static Medicament DeleteUnMedicament(int id)
        {
            Medicament medicament = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL 
            dbc.CommandText = "DELETE FROM medicament WHERE idMedicament = " + id + "";
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();
            return medicament;

        }

        public static Medicament UpdateUnMedicament(int Index, string effets, string nomCommercial, string composition, string contreIndications, int idFamille, int PrixUnitaire)
        {
            Medicament medicament = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL
            dbc.CommandText = "UPDATE medicament SET effets = '" + effets + "' , nomCommercial = '" + nomCommercial + "' , composition = '" + composition + "', contreIndications = '" + contreIndications + "' , idFamille = '" + idFamille + "' , PrixUnitaire = '" + PrixUnitaire + "' WHERE idMedicament =  " + Index + ";";
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();
            return medicament;

        }
    }
}
