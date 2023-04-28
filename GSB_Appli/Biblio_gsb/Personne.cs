using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_gsb
{
    public class Personne
    {
        private int id_personne;
        private string nom_personne, prenom_personne, adresse_personne;

        #region constructeur
        public Personne()
        {

        }
        public Personne(int id_personne, string nom_personne, string prenom_personne, string adresse_personne)
        {
            this.id_personne = id_personne;
            this.nom_personne = nom_personne;
            this.prenom_personne = prenom_personne;
            this.adresse_personne = adresse_personne;
        }

        #endregion

        #region accesseur

        public int Id_personne { get => id_personne; set => id_personne = value; }
        public string Nom_personne { get => nom_personne; set => nom_personne = value; }
        public string Prenom_personne { get => prenom_personne; set => prenom_personne = value; }
        public string Adresse_personne { get => adresse_personne; set => adresse_personne = value; }

        #endregion

        #region fonction
        public virtual string Tostring()
        {
            return "";
        }
        #endregion
    }
}
