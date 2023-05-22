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
    public partial class ModifierRapport : Form
    {
        public Rapport rapport;
        public ModifierRapport(Rapport leRapport)
        {
            InitializeComponent();

            rapport = leRapport;
        }

        private void ModifierRapport_Load(object sender, EventArgs e)
        {
            List<Medecin> lesMedecins = DBconnect.GetMedecins();
            foreach (Medecin unMedecin in lesMedecins)
            {
                ComboBoxMedecin.Items.Add(unMedecin.ToString());
                if (unMedecin.Id_personne == rapport.Medecin_rapport.Id_personne)
                {
                    ComboBoxMedecin.Text = unMedecin.ToString();
                }
            }

            // Chargement des Visiteurs
            List<Visiteur> lesVisiteurs = DBconnect.GetVisiteurs();
            // Parcourir la liste des visiteurs
            foreach (Visiteur unVisiteur in lesVisiteurs)
            {
                // Ajouter chaque visiteur aux Items de la liste cbVisiteur
                ComboBoxVisiteur.Items.Add(unVisiteur.ToString());
                if (unVisiteur.Id_personne == rapport.Visiteur_rapport.Id_personne)
                {
                    ComboBoxVisiteur.Text = unVisiteur.ToString();
                }
            }

            // Chargement des Médicaments
            List<Medicament> lesMedicaments = DBconnect.GetMedicaments();
            // Parcourir la liste des médicaments
            foreach (Medicament unMedicament in lesMedicaments)
            {
                // Ajouter chaque médicament aux Items de la liste cbMedicament
                comboBoxMedicament.Items.Add(unMedicament.ToString());
            }

            //Initialiser le motif et le bilan et la date
            txtMotif.Text = rapport.Motif_rapport;
            txtBilan.Text = rapport.Bilan_rapport;
            dtDateRapport.Value = rapport.Date_rapport;

            //Initialisation liste des échantillons
            int idRapport = rapport.Id_rapport;
            List<Offrir> LesOffres = DBconnect.GetEchantillonsOfferts(idRapport);
            foreach (Offrir uneOffre in LesOffres)
            {
                dgvMedicament.Rows.Add(uneOffre.Medicament_offrir.NomCommercial_medicament, uneOffre.Quantite);
            }
        }

        private void btnAjouter_Medicament_Click(object sender, EventArgs e)
        {
            if (comboBoxMedicament.SelectedIndex == -1)
            {
                MessageBox.Show("Vous devez sélectionner un médicament !");
                comboBoxMedicament.Focus();
            }
            else
            {
                Medicament unMedicament = DBconnect.GetMedicamentParId(comboBoxMedicament.SelectedIndex+1);
                Offrir uneOffre = new Offrir(unMedicament, (int)nudQte.Value);

                int retour = DBconnect.InsererEchantillon(uneOffre, rapport);
                //Si tout s'est bien passé
                if (retour == 1)
                {
                    //Ajouter dans la liste
                    dgvMedicament.Rows.Add(unMedicament.NomCommercial_medicament, nudQte.Value);

                    MessageBox.Show("L'échantillon a bien été inséré.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cet échantillon existe déjà !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            //Récupération de l'index sélectionné dans Medecin et Visiteur
            int indexMedecin = ComboBoxMedecin.SelectedIndex+1;
            int indexVisiteur = ComboBoxVisiteur.SelectedIndex+1;

            Medecin leMedecin = DBconnect.GetMedecinParId(indexMedecin);
            Visiteur leVisiteur = DBconnect.GetVisiteurParId(indexVisiteur);

            //Instanciation du nouveau rapport
            Rapport nouveauRapport = new Rapport(dtDateRapport.Value, txtMotif.Text, txtBilan.Text, leVisiteur, leMedecin);

            //Fait appel à la passerelle pour modifier le rapport
            DBconnect.UpdateRapport(rapport, nouveauRapport);

            MessageBox.Show("Modification effectuée !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void dgvMedicament_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Voulez vous supprimer cet échantillon ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                //La suppression
                //Récupérer le médicament à supprimer
                string nomMedicament = dgvMedicament.SelectedCells[0].Value.ToString();
                Medicament leMedicament = DBconnect.GetMedicamentByNom(nomMedicament);
                Offrir offre = new Offrir(leMedicament, (int)nudQte.Value);
                //Suppression dans offrir
                DBconnect.DeleteEchantillon(offre, rapport);
                //Suppression dans la liste
                dgvMedicament.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("L'échantillon a bien été supprimé.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous supprimer ce rapport ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                //Fait appel au manager pour supprimer le rapport
                DBconnect.DeleteUnRapport(rapport);

                MessageBox.Show("Suppression effectuée !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Fermeture de la fenêtre
                this.Close();
            }
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
