using Biblio_BD;
using Biblio_gsb;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace GSB_Appli
{
    public partial class ListedesMedecins : Form
    {
        public ArrayList lesMedecins = new ArrayList();
        public ListedesMedecins()
        {
            InitializeComponent();
        }


        private void ListedesMedecins_Load(object sender, EventArgs e)
        {

            DBconnect.OuvertureConnexion();
            List<Medecin> lesMedecins = DBconnect.GetMedecins();
            dtgMedecin.Rows.Clear();
            foreach (Medecin unMedecin in lesMedecins)
            {
                dtgMedecin.Rows.Add(unMedecin.Id_personne ,unMedecin.Nom_personne.ToString(), unMedecin.Prenom_personne, unMedecin.Adresse_personne, unMedecin.Tel, unMedecin.Departement, unMedecin.LaSpecialite.Libelle_specialite);
            }

            List<Specialite> lesSpecialites = DBconnect.GetSpecialites();
            comboBoxSpecialite.Items.Clear();
            foreach (Specialite uneSpecialite in lesSpecialites)
            {
                comboBoxSpecialite.Items.Add(uneSpecialite.Libelle_specialite);
            }

            mdf_Medecin.Enabled = false;
            sup_med.Enabled = false;

        }

        private void btn_ajoutermedecin_Click(object sender, EventArgs e)
        {
            if (textBoxPrenom.Text != string.Empty && textBoxNom.Text != string.Empty && textBoxAdresse.Text != string.Empty && textBoxTelephone.Text != string.Empty && textBoxDepartement.Text != string.Empty && comboBoxSpecialite.Text != string.Empty)
            {
                string nom = textBoxNom.Text;
                string prenom = textBoxPrenom.Text; 
                string adresse = textBoxAdresse.Text;
                string tel = textBoxTelephone.Text;
                string departement = textBoxDepartement.Text;
                int idSpecialite = comboBoxSpecialite.SelectedIndex;
                Medecin medecin = DBconnect.AjouterUnMedecin(nom, prenom, adresse, tel, departement, idSpecialite);
                MessageBox.Show("Enregistrement inséré avec succès.", "Enregistrement inséré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleardata();
                ActualisationMedecin();
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur dans tous les champs", "Données non valides", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cleardata()
        {
            textBoxId.Clear();
            textBoxPrenom.Clear();
            textBoxNom.Clear();
            textBoxAdresse.Clear();
            textBoxTelephone.Clear();
            textBoxDepartement.Clear();
            comboBoxSpecialite.SelectedIndex = -1;

        }

        private void ActualisationMedecin()
        {
            DBconnect.OuvertureConnexion();
            List<Medecin> lesMedecins = DBconnect.GetMedecins();
            dtgMedecin.Rows.Clear();
            foreach (Medecin unMedecin in lesMedecins)
            {
                dtgMedecin.Rows.Add(unMedecin.Id_personne ,unMedecin.Nom_personne.ToString(), unMedecin.Prenom_personne, unMedecin.Adresse_personne, unMedecin.Tel, unMedecin.Departement, unMedecin.LaSpecialite.Libelle_specialite);
            }
            
        }

        private void mdf_Medecin_Click(object sender, EventArgs e)
        {
            if (textBoxPrenom.Text != string.Empty && textBoxNom.Text != string.Empty && textBoxAdresse.Text != string.Empty && textBoxTelephone.Text != string.Empty && textBoxDepartement.Text != string.Empty && comboBoxSpecialite.Text != string.Empty)
             {
             int id = int.Parse(textBoxId.Text);
             string nom = textBoxNom.Text;
             string prenom = textBoxPrenom.Text;
             string adresse = textBoxAdresse.Text;
             string tel = textBoxTelephone.Text;
             string departement = textBoxDepartement.Text;
             int idSpecialite = comboBoxSpecialite.SelectedIndex;
             Medecin medecin = DBconnect.UpdateUnMedecin(id , nom, prenom, adresse, tel, departement, idSpecialite);
                 MessageBox.Show("modifier avec succès.", "modification inséré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 cleardata();
                 ActualisationMedecin();
             }
             else
             {
                 MessageBox.Show("Veuillez entrer une valeur dans tous les champs", "Données non valides", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
        }

        private void sup_med_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != string.Empty)
            {
                int id = int.Parse(textBoxId.Text);
                Medecin medecin = DBconnect.DeleteUnMedecin(id);
                    MessageBox.Show("suppresion du médecin.", "modification inséré", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    cleardata();
                    ActualisationMedecin();
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur dans tous les champs", "Données non valides", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

            private void btnClear_Click(object sender, EventArgs e)
        {
            cleardata();
            btn_ajoutermedecin.Enabled = true;
            mdf_Medecin.Enabled = false;
            sup_med.Enabled = false;
        }

        private void dtgMedecin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ajoutermedecin.Enabled = false;
            mdf_Medecin.Enabled = true;
            sup_med.Enabled = true;
            int IndexMed = (int)(dtgMedecin.CurrentRow.Cells["Id"].Value);
            Medecin medecin = DBconnect.GetMedecin(IndexMed);
            // mise à jour des champs de texte
            textBoxId.Text = medecin.Id_personne.ToString();
            textBoxNom.Text = medecin.Nom_personne;
            textBoxPrenom.Text = medecin.Prenom_personne;
            textBoxAdresse.Text = medecin.Adresse_personne;
            textBoxTelephone.Text = medecin.Tel;
            textBoxDepartement.Text = medecin.Departement;
            comboBoxSpecialite.Text = medecin.LaSpecialite.Libelle_specialite;
        }
    }
}
