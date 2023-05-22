using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_gsb
{
    public class Rapport
    {
        private int id_rapport, idVisiteur, idMedecin;
        private DateTime date;
        private string motif, bilan;
        private Medecin leMedecin;
        private Visiteur leVisiteur;
        private List<Offrir> lesOffres;
        public Rapport()
        {
 
        }
        public Rapport( DateTime date, string motif, string bilan, Visiteur leVisiteur, Medecin leMedecin)
        {
            this.date = date;
            this.motif = motif;
            this.bilan = bilan;
            this.leMedecin = leMedecin;
            this.leVisiteur = leVisiteur;
            this.lesOffres = new List<Offrir>();

        }
        public Rapport(int id_rapport, DateTime date,string motif, string bilan, Visiteur leVisiteur, Medecin leMedecin)
        {
            this.id_rapport = id_rapport;
            this.date = date;
            this.motif = motif;
            this.bilan = bilan;
            this.leMedecin = leMedecin;
            this.leVisiteur = leVisiteur;
            this.lesOffres = new List<Offrir>();

        }
        public Rapport(int id_rapport, DateTime date, string motif, string bilan,int idVisiteur, int idMedecin)
        {
            this.id_rapport = id_rapport;
            this.date = date;
            this.motif = motif;
            this.bilan = bilan;
            this.idMedecin = idMedecin;
            this.idVisiteur = idVisiteur;
            this.lesOffres = new List<Offrir>();

        }

        public int Id_rapport { get => id_rapport; set => id_rapport = value; }
        public DateTime Date_rapport { get => date; set => date = value; }
        public string Motif_rapport { get => motif; set => motif = value; }
        public string Bilan_rapport { get => bilan; set => bilan = value; }
        public Medecin Medecin_rapport { get => leMedecin; set => leMedecin = value; }
        public Visiteur Visiteur_rapport { get => leVisiteur; set => leVisiteur = value; }
        public List<Offrir> LesOffres { get => lesOffres; set => lesOffres = value; }

        public override string ToString()
        {
            return Id_rapport + " " + Motif_rapport + " " + leMedecin;
        }


    }
}
