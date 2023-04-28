using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_gsb
{
    class Offrir
    {
        private Medicament id_medicament;
        private Rapport id_rapport;
        private int quantite;



        #region constructeur
        public Offrir()
        {

        }
        public Offrir(Medicament id_medicament, Rapport id_rapport, int quantite)

        {
            this.id_medicament = id_medicament;
            this.id_rapport = id_rapport;
            this.quantite = quantite;
        }
        public Offrir(int quantite)

        {
            this.quantite = quantite;
        }

        #endregion

        #region accesseur
        public Medicament Id_medicament { get => id_medicament; set => id_medicament = value; }
        public Rapport Id_rapport { get => id_rapport; set => id_rapport = value; }
        public int Quantite { get => quantite; set => quantite = value; }

        #endregion
    }
}
