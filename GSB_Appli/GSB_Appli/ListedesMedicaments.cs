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
    public partial class ListedesMedicaments : Form
    {
        public ListedesMedicaments()
        {
            InitializeComponent();
        }

        private void ListedesMedicaments_Load(object sender, EventArgs e)
        {
            DBconnect.OuvertureConnexion();
            List<Medicament> LesMedicaments = DBconnect.GetMedicaments();
            ListBoxMedicament.Items.Clear();
            foreach (Medicament unMedicament in LesMedicaments)
            {
                ListBoxMedicament.Items.Add(unMedicament.NomCommercial_medicament + " - " + unMedicament.Famille.Libelle_famille);
            }
            List<Famille> LesFamilles = DBconnect.GetFamilles();
            ComboBoxfamille.Items.Clear();
            foreach (Famille unefamille in LesFamilles)
            {
                ComboBoxfamille.Items.Add(unefamille.Libelle_famille);
            }

            mdf_Medicament.Enabled = false;
            sup_medicament.Enabled = false;

        }

        private void ActualisationMedicament()
        {
            DBconnect.OuvertureConnexion();
            List<Medicament> lesMedicaments = DBconnect.GetMedicaments();
            ListBoxMedicament.Items.Clear();
            foreach (Medicament unMedicament in lesMedicaments)
            {
                ListBoxMedicament.Items.Add(unMedicament.NomCommercial_medicament + " - " + unMedicament.Famille.Libelle_famille);
            }

        }
        private void cleardata()
        {
            textBoxId.Clear();
            textBoxEffet.Clear();
            textBoxNomCo.Clear();
            textBoxContreIndic.Clear();
            textBoxCompo.Clear();
            textBoxPrixunitaire.Clear();
            ComboBoxfamille.SelectedIndex = -1;
        }

        private void ListBoxMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupBoxMedicament.Visible = true;
            // récupération de l'indice du médicament sélectionné
            int indexMed = ListBoxMedicament.SelectedIndex + 1;
            // récupération du médicament dans la classe manager
            Medicament medicament = DBconnect.GetMedicament(indexMed);
            // mise à jour des champs de texte
            textBoxId.Text = medicament.Id_medicament.ToString();
            textBoxNomCo.Text = medicament.NomCommercial_medicament;
            textBoxEffet.Text = medicament.Effets_medicament;
            textBoxCompo.Text = medicament.Composition_medicament;
            textBoxContreIndic.Text = medicament.Contreindications_medicament;
            textBoxPrixunitaire.Text = medicament.PrixUnitaire.ToString();
            ComboBoxfamille.Text = medicament.Famille.Libelle_famille;

            mdf_Medicament.Enabled = true;
            sup_medicament.Enabled = true;
            btn_ajoutermedicament.Enabled = false;


        }

        private void btn_ajoutermedicament_Click(object sender, EventArgs e)
        {
            if (textBoxEffet.Text != string.Empty && textBoxNomCo.Text != string.Empty && textBoxContreIndic.Text != string.Empty && textBoxCompo.Text != string.Empty && ComboBoxfamille.Text != string.Empty)
            {
                string effets = textBoxEffet.Text;
                string NomCommercial = textBoxNomCo.Text;
                string contreIndication = textBoxContreIndic.Text;
                string Composition = textBoxCompo.Text;
                int PrixUnitaire = Convert.ToInt32(textBoxPrixunitaire.Text);
                int idFamille = ComboBoxfamille.SelectedIndex;
                Medicament medicament = DBconnect.AjouterUnMedicament(effets, NomCommercial, contreIndication, Composition, idFamille, PrixUnitaire);
                MessageBox.Show("Enregistrement inséré avec succès.", "Enregistrement inséré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleardata();
                ActualisationMedicament();
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur dans tous les champs", "Données non valides", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void GroupBoxMedicament_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cleardata();
            btn_ajoutermedicament.Enabled = true;
            mdf_Medicament.Enabled = false;
            sup_medicament.Enabled = false;
        }

        private void sup_medicament_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != string.Empty)
            {
                int id = int.Parse(textBoxId.Text);
                Medicament medicament = DBconnect.DeleteUnMedicament(id);
                MessageBox.Show("suppresion du médicaments.", "modification inséré", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                cleardata();
                ActualisationMedicament();
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur dans tous les champs", "Données non valides", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mdf_Medicament_Click(object sender, EventArgs e)
        {
            if (textBoxEffet.Text != string.Empty && textBoxNomCo.Text != string.Empty && textBoxContreIndic.Text != string.Empty && textBoxCompo.Text != string.Empty && ComboBoxfamille.Text != string.Empty)
            {
                int id = int.Parse(textBoxId.Text);
                string effets = textBoxEffet.Text;
                string NomCommercial = textBoxNomCo.Text;
                string contreIndication = textBoxContreIndic.Text;
                string Composition = textBoxCompo.Text;
                int PrixUnitaire = Convert.ToInt32(textBoxPrixunitaire.Text);
                int idFamille = ComboBoxfamille.SelectedIndex;
                Medicament medicament = DBconnect.UpdateUnMedicament(id, effets, NomCommercial, contreIndication, Composition, idFamille, PrixUnitaire);
                MessageBox.Show("modifier avec succès.", "modification inséré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleardata();
                ActualisationMedicament();
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur dans tous les champs", "Données non valides", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}


