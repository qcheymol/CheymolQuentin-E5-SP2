using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_gsb
{
    public class Offrir
    {
        private int quantite;
        private Medicament id_medicament;
        #region constructeur
        public Offrir()
        {

        }
        public Offrir(Medicament id_medicament,  int quantite)

        {
            this.id_medicament = id_medicament;
            this.quantite = quantite;
        }

        #endregion

        #region accesseur
        public Medicament Medicament_offrir { get => id_medicament; set => id_medicament = value; }
        public int Quantite { get => quantite; set => quantite = value; }

        #endregion
    }
}
