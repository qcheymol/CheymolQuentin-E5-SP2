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
        public static Medecin GetMedecin(string NomMed)
        {
            Medecin medecin = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM medecin WHERE nom = '" + NomMed + "';";
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
            dbc.CommandText = "SELECT * FROM specialite WHERE idSpecialite = " + idspe + ";";
            reader = dbc.ExecuteReader();
            reader.Read();
            laSpecialite = new Specialite((int)reader["idSpecialite"], (String)reader["libelle"]);
            reader.Close();
            // instanciation du médecin
            medecin = new Medecin(id_personne, nom_personne, prenom_personne, adresse_personne, tel, departement, laSpecialite);

            return medecin;

        }

        public static Medecin GetMedecinParId(int idMed)
        {
            Medecin medecin = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM medecin INNER JOIN specialite ON medecin.idSpecialite = specialite.idSpecialite  WHERE idMedecin = '" + idMed + "';";
            DbDataReader reader = dbc.ExecuteReader();
            String nom_personne = "", prenom_personne = "", adresse_personne = "", tel = "", departement = "";
            Specialite laSpecialite = null;
            if (reader.Read())
            {

                // Récupération des informations du médecin
                idMed = (int)reader["idMedecin"];
                nom_personne = (string)reader["nom"];
                prenom_personne = (string)reader["prenom"];
                adresse_personne = (string)reader["adresse"];
                tel = (string)reader["tel"];
                departement = (string)reader["departement"];
                laSpecialite = new Specialite((int)reader["idSpecialite"], (string)reader["libelle"]);
            }

            reader.Close();
            // instanciation du médecin
            medecin = new Medecin(idMed, nom_personne, prenom_personne, adresse_personne, tel, departement, laSpecialite);

            return medecin;

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

        #region Medicament

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
            dbc.CommandText = "SELECT idMedicament, nomCommercial, composition, effets, contreIndications, S.idFamille, libelle, PrixUnitaire FROM medicament M inner join famille S on S.idFamille = M.idFamille WHERE nomCommercial=" + Index + "";
            DbDataReader reader = dbc.ExecuteReader();
            if (reader.Read())
            {

                Famille laFamille = new Famille((int)reader[5], (string)reader[6]);
                medicament = new Medicament((int)reader[0], (String)reader[1], (String)reader[2], (String)reader[3], (String)reader[4], (int)reader[7], laFamille);

            }
            reader.Close();
            return medicament;
        }

        public static Medicament GetMedicamentParId(int idMedicament)
        {
            Medicament medicament = null;
            Famille famille = null;

            DbCommand dbc = OuvertureConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM medicament INNER JOIN famille ON medicament.idFamille = famille.idFamille WHERE medicament.idMedicament = '" + idMedicament + "';";
            DbDataReader reader = dbc.ExecuteReader();
            string nomCommercial = "", composition = "", effets = "", contreIndications = "";
            int PrixUnitaire = 0;
            if (reader.Read())
            {

                // Récupération des informations du médicament
                idMedicament = (int)reader["idMedicament"];
                nomCommercial = (string)reader["nomCommercial"];
                composition = (string)reader["composition"];
                effets = (string)reader["effets"];
                contreIndications = (string)reader["contreIndications"];
                PrixUnitaire = (int)reader["PrixUnitaire"];
                famille = new Famille((int)reader["idFamille"], (string)reader["libelle"]);


            }
            reader.Close();
            medicament = new Medicament(idMedicament, nomCommercial, composition, effets, contreIndications, PrixUnitaire ,famille);
            return medicament;
        }

        public static Medicament GetMedicamentByNom(string nom)
        {
            Medicament medicament = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // Requête SQL qui récupère lemédicament par son nom
            dbc.CommandText = "SELECT * FROM medicament INNER JOIN famille ON medicament.idFamille = famille.idFamille WHERE nomCommercial = '" + nom + "'";
            DbDataReader reader = dbc.ExecuteReader();
            int id = 0;
            string nomCommercial = "", composition = "", effets = "", contreIndications = "";
            Famille famille = null;
            while (reader.Read())
            {
                id = (int)reader["idMedicament"];
                nomCommercial = (string)reader["nomCommercial"];
                composition = (string)reader["composition"];
                effets = (string)reader["effets"];
                contreIndications = (string)reader["contreIndications"];
                famille = new Famille((int)reader["idFamille"], (string)reader["libelle"]);

            }
            reader.Close();
            medicament = new Medicament(id, nomCommercial, composition, effets, contreIndications, famille);
            return medicament;
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

        public static Medicament UpdateUnMedicament(int Index, string effets, string nomCommercial, string composition, string contreIndications, int idFamille, int PrixUnitaire)
        {
            Medicament medicament = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL
            dbc.CommandText = "UPDATE medicament SET effets = '" + effets + "' , nomCommercial = '" + nomCommercial + "' , composition = '" + composition + "', contreIndications = '" + contreIndications + "' , idFamille = '" + idFamille + "' , PrixUnitaire = '" + PrixUnitaire + "' WHERE idMedicament = " + Index + "; ";
            
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();
            return medicament;

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

        #endregion

        #region Famille

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

        #endregion

        #region Offrir

        #endregion

        #region Rapport

         public static List<Rapport> GetRapports()
         {
             List<Rapport> liste = new List<Rapport>();
             DbCommand dbc = OuvertureConnexion().CreateCommand();

             dbc.CommandText = "SELECT idRapport, date, motif, bilan, v.nom, v.prenom, m.nom, m.prenom FROM (visiteur as v INNER Join (rapport as r INNER JOIN medecin as m on r.idMedecin = m.idMedecin) on v.idVisiteur = r.idVisiteur) ";
             DbDataReader reader = dbc.ExecuteReader();
             while (reader.Read())
             {
                 Medecin lemedecin = new Medecin((String)reader[4], (String)reader[5]);
                 Visiteur levisiteur = new Visiteur((String)reader[6], (String)reader[7]);
                 Rapport leRapport = new Rapport((int)reader[0], (DateTime)reader[1], (String)reader[2], (String)reader[3], levisiteur, lemedecin);
                 liste.Add(leRapport);
             }
             reader.Close();
             return liste;
         }

        public static Rapport GetRapport(int id)
        {
            Rapport rapport = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM rapport WHERE idRapport = " + id + ";";
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
                idvisiteur = (int)reader[4];
                idmedecin = (int)reader[5];

            }
            reader.Close();
            dbc.CommandText = "SELECT * FROM medecin WHERE idMedecin = '" + idmedecin + "';";
            reader = dbc.ExecuteReader();
            reader.Read();
            leMedecin = new Medecin((int)reader["idMedecin"], (String)reader["nom"], (String)reader["prenom"], (String)reader["adresse"], (String)reader["tel"], (String)reader["departement"]);
            reader.Close();
            dbc.CommandText = "SELECT * FROM visiteur WHERE idVisiteur = '" + idvisiteur + "';";
            reader = dbc.ExecuteReader();
            reader.Read();
            leVisiteur = new Visiteur((int)reader["idVisiteur"], (String)reader["nom"], (String)reader["prenom"], (String)reader["login"], (String)reader["mdp"], (String)reader["adresse"], (int)reader["cp"], (String)reader["ville"], (DateTime)reader["dateEmbauche"]);
            reader.Close();
            reader = dbc.ExecuteReader();
            reader.Read();
            reader.Close();
            // instanciation du rapport
            rapport = new Rapport(id_rapport, date, motif, bilan, leVisiteur, leMedecin );

            return rapport;
        }

        public static Rapport GetIdRapport(DateTime Date, int idVisiteur, int idMedecin)
        {
            Rapport rapport = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM rapport WHERE rapport.date = '" + Date.ToString("yyyy-MM-dd") + "' AND rapport.idVisiteur = '" + idVisiteur + "' AND rapport.idMedecin = '" + idMedecin + "';"; 
            DbDataReader reader = dbc.ExecuteReader();
            int id = 0;
            DateTime date = new DateTime();
            string motif = "", bilan = "";
            if (reader.Read())
            {
                id = (int)reader["idRapport"];
                date = (DateTime)reader["date"];
                motif = (string)reader["motif"];
                bilan = (string)reader["bilan"];
                idVisiteur = (int)reader["idVisiteur"];
                idMedecin = (int)reader["idMedecin"];
                
            }
            reader.Close();
            rapport = new Rapport(id, date, motif, bilan, idMedecin, idVisiteur);
            return rapport;

        }

            public static void AjouterUnRapport(Rapport rapport)
        {
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // Construction de la requête SQL INSERT
            dbc.CommandText = "INSERT INTO rapport (date, motif, bilan, idVisiteur, idMedecin) VALUES ( "+ "'" + rapport.Date_rapport.ToString("yyyy-MM-dd") + "',"+ "'" + rapport.Motif_rapport + "',"+ "'" + rapport.Bilan_rapport + "',"+ rapport.Visiteur_rapport.Id_personne + ","+ rapport.Medecin_rapport.Id_personne + " )";
            // Exécution de la requête
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();
        }

        public static void UpdateRapport(Rapport ancien, Rapport nouveau)
        {
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // Construction de la requête SQL UPDATE'
            dbc.CommandText = "UPDATE rapport SET " + " date = '" + nouveau.Date_rapport.ToString("yyyy-MM-dd") + "'," + " motif = '" + nouveau.Motif_rapport + "'," + " bilan = '" + nouveau.Bilan_rapport + "'," + " idVisiteur = '" + nouveau.Visiteur_rapport.Id_personne + "'," + " idMedecin = '" + nouveau.Medecin_rapport.Id_personne + "' WHERE idRapport = '" + ancien.Id_rapport + "';";
            // Exécution de la requête
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();
        }

        public static void DeleteUnRapport(Rapport rapport)
        {
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL 
            dbc.CommandText = "DELETE FROM offrir WHERE idRapport = '" + rapport.Id_rapport + "';";
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();
            dbc.CommandText = "DELETE FROM rapport WHERE idRapport = '" + rapport.Id_rapport + "';";
            DbDataReader reader2 = dbc.ExecuteReader();
            reader2.Close();

        }

        public static List<Int32> GetIdsRapportsVisiteur(int idVisiteur)
        {
            List<Int32> liste = new List<Int32>(); // la liste des ids
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            dbc.CommandText = "SELECT idRapport FROM rapport " + " WHERE idVisiteur='" + idVisiteur + "' ORDER BY date DESC";
            DbDataReader reader = dbc.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["idRapport"];
                liste.Add(id);
            }
            reader.Close();
            return liste;
        }

        public static List<Int32> GetIdsRapportsMedecin(int idMedecin)
        {
            List<Int32> liste = new List<Int32>(); // la liste des ids
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            dbc.CommandText = "SELECT idRapport FROM rapport " + " WHERE idMedecin='" + idMedecin + "' ORDER BY date DESC";
            DbDataReader reader = dbc.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["idRapport"];
                liste.Add(id);
            }
            reader.Close();
            return liste;
        }

        public static int InsererEchantillon(Offrir offre, Rapport rapport)
        {
            int retour = 1;
            try
            {
                DbCommand dbc = OuvertureConnexion().CreateCommand();
                // Construction de la requête SQL INSERT
                dbc.CommandText = "INSERT INTO offrir VALUES ( " + rapport.Id_rapport + ","+ offre.Medicament_offrir.Id_medicament + ","+ offre.Quantite+ " )";
                // Exécution de la requête
                DbDataReader reader = dbc.ExecuteReader();
                reader.Close();
            }
            catch (Exception)
            {
                retour = 0;
            }
            return retour;
        }

        public static List<Offrir> GetEchantillonsOfferts(int idRapport)
        {
            // Liste des échantillons offerts
            List<Offrir> liste = new List<Offrir>();
            // Requête SQL qui récupère les infos en provenance des tables Offrir et Medicament
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            dbc.CommandText = "SELECT medicament.*, offrir.quantite, famille.libelle FROM " + "((medicament INNER JOIN famille  ON medicament.idFamille = famille.idFamille)" + " INNER JOIN offrir ON offrir.idMedicament = medicament.idMedicament)" + " WHERE offrir.idRapport = '" + idRapport + "' ORDER BY nomCommercial";
            DbDataReader reader = dbc.ExecuteReader();

            while (reader.Read())
            {
                Offrir echantillon;
                // Le médicament
                int id;
                string nomCommercial, composition, effets, contreIndications;
                Famille famille = null;

                // Récupération des informations du médicament
                id = (int)reader["idMedicament"];
                nomCommercial = (string)reader["nomCommercial"];
                composition = (string)reader["composition"];
                effets = (string)reader["effets"];
                contreIndications = (string)reader["contreIndications"];
                famille = new Famille((int)reader["idFamille"], (string)reader["libelle"]);

                // Instanciation des objets
                Medicament medicament = new Medicament(id, nomCommercial, composition, effets, contreIndications, famille);
                // La quantité de l'échantillon
                int quantite = (int)reader["quantite"];
                // Instanciation de l'échantillon offert
                echantillon = new Offrir(medicament, quantite);
                // On l'ajoute à la liste
                liste.Add(echantillon);
            }
            reader.Close();
            return liste;
        }

        public static void DeleteEchantillon(Offrir offre, Rapport rapport)
        {
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // Construction de la requête SQL DELETE
            dbc.CommandText = "DELETE FROM offrir WHERE idRapport = '" + rapport.Id_rapport + "' AND " + "idMedicament = '" + offre.Medicament_offrir.Id_medicament + "';";
            // Exécution de la requête
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();

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
        

        #endregion

        #region Visiteur

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

        public static Visiteur GetVisiteur(string Nom)
        {
            Visiteur visiteur = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM visiteur WHERE nom = '" + Nom + "';";
            DbDataReader reader = dbc.ExecuteReader();
            String nom_personne = "", prenom_personne = "", adresse_personne = "", ville = "", login_visiteur = "", mdp_visiteur = "";
            int id_personne = 0, cp = 0;
            DateTime dateEmbauche = new DateTime();
            if (reader.Read())
            {


                // récupération des informations du médecin
                id_personne = (int)reader[0];
                nom_personne = (String)reader[1];
                prenom_personne = (String)reader[2];
                login_visiteur = (String)reader[3];
                mdp_visiteur = (String)reader[4];
                adresse_personne = (String)reader[5];
                cp = (int)reader[6];
                ville = (String)reader[7];
                dateEmbauche = (DateTime)reader[8];


            }

            reader.Close();
            visiteur = new Visiteur(id_personne, nom_personne, prenom_personne, login_visiteur, mdp_visiteur, adresse_personne, cp, ville, dateEmbauche);
            return visiteur;

        }

        public static Visiteur GetVisiteurParId(int Id)
        {
            Visiteur visiteur = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            dbc.CommandText = "SELECT * FROM visiteur WHERE idVisiteur = '" + Id + "';";
            DbDataReader reader = dbc.ExecuteReader();
            String nom_personne = "", prenom_personne = "", adresse_personne = "", ville = "", login_visiteur = "", mdp_visiteur = "";
            int cp = 0;
            DateTime dateEmbauche = new DateTime();
            if (reader.Read())
            {
                Id = (int)reader["idVisiteur"];
                nom_personne = (string)reader["Nom"];
                prenom_personne = (string)reader["Prenom"];
                login_visiteur = (string)reader["Login"];
                mdp_visiteur = (string)reader["Mdp"];
                adresse_personne = (string)reader["Adresse"];
                cp = (int)reader["cp"];
                ville = (string)reader["Ville"];
                dateEmbauche = (DateTime)reader["DateEmbauche"];
            }

            reader.Close();
            visiteur = new Visiteur(Id, nom_personne, prenom_personne, login_visiteur, mdp_visiteur, adresse_personne, cp, ville, dateEmbauche);
            return visiteur;

        }

        public static Visiteur AjouterUnVisiteur(string nom, string prenom, string login, string mdp, string adresse, int cp, string ville, DateTime dateEmbauche)
        {
            Visiteur visiteur = new Visiteur();
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL 
            dbc.CommandText = "INSERT INTO visiteur (nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche) VALUES ('" + nom + "', '" + prenom + "',  '" + login + "', '" + mdp + "','" + adresse + "', '" + cp + "', '" + ville + "', '" + dateEmbauche.ToString("yyyy-MM-dd") + "')";
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();
            return visiteur;
        }

        public static Visiteur UpdateUnVisiteur(string nom, string prenom, string login, string mdp, string adresse, int cp, string ville, DateTime dateEmbauche)
        {
            Visiteur visiteur = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL
            dbc.CommandText = "UPDATE visiteur SET nom = '" + nom + "' , prenom = '" + prenom + "' , login = '" + login + "', mdp = '" + mdp + "' , adresse = '" + adresse + "' , cp = '" + cp + "', ville = '" + ville + "', dateEmbauche = '" + dateEmbauche.ToString("yyyy-MM-dd") + "' WHERE nom =  '" + nom + "';";
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();
            return visiteur;

        }

        public static Visiteur DeleteUnVisiteur(string nom)
        {
            Visiteur visiteur = null;
            DbCommand dbc = OuvertureConnexion().CreateCommand();
            // requête SQL 
            dbc.CommandText = "DELETE FROM visiteur WHERE nom = '" + nom + "';";
            DbDataReader reader = dbc.ExecuteReader();
            reader.Close();
            return visiteur;

        }

        #endregion
    }
}

