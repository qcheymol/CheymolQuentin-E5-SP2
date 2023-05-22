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
    public partial class AjouterRapport : Form
    {
        public AjouterRapport()
        {
            InitializeComponent();
        }

        private void AjouterRapport_Load(object sender, EventArgs e)
        {
            // Chargement des Médecins
            List<Medecin> lesMedecins = DBconnect.GetMedecins();
            // Parcourir la liste des médecins
            foreach (Medecin unMedecin in lesMedecins)
            {
                // Ajouter chaque médecin aux Items de la liste cbMedecin
                cbMedecin.Items.Add(unMedecin.ToString());
            }

            // Chargement des Visiteurs
            List<Visiteur> lesVisiteurs = DBconnect.GetVisiteurs();
            // Parcourir la liste des visiteurs
            foreach (Visiteur unVisiteur in lesVisiteurs)
            {
                // Ajouter chaque visiteur aux Items de la liste cbVisiteur
                cbVisiteur.Items.Add(unVisiteur.ToString());
            }

            // Chargement des Médicaments
            List<Medicament> lesMedicaments = DBconnect.GetMedicaments();
            // Parcourir la liste des médicaments
            foreach (Medicament unMedicament in lesMedicaments)
            {
                // Ajouter chaque médicament aux Items de la liste cbMedicament
                cbMedicament.Items.Add(unMedicament.ToString());
            }

        }

        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            //Récupération des valeurs des champs de texte et instanciation d'un rapport
            //Récupération de l'index sélectionné dans Medecin et Visiteur
            int indexMedecin = cbMedecin.SelectedIndex+1;
            int indexVisiteur = cbVisiteur.SelectedIndex+1;
            //Récupération du médecin et du visiteur
            Medecin leMedecin = DBconnect.GetMedecinParId(indexMedecin);
            Visiteur leVisiteur = DBconnect.GetVisiteurParId(indexVisiteur);

            //Instanciation du rapport
            Rapport unRapport = new Rapport(dtDateRapport.Value, txtMotif.Text, txtBilan.Text, leVisiteur, leMedecin);

            //On fait appel à la passerelle pour enregistrer le rapport
            DBconnect.AjouterUnRapport(unRapport);

            //Message de confirmation
            MessageBox.Show("Le rapport a été créé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Donner la possibilité d'enregistrer des échantillons
            panelMed.Visible = true;
        }

        private void btAjoutMed_Click(object sender, EventArgs e)
        {
            if (cbMedicament.SelectedIndex == -1)
            {
                MessageBox.Show("Vous devez sélectionner un médicament !");
                cbMedicament.Focus();
            }
            else
            {
                //Récupération du médecin et du visiteur 
                Medecin leMedecin = DBconnect.GetMedecinParId(cbMedecin.SelectedIndex+1);
                Visiteur leVisiteur = DBconnect.GetVisiteurParId(cbVisiteur.SelectedIndex+1);
                //Récup le médicament, id du rapport
                Medicament leMedicament = DBconnect.GetMedicamentParId(cbMedicament.SelectedIndex+1);

                Rapport leRapport = DBconnect.GetIdRapport(dtDateRapport.Value, leVisiteur.Id_personne, leMedecin.Id_personne);
                Offrir unEchantillon = new Offrir(leMedicament, (int)nudQte.Value);

                //On fait appel au manager pour ajouter échantillon
                int retour = DBconnect.InsererEchantillon(unEchantillon, leRapport);

                //Si tout s'est bien passé
                if (retour == 1)
                {
                    //Ajouter dans la liste
                    dgvMedicament.Rows.Add(leMedicament.NomCommercial_medicament, nudQte.Value);

                    MessageBox.Show("L'échantillon a bien été inséré.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cet échantillon existe déjà !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvMedicament_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Voulez vous supprimer cet échantillon ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //La suppression
                //Récupérer le médicament à supprimer
                string nomMedicament = dgvMedicament.SelectedCells[0].Value.ToString();
                Medicament leMedicament = DBconnect.GetMedicamentByNom(nomMedicament);
                //Récupération du médecin et du visiteur grâce au manager
                Medecin leMedecin = DBconnect.GetMedecinParId(cbMedecin.SelectedIndex);
                Visiteur leVisiteur = DBconnect.GetVisiteurParId(cbVisiteur.SelectedIndex);
                //Récup le médicament, id du rapport
                Rapport leRapport = DBconnect.GetIdRapport(dtDateRapport.Value, leVisiteur.Id_personne, leMedecin.Id_personne);
                Offrir echantillon = new Offrir(leMedicament, (int)nudQte.Value);
                //Suppression dans offrir
                DBconnect.DeleteEchantillon(echantillon, leRapport);
                //Suppression dans la liste
                dgvMedicament.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("L'échantillon a bien été supprimé.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous fermer la fenêtre ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btEffacer_Click(object sender, EventArgs e)
        {
            cbMedecin.SelectedIndex = -1;
            cbVisiteur.SelectedIndex = -1;
            txtBilan.Text = "";
            txtIdRapport.Text = "";
            txtMotif.Text = "";
        }
    }
}

