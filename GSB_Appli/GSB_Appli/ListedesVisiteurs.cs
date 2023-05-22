using Biblio_BD;
using Biblio_gsb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_Appli
{
    public partial class ListedesVisiteurs : Form
    {
        public ListedesVisiteurs()
        {
            InitializeComponent();
        }

        private void ListedesVisiteurs_Load(object sender, EventArgs e)
        {
            DBconnect.OuvertureConnexion();
            List<Visiteur> LesVisiteurs = DBconnect.GetVisiteurs();
            dataGridVisiteur.Rows.Clear();
            foreach (Visiteur unVisiteur in LesVisiteurs)
            {
                dataGridVisiteur.Rows.Add(unVisiteur.Id_personne, unVisiteur.Nom_personne, unVisiteur.Prenom_personne, unVisiteur.DateEmbauche_visiteur, unVisiteur.Cp_visiteur, unVisiteur.Ville_visiteur);

            }

        }


        private void dataGridVisiteur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
         {
             btn_ajoutervisiteur.Enabled = false;
             mdf_Visiteur.Enabled = true;
             sup_Visiteur.Enabled = true;
             String NomVisiteur = (String)(dataGridVisiteur.CurrentRow.Cells["Nom"].Value);
             Visiteur visiteur = DBconnect.GetVisiteur(NomVisiteur);
             // mise à jour des champs de texte
             textBoxNom.Text = visiteur.Nom_personne;
             textBoxPrenom.Text = visiteur.Prenom_personne;
             textBoxLoginVisiteur.Text = visiteur.Login_visiteur;
             textBoxmdpVisiteur.Text = visiteur.Mdp_visiteur;
             dateTimeVisiteur.Text = visiteur.DateEmbauche_visiteur.ToString("dd-MM-yyyy");
             textBoxAdresse.Text = visiteur.Adresse_personne;
             textBoxCodePostal.Text = visiteur.Cp_visiteur.ToString();
             textBoxVille.Text = visiteur.Ville_visiteur;

         }

        private void cleardata()
        {

            textBoxPrenom.Clear();
            textBoxNom.Clear();
            textBoxCodePostal.Clear();
            textBoxVille.Clear();
            textBoxAdresse.Clear();
            textBoxLoginVisiteur.Clear();
            textBoxmdpVisiteur.Clear();

        }
        private void ActualisationVisiteur()
        {

            DBconnect.OuvertureConnexion();
            List<Visiteur> lesVisiteurs = DBconnect.GetVisiteurs();
            dataGridVisiteur.Rows.Clear();
            foreach (Visiteur unVisiteur in lesVisiteurs)
            {
                dataGridVisiteur.Rows.Add(unVisiteur.Id_personne, unVisiteur.Nom_personne, unVisiteur.Prenom_personne, unVisiteur.DateEmbauche_visiteur, unVisiteur.Cp_visiteur, unVisiteur.Ville_visiteur);
            }

        }


        private void btn_ajoutervisiteur_Click(object sender, EventArgs e)
        {
            if (textBoxPrenom.Text != string.Empty && textBoxNom.Text != string.Empty && textBoxCodePostal.Text != string.Empty && dateTimeVisiteur.Text != string.Empty && textBoxVille.Text != string.Empty && textBoxLoginVisiteur.Text != string.Empty && textBoxmdpVisiteur.Text != string.Empty)
            {
                string nom = textBoxNom.Text;
                string prenom = textBoxPrenom.Text;
                string adresse = textBoxAdresse.Text;
                DateTime dateEmbauche = dateTimeVisiteur.Value;
                string ville = textBoxVille.Text;
                string login = textBoxLoginVisiteur.Text;
                string mdp = textBoxmdpVisiteur.Text;
                int cp = Convert.ToInt32(textBoxCodePostal.Text);
                Visiteur visiteur = DBconnect.AjouterUnVisiteur(nom, prenom,login ,mdp ,adresse ,cp ,ville, dateEmbauche);
                MessageBox.Show("Enregistrement inséré avec succès.", "Enregistrement inséré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleardata();
                ActualisationVisiteur();
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur dans tous les champs", "Données non valides", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            cleardata();
            btn_ajoutervisiteur.Enabled = true;
            mdf_Visiteur.Enabled = false;
            sup_Visiteur.Enabled = false;
        }

        private void mdf_Visiteur_Click(object sender, EventArgs e)
        {
            if (textBoxPrenom.Text != string.Empty && textBoxNom.Text != string.Empty && textBoxCodePostal.Text != string.Empty && dateTimeVisiteur.Text != string.Empty && textBoxVille.Text != string.Empty && textBoxLoginVisiteur.Text != string.Empty && textBoxmdpVisiteur.Text != string.Empty)
            {
                string nom = textBoxNom.Text;
                string prenom = textBoxPrenom.Text;
                string adresse = textBoxAdresse.Text;
                int cp = Convert.ToInt32(textBoxCodePostal.Text);
                DateTime DateEmbauche = dateTimeVisiteur.Value;
                string ville = textBoxVille.Text;
                string login = textBoxLoginVisiteur.Text;
                string mdp = textBoxmdpVisiteur.Text;
                Visiteur visiteur = DBconnect.UpdateUnVisiteur( nom,  prenom,  login,  mdp,  adresse,  cp,  ville, DateEmbauche);
                MessageBox.Show("modifier avec succès.", "modification inséré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleardata();
                ActualisationVisiteur();
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur dans tous les champs", "Données non valides", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btn_ajoutervisiteur.Enabled = true;
            mdf_Visiteur.Enabled = false;
            sup_Visiteur.Enabled = false;
        }

        private void sup_Visiteur_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text != string.Empty)
            {
                string nom = textBoxNom.Text;
                Visiteur rapport = DBconnect.DeleteUnVisiteur(nom);
                MessageBox.Show("suppresion du rapport.", "modification inséré", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                cleardata();
                ActualisationVisiteur();
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur dans tous les champs", "Données non valides", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btn_ajoutervisiteur.Enabled = true;
            mdf_Visiteur.Enabled = false;
            sup_Visiteur.Enabled = false;
        }
    }
}
