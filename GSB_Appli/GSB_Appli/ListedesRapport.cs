using Biblio_BD;
using Biblio_gsb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_Appli
{
    public partial class ListedesRapport : Form
    {
        public ListedesRapport()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtNomMedecin.Text = "";
            txtPrenomMedecin.Text = "";
            txtMotif.Text = "";
            txtBilan.Text = "";
            dtDateRapport.Value = DateTime.Now;
            txtNomVisiteur.Text = "";
            txtPrenomVisiteur.Text = "";
            txtAdresseMedecin.Text = "";
            lvMedicaments.Items.Clear();
            listRapports.Items.Clear();
        }

        private void btEffacer_Click(object sender, EventArgs e)
        {
            comboBoxMedecin.SelectedIndex = -1;
            comboBoxVisiteur.SelectedIndex = -1;
            Clear();
        }

        private void ListedesRapport_Load(object sender, EventArgs e)
        {
            DBconnect.OuvertureConnexion();
            List<Visiteur> LesVisiteurs = DBconnect.GetVisiteurs();
            comboBoxVisiteur.Items.Clear();
            foreach (Visiteur unVisiteur in LesVisiteurs)
            {
                comboBoxVisiteur.Items.Add(unVisiteur.Nom_personne + " " + unVisiteur.Prenom_personne);
            }

            DBconnect.OuvertureConnexion();
            List<Medecin> LesMedecins = DBconnect.GetMedecins();
            comboBoxMedecin.Items.Clear();
            foreach (Medecin unMedecin in LesMedecins)
            {
                comboBoxMedecin.Items.Add(unMedecin.Nom_personne + " " + unMedecin.Prenom_personne);
            }
        }

        private void btRechercherVisiteur_Click(object sender, EventArgs e)
        {
            if (comboBoxVisiteur.SelectedIndex == -1)
            {
                MessageBox.Show("Vous devez sélectionner un visiteur !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Effacer si nécessaire précédente sélection cbMedecin
                comboBoxMedecin.SelectedIndex = -1;
                Clear();

                // Récupération du visiteur sélectionné
                int indexVisiteur = comboBoxVisiteur.SelectedIndex+1;
                // On va rechercher les rapports grâce au Manager
                List<Int32> idsDesRapports = DBconnect.GetIdsRapportsVisiteur(indexVisiteur); // A COMPLETER
                // On efface les éléments de la liste listRapports
                listRapports.Items.Clear();
                // On affiche ces ids de rapports dans la liste listRapports
                foreach (int idRapport in idsDesRapports)
                {
                    // On ajoute l’idRapport aux Items de la liste listRapports
                    listRapports.Items.Add(idRapport);
                }
            }
        }

        private void btRechercherMedecin_Click(object sender, EventArgs e)
        {
            if (comboBoxMedecin.SelectedIndex == -1)
            {
                MessageBox.Show("Vous devez sélectionner un médecin !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Effacer si nécessaire précédente sélection cbVisiteur et valeurs dans les zones
                comboBoxVisiteur.SelectedIndex = -1;
                Clear();
                // Récupération du médecin sélectionné
                int indexMedecin = comboBoxMedecin.SelectedIndex+1;
                // On va rechercher les rapports grâce au Manager
                List<Int32> idsDesRapports = DBconnect.GetIdsRapportsMedecin(indexMedecin);
                // On efface les éléments de la liste listRapports
                listRapports.Items.Clear();
                // On affiche ces ids de rapports dans la liste listRapports
                foreach (int idRapport in idsDesRapports)
                {
                    // On ajoute l’idRapport aux Items de la liste listRapports
                    listRapports.Items.Add(idRapport);
                }
            }
        }

        private void listRapports_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvMedicaments.Items.Clear();
            // Récupération de l’id du rapport
            int idRapport = Int32.Parse(this.listRapports.Text);
            // On récupérer le rapport
            Rapport rapport = DBconnect.GetRapport(idRapport);
            // Affichage des infos du rapport + visiteur + medecin
            txtNomMedecin.Text = rapport.Medecin_rapport.Nom_personne;
            txtPrenomMedecin.Text = rapport.Medecin_rapport.Prenom_personne;
            txtMotif.Text = rapport.Motif_rapport;
            txtBilan.Text = rapport.Bilan_rapport;
            dtDateRapport.Value = rapport.Date_rapport;
            txtNomVisiteur.Text = rapport.Visiteur_rapport.Nom_personne;
            txtPrenomVisiteur.Text = rapport.Visiteur_rapport.Prenom_personne;
            txtAdresseMedecin.Text = rapport.Medecin_rapport.Adresse_personne;
            //Compléter les échantillons si necessaire
            List<Offrir> LesOffres = DBconnect.GetEchantillonsOfferts(idRapport);
            foreach (Offrir uneOffre in LesOffres)
            {
                String[] med = { uneOffre.Medicament_offrir.NomCommercial_medicament, uneOffre.Quantite.ToString() };  // valeurs récupérées
                ListViewItem lvAdd = new ListViewItem(med);
                lvMedicaments.Items.Add(lvAdd);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {

        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir modifier le rapport ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                // Récupération de l’id du rapport
                int idRapport = Int32.Parse(this.listRapports.Text);
                // On utilise le Manager pour récupérer le rapport
                Rapport rapport = DBconnect.GetRapport(idRapport);
                ModifierRapport modifier = new ModifierRapport(rapport);
                modifier.Show();
            }
            //Effacer les valeurs
            comboBoxMedecin.SelectedIndex = -1;
            comboBoxVisiteur.SelectedIndex = -1;
            Clear();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous fermer la fenêtre ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

