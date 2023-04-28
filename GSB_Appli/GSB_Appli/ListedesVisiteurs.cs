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

        private void btn_ajoutermedecin_Click(object sender, EventArgs e)
        {

        }

        private void dataGridVisiteur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
         {
             btn_ajoutermedecin.Enabled = false;
             mdf_Medecin.Enabled = true;
             sup_med.Enabled = true;
             int IndexMed = (int)(dataGridVisiteur.CurrentRow.Cells["Id"].Value);
             Visiteur visiteur = DBconnect.GetVisiteur(IndexMed);
             // mise à jour des champs de texte
             textBoxId.Text = visiteur.Id_personne.ToString();
             textBoxNom.Text = visiteur.Nom_personne;
             textBoxPrenom.Text = visiteur.Prenom_personne;
             //dateTimeVisiteur.Text = visiteur.DateEmbauche_visiteur.ToString("dd-MM-yyyy");
             textBoxAdresse.Text = visiteur.Adresse_personne;
             textBoxVille.Text = visiteur.Ville_visiteur;

         }
    }
}
