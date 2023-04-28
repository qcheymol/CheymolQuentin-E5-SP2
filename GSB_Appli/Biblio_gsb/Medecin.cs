using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_gsb
{
    public class Medecin : Personne
    {
        private Specialite laSpecialite;
        private string tel, departement;

        #region constructeur
        public Medecin()
        {

        }

        public Medecin(int id_personne, string nom_personne, string prenom_personne, string adresse_personne, string tel, String departement, Specialite laSpecialite) : base(id_personne, nom_personne, prenom_personne, adresse_personne)
        {
            this.tel = tel;
            this.departement = departement;
            this.laSpecialite = laSpecialite;

        }

        #endregion

        #region accesseur
        public Specialite LaSpecialite { get => laSpecialite; set => laSpecialite = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Departement { get => departement; set => departement = value; }

        #endregion

        #region fonction


        public override string ToString()
        {
            return Nom_personne + " " + Prenom_personne;
        }


        #endregion
    }
}
