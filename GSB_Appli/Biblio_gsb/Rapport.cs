using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_gsb
{
    public class Rapport
    {
        private int id_rapport;
        private DateTime date;
        private string motif, bilan;
        private Medecin leMedecin;
        private Visiteur leVisiteur;
        public Rapport()
        {
 
        }

        public Rapport(int id_rapport, DateTime date,string motif, string bilan, Medecin leMedecin, Visiteur leVisiteur)
        {
            this.id_rapport = id_rapport;
            this.date = date;
            this.motif = motif;
            this.bilan = bilan;
            this.leMedecin = leMedecin;
            this.leVisiteur = leVisiteur;

        }

        public int Id_rapport { get => id_rapport; set => id_rapport = value; }
        public DateTime Date_rapport { get => date; set => date = value; }
        public string Motif_rapport { get => motif; set => motif = value; }
        public string Bilan_rapport { get => bilan; set => bilan = value; }
        public Medecin Medecin_rapport { get => leMedecin; set => leMedecin = value; }
        public Visiteur Visiteur_rapport { get => leVisiteur; set => leVisiteur = value; }

        public override string ToString()
        {
            return Id_rapport + " " + Motif_rapport + " " + leMedecin;
        }


    }
}
