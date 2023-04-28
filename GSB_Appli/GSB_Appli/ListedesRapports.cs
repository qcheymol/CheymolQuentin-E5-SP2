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
    public partial class ListedesRapports : Form
    {
        public ListedesRapports()
        {
            InitializeComponent();
        }

        private void ListedesRapports_Load(object sender, EventArgs e)
        {
            DBconnect.OuvertureConnexion();
            List<Medecin> lesMedecins = DBconnect.GetMedecins();
            comboBox_Medecin.Items.Clear();
            foreach (Medecin unMedecin in lesMedecins)
            {
                comboBox_Medecin.Items.Add(unMedecin.Nom_personne.ToString() + " " + unMedecin.Prenom_personne);
            }

            List<Visiteur> LesVisiteurs = DBconnect.GetVisiteurs();
            comboBox_Visiteur.Items.Clear();
            foreach (Visiteur unVisiteur in LesVisiteurs)
            {
                comboBox_Visiteur.Items.Add(unVisiteur.Nom_personne.ToString() + " " + unVisiteur.Prenom_personne);
            }

            List<Rapport> LesRapport = DBconnect.GetRapports();
            dataGridRapport.Rows.Clear();
            foreach (Rapport unRapport in LesRapport)
            {
                dataGridRapport.Rows.Add(unRapport.Id_rapport, unRapport.Date_rapport, unRapport.Motif_rapport, unRapport.Bilan_rapport, unRapport.Medecin_rapport, unRapport.Visiteur_rapport);

            }
            mdf_Rapport.Enabled = false;
            sup_Rapport.Enabled = false;
        }
        private void cleardata()
        {
            comboBox_Medecin.SelectedIndex = -1;
            comboBox_Visiteur.SelectedIndex = -1;
            textBoxMotif.Clear();
            textBoxBilan.Clear();
        }

        private void ActualisationRapport()
        {
            DBconnect.OuvertureConnexion();
            List<Rapport> lesRapport = DBconnect.GetRapports();
            dataGridRapport.Rows.Clear();
            foreach (Rapport unRapport in lesRapport)
            {
                dataGridRapport.Rows.Add(unRapport.Date_rapport, unRapport.Motif_rapport, unRapport.Bilan_rapport, unRapport.Medecin_rapport, unRapport.Visiteur_rapport);
            }

        }
        private void btn_ajouterRapport_Click(object sender, EventArgs e)
        {
           /* if (comboBox_Medecin.Text != string.Empty && comboBox_Visiteur.Text != string.Empty && dateTimeDate.Text != string.Empty && textBoxMotif.Text != string.Empty && textBoxBilan.Text != string.Empty)
            {
                Medecin Medecin = comboBox_Medecin.SelectedIndex-1;
                Visiteur Visiteur = comboBox_Visiteur.SelectedIndex-1;
                DateTime convertion = Convert.ToDateTime(dateTimeDate.Text); string Date = convertion.ToString("yyyy-MM-dd");
                string Motif = textBoxMotif.Text;
                string Bilan = textBoxBilan.Text;
                Rapport rapport = DBconnect.AjouterUnRapport(Date, Motif, Bilan, Visiteur, Medecin);
                MessageBox.Show("Enregistrement inséré avec succès.", "Enregistrement inséré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleardata();
                ActualisationRapport();
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur dans tous les champs", "Données non valides", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/


        }


        private void sup_Rapport_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != string.Empty)
            {
                int id = int.Parse(textBoxId.Text);
                Rapport rapport = DBconnect.DeleteUnRapport(id);
                MessageBox.Show("suppresion du rapport.", "modification inséré", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                cleardata();
                ActualisationRapport();
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur dans tous les champs", "Données non valides", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridRapport_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btn_ajouterRapport.Enabled = false;
            mdf_Rapport.Enabled = true;
            sup_Rapport.Enabled = true;
            int IndexRap = (int)(dataGridRapport.CurrentRow.Cells["idRapport"].Value);
            Rapport rapport = DBconnect.GetRapport(IndexRap);
            MessageBox.Show(rapport.Medecin_rapport.ToString());
            Medecin medecin = DBconnect.GetMedecin(rapport.Medecin_rapport.Id_personne);
            Visiteur visiteur = DBconnect.GetVisiteur(rapport.Visiteur_rapport.Id_personne);
            // mise à jour des champs de texte
          
            textBoxId.Text = rapport.Id_rapport.ToString();
            comboBox_Medecin.SelectedIndex = rapport.Medecin_rapport.Id_personne;
            comboBox_Visiteur.SelectedIndex = rapport.Visiteur_rapport.Id_personne;
            dateTimeDate.Text = rapport.Date_rapport.ToString("dd-MM-yyyy");
            textBoxMotif.Text = rapport.Motif_rapport;
            textBoxBilan.Text = rapport.Bilan_rapport;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cleardata();
            btn_ajouterRapport.Enabled = true;
            mdf_Rapport.Enabled = false;
            sup_Rapport.Enabled = false;
        }

        private void mdf_Rapport_Click(object sender, EventArgs e)
        {
           if (comboBox_Medecin.Text != string.Empty && comboBox_Visiteur.Text != string.Empty && dateTimeDate.Text != string.Empty && textBoxMotif.Text != string.Empty && textBoxBilan.Text != string.Empty)
            {
                int id = int.Parse(textBoxId.Text);
                int Medecin = comboBox_Medecin.SelectedIndex - 1;
                int Visiteur = comboBox_Visiteur.SelectedIndex - 1;
                DateTime Date = Convert.ToDateTime("yyyy-MM-dd");
                string Motif = textBoxMotif.Text;
                string Bilan = textBoxBilan.Text;
                Rapport rapport = DBconnect.UpdateUnRapport(id, Date, Motif, Bilan, Visiteur, Medecin);
                MessageBox.Show("modifier avec succès.", "modification inséré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleardata();
                ActualisationRapport();
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur dans tous les champs", "Données non valides", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    
}
