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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void listeDesMédecinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ListedesMedecins frm = new ListedesMedecins();
            frm.Show();
            
        }

        private void listeDesVisiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListedesVisiteurs frm = new ListedesVisiteurs();
            frm.Show();
        }

        private void listeDesMédicamentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ListedesMedicaments frm = new ListedesMedicaments();
            frm.Show();
        }

        private void QuitterMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listeDesRapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListedesRapports frm = new ListedesRapports() ;
            frm.Show();
        }
    }
}
