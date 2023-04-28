using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_gsb
{
    public class Specialite
    {
        int id_specialite;
        string libelle_specialite;


        #region constructeur
        public Specialite()
        {

        }
        public Specialite(int id_specialite, string libelle_specialite)
        {
            this.id_specialite = id_specialite;
            this.libelle_specialite = libelle_specialite;
        }

        #endregion

        #region accesseur

        public int Id_specialite { get => id_specialite; set => id_specialite = value; }
        public string Libelle_specialite { get => libelle_specialite; set => libelle_specialite = value; }


        #endregion
    }
}
