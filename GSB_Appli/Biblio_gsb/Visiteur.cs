using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_gsb
{
    public class Visiteur : Personne
    {
        private string login_visiteur, mdp_visiteur, ville_visiteur;
        private int cp_visiteur;
        private DateTime dateEmbauche_visiteur;

        #region constructeur
        public Visiteur()
        {

        }
        public Visiteur(int id_personne, string nom_personne, string prenom_personne, string adresse_personne, string login_visiteur, string mdp_visiteur, int cp_visiteur, string ville_visiteur, DateTime dateEmbauche_visiteur)
        : base(id_personne, nom_personne, prenom_personne, adresse_personne)
        {
            this.login_visiteur = login_visiteur;
            this.mdp_visiteur = mdp_visiteur;
            this.cp_visiteur = cp_visiteur;
            this.ville_visiteur = ville_visiteur;
            this.dateEmbauche_visiteur = dateEmbauche_visiteur;
        }

        public Visiteur(int id_personne, string nom_personne, string prenom_personne, string adresse_personne)
         : base(id_personne, nom_personne, prenom_personne, adresse_personne)
        {
        }

        #endregion

        #region accesseur
        public string Login_visiteur { get => login_visiteur; set => login_visiteur = value; }
        public string Mdp_visiteur { get => mdp_visiteur; set => mdp_visiteur = value; }
        public int Cp_visiteur { get => cp_visiteur; set => cp_visiteur = value; }
        public string Ville_visiteur { get => ville_visiteur; set => ville_visiteur = value; }
        public DateTime DateEmbauche_visiteur { get => dateEmbauche_visiteur; set => dateEmbauche_visiteur = value; }

        #endregion
    }
}
