using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_gsb
{
    public class Medicament
    {
        private int id_medicament, prixUnitaire;
        private string nomCommercial_medicament, composition_medicament, effets_medicament, contreindications_medicament;
        private Famille famille;

        #region constructeur
        public Medicament()
        {

        }
        public Medicament(int id_medicament, string nomCommercial_medicament, string composition_medicament, string effets_medicament, string contreindications_medicament, int prixUnitaire, Famille famille)

        {
            this.id_medicament = id_medicament;
            this.nomCommercial_medicament = nomCommercial_medicament;
            this.composition_medicament = composition_medicament;
            this.effets_medicament = effets_medicament;
            this.prixUnitaire = prixUnitaire;
            this.contreindications_medicament = contreindications_medicament;
            this.famille = famille;

        }
        public Medicament(int id_medicament, string nomCommercial_medicament,string composition_medicament, string effets_medicament, string contreindications_medicament, int prixUnitaire)

        {
            this.id_medicament = id_medicament;
            this.nomCommercial_medicament = nomCommercial_medicament;
            this.composition_medicament = composition_medicament;
            this.effets_medicament = effets_medicament;
            this.contreindications_medicament = contreindications_medicament;
            this.prixUnitaire = prixUnitaire;


        }

        public Medicament(int id_medicament, string nomCommercial_medicament, string composition_medicament, string effets_medicament, string contreindications_medicament, Famille famille)
        {
            this.id_medicament = id_medicament;
            this.nomCommercial_medicament = nomCommercial_medicament;
            this.composition_medicament = composition_medicament;
            this.effets_medicament = effets_medicament;
            this.contreindications_medicament = contreindications_medicament;
            this.famille = famille;
        }

        public Medicament(int id_medicament, string nomCommercial_medicament)

        {
            this.id_medicament = id_medicament;
            this.nomCommercial_medicament = nomCommercial_medicament;
        }

        #endregion

        #region accesseur
        public int Id_medicament { get => id_medicament; set => id_medicament = value; }
        public string NomCommercial_medicament { get => nomCommercial_medicament; set => nomCommercial_medicament = value; }
        public string Composition_medicament { get => composition_medicament; set => composition_medicament = value; }
        public string Effets_medicament { get => effets_medicament; set => effets_medicament = value; }
        public string Contreindications_medicament { get => contreindications_medicament; set => contreindications_medicament = value; }
        public int PrixUnitaire { get => prixUnitaire; set => prixUnitaire = value; }
        public Famille Famille { get => famille; set => famille = value; }

        #endregion

        #region fonction
        public override string ToString()
        {
            string msg;

            msg = nomCommercial_medicament + " " + famille.Libelle_famille;

            return msg;
        }
        #endregion
    }
}
